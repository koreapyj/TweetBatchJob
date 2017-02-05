using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterBatch
{
    public partial class frmMain : Form
    {
        public static TwitterOAuth TwitterConn;
        private int ChildId = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var mdiclient = this.Controls.OfType<MdiClient>().Single();
            this.SuspendLayout();
            mdiclient.SuspendLayout();
            var hdiff = mdiclient.Size.Width - mdiclient.ClientSize.Width;
            var vdiff = mdiclient.Size.Height - mdiclient.ClientSize.Height;
            var size = new Size(mdiclient.Width + hdiff, mdiclient.Height + vdiff);
            var location = new Point(mdiclient.Left - (hdiff / 2), mdiclient.Top - (vdiff / 2));
            mdiclient.Dock = DockStyle.None;
            mdiclient.Size = size;
            mdiclient.Location = location;
            mdiclient.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            mdiclient.ResumeLayout(true);
            this.ResumeLayout(true);
            base.OnLoad(e);
        }

        private void twitterBatch정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmAbout();
            a.ShowDialog();
        }

        private void 연결NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWizard a = new frmWizard();
            a.wPageLoginSuccess.Commit += (object e_sender, AeroWizard.WizardPageConfirmEventArgs e_e) =>
            {
                this.연결NToolStripMenuItem.Enabled = false;
                this.닫기CToolStripMenuItem.Enabled = true;
                this.새창NToolStripMenuItem.Enabled = true;
            };
            a.ShowDialog();
        }

        private void twitterAPI도움말PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://dev.twitter.com/rest/reference");
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새창NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmEach();
            newForm.MdiParent = this;
            newForm.Text = "창 " + (ChildId++);
            newForm.Show();
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TwitterConn = null;
            this.연결NToolStripMenuItem.Enabled = true;
            this.닫기CToolStripMenuItem.Enabled = false;
            this.새창NToolStripMenuItem.Enabled = false;
        }
    }
}
