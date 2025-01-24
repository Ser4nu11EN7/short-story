using EnglishLearning.Agents;

namespace EnglishLearning
{
    public partial class VocabularyForm : Form
    {
        private readonly VocabularyAgent _vocabularyAgent;

        public VocabularyForm(VocabularyAgent vocabularyAgent)
        {
            InitializeComponent();
            _vocabularyAgent = vocabularyAgent;
            LoadVocabulary();
            BindEvents();
        }

        private void LoadVocabulary()
        {
            listVocabulary.Items.Clear();
            var vocabulary = _vocabularyAgent.GetVocabulary();
            
            foreach (var word in vocabulary)
            {
                var item = new ListViewItem(word.Value.Word);
                item.SubItems.Add(word.Value.Translation);
                item.SubItems.Add(word.Value.IsMastered ? "已掌握" : "学习中");
                if (word.Value.IsMastered)
                {
                    item.Font = new Font(item.Font, FontStyle.Strikeout);
                }
                listVocabulary.Items.Add(item);
            }
        }

        private void BindEvents()
        {
            listVocabulary.MouseClick += async (s, e) =>
            {
                var item = listVocabulary.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        // 显示翻译
                        MessageBox.Show(item.SubItems[1].Text, "翻译", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };

            _vocabularyAgent.OnVocabularyChanged += (s, e) =>
            {
                LoadVocabulary();
            };
        }
    }
} 