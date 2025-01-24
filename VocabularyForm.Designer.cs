namespace EnglishLearning
{
    partial class VocabularyForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listVocabulary;
        private System.Windows.Forms.ColumnHeader columnWord;
        private System.Windows.Forms.ColumnHeader columnTranslation;
        private System.Windows.Forms.ColumnHeader columnStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listVocabulary = new System.Windows.Forms.ListView();
            this.columnWord = new System.Windows.Forms.ColumnHeader();
            this.columnTranslation = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();

            // 设置窗体属性
            this.Text = "生词本";
            this.Size = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // 设置列表视图
            this.listVocabulary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVocabulary.View = System.Windows.Forms.View.Details;
            this.listVocabulary.FullRowSelect = true;
            this.listVocabulary.GridLines = true;

            // 设置列
            this.columnWord.Text = "单词";
            this.columnWord.Width = 200;
            this.columnTranslation.Text = "翻译";
            this.columnTranslation.Width = 300;
            this.columnStatus.Text = "状态";
            this.columnStatus.Width = 80;

            this.listVocabulary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.columnWord,
                this.columnTranslation,
                this.columnStatus
            });

            this.Controls.Add(this.listVocabulary);
        }
    }
} 