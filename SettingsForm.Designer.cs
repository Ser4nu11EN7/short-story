namespace EnglishLearning
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneration;
        private System.Windows.Forms.TabPage tabAppearance;
        private System.Windows.Forms.TabPage tabApi;
        private System.Windows.Forms.NumericUpDown numTextLength;
        private System.Windows.Forms.CheckBox chkIncludeVocab;
        private System.Windows.Forms.TextBox txtBackgroundImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            
            // 初始化控件
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabGeneration = new System.Windows.Forms.TabPage();
            this.tabAppearance = new System.Windows.Forms.TabPage();
            this.tabApi = new System.Windows.Forms.TabPage();
            this.numTextLength = new System.Windows.Forms.NumericUpDown();
            this.chkIncludeVocab = new System.Windows.Forms.CheckBox();
            this.txtBackgroundImage = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // 设置窗体属性
            this.Text = "设置";
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // 设置标签页
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSettings.Height = 300;
            
            // 生成设置标签页
            this.tabGeneration.Text = "生成设置";
            this.tabGeneration.Padding = new System.Windows.Forms.Padding(10);
            
            var lblLength = new Label { Text = "生成文本长度：", Location = new Point(10, 20) };
            this.numTextLength.Location = new Point(120, 18);
            this.numTextLength.Minimum = 50;
            this.numTextLength.Maximum = 1000;
            
            this.chkIncludeVocab.Text = "包含生词本中的单词";
            this.chkIncludeVocab.Location = new Point(10, 50);
            
            this.tabGeneration.Controls.AddRange(new Control[] {
                lblLength, this.numTextLength, this.chkIncludeVocab
            });

            // 外观设置标签页
            this.tabAppearance.Text = "外观设置";
            this.tabAppearance.Padding = new System.Windows.Forms.Padding(10);
            
            var lblBackground = new Label { Text = "背景图片：", Location = new Point(10, 20) };
            this.txtBackgroundImage.Location = new Point(120, 18);
            this.txtBackgroundImage.Width = 200;
            this.btnSelectImage.Text = "浏览...";
            this.btnSelectImage.Location = new Point(330, 17);
            
            this.tabAppearance.Controls.AddRange(new Control[] {
                lblBackground, this.txtBackgroundImage, this.btnSelectImage
            });

            // API设置标签页
            this.tabApi.Text = "API设置";
            this.tabApi.Padding = new System.Windows.Forms.Padding(10);
            
            var lblModel = new Label { Text = "AI模型：", Location = new Point(10, 20) };
            this.cboModel.Location = new Point(120, 18);
            this.cboModel.Width = 200;
            this.cboModel.Items.AddRange(new string[] { "chatgpt", "gemini", "claude", "deepseek" });
            
            var lblApiKey = new Label { Text = "API密钥：", Location = new Point(10, 50) };
            this.txtApiKey.Location = new Point(120, 48);
            this.txtApiKey.Width = 300;
            
            this.tabApi.Controls.AddRange(new Control[] {
                lblModel, this.cboModel, lblApiKey, this.txtApiKey
            });

            // 添加标签页
            this.tabSettings.TabPages.AddRange(new TabPage[] {
                this.tabGeneration,
                this.tabAppearance,
                this.tabApi
            });

            // 按钮
            this.btnSave.Text = "保存";
            this.btnSave.DialogResult = DialogResult.OK;
            this.btnSave.Location = new Point(320, 320);
            
            this.btnCancel.Text = "取消";
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Location = new Point(400, 320);

            // 添加控件
            this.Controls.AddRange(new Control[] {
                this.tabSettings,
                this.btnSave,
                this.btnCancel
            });
        }
    }
} 