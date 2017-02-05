namespace TwitterBatch
{
    partial class frmWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.wPageInitial = new AeroWizard.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink();
            this.commandLink1 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink();
            this.wPageApikeyAsk = new AeroWizard.WizardPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.commandLink2 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink();
            this.commandLink3 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink();
            this.wPageApiKeyInput = new AeroWizard.WizardPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxConsumerKey = new System.Windows.Forms.TextBox();
            this.tBoxConsumerSecret = new System.Windows.Forms.TextBox();
            this.wPageLoginPrepare = new AeroWizard.WizardPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.wPageLoginDo = new AeroWizard.WizardPage();
            this.wBrowserLogin = new System.Windows.Forms.WebBrowser();
            this.wPageLoginSuccess = new AeroWizard.WizardPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wPageInitial.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.wPageApikeyAsk.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.wPageApiKeyInput.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.wPageLoginPrepare.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.wPageLoginDo.SuspendLayout();
            this.wPageLoginSuccess.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.CancelButtonText = "취소";
            this.wizardControl1.ClassicStyle = AeroWizard.WizardClassicStyle.Automatic;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.FinishButtonText = "완료";
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextButtonText = "다음";
            this.wizardControl1.Pages.Add(this.wPageInitial);
            this.wizardControl1.Pages.Add(this.wPageApikeyAsk);
            this.wizardControl1.Pages.Add(this.wPageApiKeyInput);
            this.wizardControl1.Pages.Add(this.wPageLoginPrepare);
            this.wizardControl1.Pages.Add(this.wPageLoginDo);
            this.wizardControl1.Pages.Add(this.wPageLoginSuccess);
            this.wizardControl1.Size = new System.Drawing.Size(670, 383);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "새 연결 마법사";
            this.wizardControl1.TitleIcon = global::TwitterBatch.Properties.Resources.main;
            // 
            // wPageInitial
            // 
            this.wPageInitial.Controls.Add(this.tableLayoutPanel1);
            this.wPageInitial.Name = "wPageInitial";
            this.wPageInitial.ShowNext = false;
            this.wPageInitial.Size = new System.Drawing.Size(623, 229);
            this.wPageInitial.TabIndex = 0;
            this.wPageInitial.Text = "Twitter에 어떻게 연결합니까?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.39326F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60674F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.commandLink1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(525, 223);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.NoteText = "기본 설정으로 연결합니다.";
            this.button1.Size = new System.Drawing.Size(519, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "기본 설정을 사용하여 연결(&D)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commandLink1
            // 
            this.commandLink1.AutoSize = true;
            this.commandLink1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink1.Location = new System.Drawing.Point(3, 70);
            this.commandLink1.Name = "commandLink1";
            this.commandLink1.NoteText = "수동으로 API 설정을 변경합니다.";
            this.commandLink1.Size = new System.Drawing.Size(519, 57);
            this.commandLink1.TabIndex = 8;
            this.commandLink1.Text = "연결 설정 변경(&M)";
            this.commandLink1.UseVisualStyleBackColor = true;
            this.commandLink1.Click += new System.EventHandler(this.commandLink1_Click);
            // 
            // wPageApikeyAsk
            // 
            this.wPageApikeyAsk.Controls.Add(this.tableLayoutPanel2);
            this.wPageApikeyAsk.Name = "wPageApikeyAsk";
            this.wPageApikeyAsk.ShowNext = false;
            this.wPageApikeyAsk.Size = new System.Drawing.Size(623, 229);
            this.wPageApikeyAsk.TabIndex = 1;
            this.wPageApikeyAsk.Text = "Twitter API 키를 가지고 있습니까?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.39326F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60674F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 229);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.commandLink2);
            this.flowLayoutPanel2.Controls.Add(this.commandLink3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(525, 223);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // commandLink2
            // 
            this.commandLink2.AutoSize = true;
            this.commandLink2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink2.Location = new System.Drawing.Point(3, 3);
            this.commandLink2.Name = "commandLink2";
            this.commandLink2.NoteText = "";
            this.commandLink2.Size = new System.Drawing.Size(519, 45);
            this.commandLink2.TabIndex = 6;
            this.commandLink2.Text = "예, 가지고 있습니다";
            this.commandLink2.UseVisualStyleBackColor = true;
            this.commandLink2.Click += new System.EventHandler(this.commandLink2_Click);
            // 
            // commandLink3
            // 
            this.commandLink3.AutoSize = true;
            this.commandLink3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLink3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commandLink3.Location = new System.Drawing.Point(3, 54);
            this.commandLink3.Name = "commandLink3";
            this.commandLink3.NoteText = "Twitter API 페이지로 이동합니다.";
            this.commandLink3.Size = new System.Drawing.Size(519, 57);
            this.commandLink3.TabIndex = 8;
            this.commandLink3.Text = "아니오, 가지고 있지 않습니다";
            this.commandLink3.UseVisualStyleBackColor = true;
            this.commandLink3.Click += new System.EventHandler(this.commandLink3_Click);
            // 
            // wPageApiKeyInput
            // 
            this.wPageApiKeyInput.Controls.Add(this.flowLayoutPanel3);
            this.wPageApiKeyInput.Name = "wPageApiKeyInput";
            this.wPageApiKeyInput.NextPage = this.wPageLoginPrepare;
            this.wPageApiKeyInput.Size = new System.Drawing.Size(623, 229);
            this.wPageApiKeyInput.TabIndex = 2;
            this.wPageApiKeyInput.Text = "Twitter API Key를 입력하십시오.";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(623, 229);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key는 Twitter가 제공합니다.";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tBoxConsumerKey, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tBoxConsumerSecret, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 67);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consumer &Key:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Consumer &Secret:";
            // 
            // tBoxConsumerKey
            // 
            this.tBoxConsumerKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxConsumerKey.Location = new System.Drawing.Point(119, 5);
            this.tBoxConsumerKey.Name = "tBoxConsumerKey";
            this.tBoxConsumerKey.Size = new System.Drawing.Size(342, 23);
            this.tBoxConsumerKey.TabIndex = 2;
            // 
            // tBoxConsumerSecret
            // 
            this.tBoxConsumerSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxConsumerSecret.Location = new System.Drawing.Point(119, 38);
            this.tBoxConsumerSecret.Name = "tBoxConsumerSecret";
            this.tBoxConsumerSecret.Size = new System.Drawing.Size(342, 23);
            this.tBoxConsumerSecret.TabIndex = 3;
            this.tBoxConsumerSecret.UseSystemPasswordChar = true;
            // 
            // wPageLoginPrepare
            // 
            this.wPageLoginPrepare.Controls.Add(this.tableLayoutPanel4);
            this.wPageLoginPrepare.Name = "wPageLoginPrepare";
            this.wPageLoginPrepare.ShowNext = false;
            this.wPageLoginPrepare.Size = new System.Drawing.Size(623, 229);
            this.wPageLoginPrepare.TabIndex = 3;
            this.wPageLoginPrepare.Text = "Twitter에 로그인";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(623, 229);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // wPageLoginDo
            // 
            this.wPageLoginDo.Controls.Add(this.wBrowserLogin);
            this.wPageLoginDo.Name = "wPageLoginDo";
            this.wPageLoginDo.ShowNext = false;
            this.wPageLoginDo.Size = new System.Drawing.Size(623, 229);
            this.wPageLoginDo.TabIndex = 4;
            this.wPageLoginDo.Text = "Twitter에 로그인";
            // 
            // wBrowserLogin
            // 
            this.wBrowserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBrowserLogin.Location = new System.Drawing.Point(0, 0);
            this.wBrowserLogin.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBrowserLogin.Name = "wBrowserLogin";
            this.wBrowserLogin.Size = new System.Drawing.Size(623, 229);
            this.wBrowserLogin.TabIndex = 0;
            this.wBrowserLogin.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wBrowserLogin_DocumentCompleted);
            // 
            // wPageLoginSuccess
            // 
            this.wPageLoginSuccess.AllowBack = false;
            this.wPageLoginSuccess.AllowCancel = false;
            this.wPageLoginSuccess.Controls.Add(this.tableLayoutPanel5);
            this.wPageLoginSuccess.IsFinishPage = true;
            this.wPageLoginSuccess.Name = "wPageLoginSuccess";
            this.wPageLoginSuccess.ShowCancel = false;
            this.wPageLoginSuccess.Size = new System.Drawing.Size(623, 229);
            this.wPageLoginSuccess.TabIndex = 5;
            this.wPageLoginSuccess.Text = "로그인 완료";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(623, 229);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::TwitterBatch.Properties.Resources.success_icon_23194;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(617, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "로그인 완료";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "이제 기능을 사용할 수 있습니다.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 383);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWizard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wPageInitial.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.wPageApikeyAsk.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.wPageApiKeyInput.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.wPageLoginPrepare.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.wPageLoginDo.ResumeLayout(false);
            this.wPageLoginSuccess.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage wPageInitial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink button1;
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink commandLink1;
        private AeroWizard.WizardPage wPageApikeyAsk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink commandLink2;
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.CommandLink commandLink3;
        private AeroWizard.WizardPage wPageApiKeyInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxConsumerKey;
        private System.Windows.Forms.TextBox tBoxConsumerSecret;
        private AeroWizard.WizardPage wPageLoginPrepare;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private AeroWizard.WizardPage wPageLoginDo;
        private System.Windows.Forms.WebBrowser wBrowserLogin;
        private AeroWizard.WizardPage wPageLoginSuccess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}