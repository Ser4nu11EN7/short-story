namespace EnglishLearning
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGenerateText;
        private System.Windows.Forms.Button btnVocabulary;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel contentPanel;

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
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.btnGenerateText = new System.Windows.Forms.Button();
            this.btnVocabulary = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();

            // 设置窗体属性
            this.Text = "英语学习助手";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // 工具栏面板
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.Height = 50;
            this.toolbarPanel.BackColor = System.Drawing.Color.White;
            this.toolbarPanel.Padding = new System.Windows.Forms.Padding(10);

            // 内容面板
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Padding = new System.Windows.Forms.Padding(10);

            // 生成短文按钮
            this.btnGenerateText.Text = "生成短文";
            this.btnGenerateText.Size = new System.Drawing.Size(100, 30);
            this.btnGenerateText.Location = new System.Drawing.Point(10, 10);
            this.btnGenerateText.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnGenerateText.ForeColor = System.Drawing.Color.White;
            this.btnGenerateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 生词本按钮
            this.btnVocabulary.Text = "生词本";
            this.btnVocabulary.Size = new System.Drawing.Size(100, 30);
            this.btnVocabulary.Location = new System.Drawing.Point(120, 10);
            this.btnVocabulary.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnVocabulary.ForeColor = System.Drawing.Color.White;
            this.btnVocabulary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 设置按钮
            this.btnSettings.Text = "设置";
            this.btnSettings.Size = new System.Drawing.Size(100, 30);
            this.btnSettings.Location = new System.Drawing.Point(230, 10);
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 文本内容框
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtContent.BackColor = System.Drawing.Color.White;

            // 添加控件到面板
            this.toolbarPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnGenerateText,
                this.btnVocabulary,
                this.btnSettings
            });

            this.contentPanel.Controls.Add(this.txtContent);

            // 添加面板到窗体
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.toolbarPanel,
                this.contentPanel
            });
        }
    }
} 