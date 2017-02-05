namespace TwitterBatch
{
    partial class frmEach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEach));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.동작AToolStripMenuItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new TwitterBatch.ToolStripSpringComboBox();
            this.실행RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvResult = new System.Windows.Forms.ListView();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.동작AToolStripMenuItem,
            this.toolStripComboBox1,
            this.실행RToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 23);
            this.toolStripMenuItem1.Text = "뒤로(&B)";
            this.toolStripMenuItem1.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 23);
            this.toolStripMenuItem2.Text = "위로(&U)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 동작AToolStripMenuItem
            // 
            this.동작AToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.동작AToolStripMenuItem.Name = "동작AToolStripMenuItem";
            this.동작AToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.동작AToolStripMenuItem.Text = "동작:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(324, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // 실행RToolStripMenuItem
            // 
            this.실행RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("실행RToolStripMenuItem.Image")));
            this.실행RToolStripMenuItem.Name = "실행RToolStripMenuItem";
            this.실행RToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.실행RToolStripMenuItem.Text = "실행";
            this.실행RToolStripMenuItem.Click += new System.EventHandler(this.실행RToolStripMenuItem_Click);
            // 
            // lvResult
            // 
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.FullRowSelect = true;
            this.lvResult.Location = new System.Drawing.Point(0, 27);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(601, 381);
            this.lvResult.TabIndex = 1;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvResult_ColumnClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(28, 23);
            this.toolStripMenuItem3.Text = "새로고침(&R)";
            this.toolStripMenuItem3.Visible = false;
            // 
            // frmEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 408);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.menuStrip1);
            this.Icon = global::TwitterBatch.Properties.Resources.main;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEach";
            this.Text = "frmEach";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripSpringComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel 동작AToolStripMenuItem;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ToolStripMenuItem 실행RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}