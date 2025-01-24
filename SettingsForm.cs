using EnglishLearning.Models;

namespace EnglishLearning
{
    public partial class SettingsForm : Form
    {
        private readonly Settings _settings;

        public SettingsForm(Settings settings)
        {
            InitializeComponent();
            _settings = settings;
            LoadSettings();
            BindEvents();
        }

        private void LoadSettings()
        {
            numTextLength.Value = _settings.TextLength;
            chkIncludeVocab.Checked = _settings.IncludeVocabulary;
            txtBackgroundImage.Text = _settings.BackgroundImage;
            cboModel.SelectedItem = _settings.AiModel;
            txtApiKey.Text = _settings.ApiKey;
        }

        private void BindEvents()
        {
            btnSelectImage.Click += (s, e) =>
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        txtBackgroundImage.Text = dialog.FileName;
                    }
                }
            };

            btnSave.Click += (s, e) =>
            {
                SaveSettings();
            };
        }

        private void SaveSettings()
        {
            _settings.TextLength = (int)numTextLength.Value;
            _settings.IncludeVocabulary = chkIncludeVocab.Checked;
            _settings.BackgroundImage = txtBackgroundImage.Text;
            _settings.AiModel = cboModel.SelectedItem?.ToString() ?? "chatgpt";
            _settings.ApiKey = txtApiKey.Text;
        }
    }
} 