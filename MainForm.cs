using System.Windows.Forms;
using EnglishLearning.Agents;
using EnglishLearning.Services;
using EnglishLearning.Models;

namespace EnglishLearning
{
    public partial class MainForm : Form
    {
        private readonly TextGenerationAgent _textAgent;
        private readonly VocabularyAgent _vocabAgent;
        private readonly AIService _aiService;
        private readonly Settings _settings;

        public MainForm()
        {
            InitializeComponent();
            
            _settings = AppData.LoadSettings();
            _aiService = new AIService();
            _aiService.SetConfig(_settings.ApiKey, _settings.AiModel);
            
            _textAgent = new TextGenerationAgent(_aiService);
            _vocabAgent = new VocabularyAgent();
            _vocabAgent.LoadVocabulary(AppData.LoadVocabulary());

            _textAgent.SetNext(_vocabAgent);
            
            InitializeUI();
            BindEvents();
        }

        private void InitializeUI()
        {
            // 设置圆角按钮
            foreach (Control control in toolbarPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 5, 5));
                }
            }

            // 设置圆角内容面板
            contentPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, contentPanel.Width, contentPanel.Height, 10, 10));
        }

        private void BindEvents()
        {
            btnGenerateText.Click += async (s, e) =>
            {
                await _textAgent.Handle(new Dictionary<string, object>
                {
                    ["command"] = "generateText",
                    ["length"] = _settings.TextLength
                });
            };

            btnVocabulary.Click += (s, e) =>
            {
                var vocabForm = new VocabularyForm(_vocabAgent);
                vocabForm.ShowDialog();
            };

            btnSettings.Click += (s, e) =>
            {
                var settingsForm = new SettingsForm(_settings);
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    _aiService.SetConfig(_settings.ApiKey, _settings.AiModel);
                }
            };

            _textAgent.OnTextGenerated += (s, text) =>
            {
                txtContent.Text = text;
            };

            // 添加文本选择事件
            txtContent.MouseUp += async (s, e) =>
            {
                if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Shift)
                {
                    string selectedText = txtContent.SelectedText;
                    if (!string.IsNullOrEmpty(selectedText))
                    {
                        string translation = await _aiService.Translate(selectedText);
                        MessageBox.Show(translation, "翻译", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    string selectedText = txtContent.SelectedText;
                    if (!string.IsNullOrEmpty(selectedText))
                    {
                        await _vocabAgent.Handle(new Dictionary<string, object>
                        {
                            ["command"] = "vocabulary",
                            ["action"] = "add",
                            ["word"] = selectedText,
                            ["translation"] = await _aiService.Translate(selectedText)
                        });
                        MessageBox.Show("已添加到生词本", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AppData.SaveSettings(_settings);
            AppData.SaveVocabulary(_vocabAgent.GetVocabulary().ToDictionary(k => k.Key, v => v.Value));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
} 