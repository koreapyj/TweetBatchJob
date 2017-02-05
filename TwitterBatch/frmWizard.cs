using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Compat.Web;

namespace TwitterBatch
{
    public partial class frmWizard : Form
    {
        public frmWizard()
        {
            InitializeComponent();
            wizardControl.SelectedPageChanged += (object sender, EventArgs e) =>
            {
                if (wizardControl.SelectedPage == wPageLoginPrepare)
                {
                    doLogin();
                }
                else if(wizardControl.SelectedPage == wPageLoginDo)
                {
                    wBrowserLogin.Navigate(frmMain.TwitterConn.GetAuthorizeUrl());
                }
            };
        }

        private void commandLink1_Click(object sender, EventArgs e)
        {
            wizardControl.NextPage(wPageApikeyAsk);
        }

        private void commandLink2_Click(object sender, EventArgs e)
        {
            wizardControl.NextPage(wPageApiKeyInput);
        }

        private void commandLink3_Click(object sender, EventArgs e)
        {
            Process.Start("https://apps.twitter.com/");
            wizardControl.NextPage(wPageApiKeyInput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tBoxConsumerKey.Text = this.tBoxConsumerSecret.Text = "";
            wizardControl.NextPage(wPageLoginPrepare);
        }

        public void doLogin()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                if (this.tBoxConsumerKey.Text != "" && this.tBoxConsumerSecret.Text != "")
                {
                    frmMain.TwitterConn = new TwitterOAuth(this.tBoxConsumerKey.Text, this.tBoxConsumerSecret.Text);
                }
                else
                {
                    frmMain.TwitterConn = new TwitterOAuth("yZC4N1tgnLpZZ9EJeK5aFjXxW", "dkRxcHjqerkSgSs7VUVnaKAkwybWxhjNpcy6KlIcMltI3u6Q7F");
                }
                frmMain.TwitterConn.AcquireRequestToken();
            };
            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                wizardControl.NextPage(wPageLoginDo);
            };
            worker.RunWorkerAsync();
        }

        private void wBrowserLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            var codes = wBrowserLogin.Document.GetElementsByTagName("code");
            worker.DoWork += (object e_sender, DoWorkEventArgs e_e) =>
            {
                string pin = null;
                foreach (HtmlElement code in codes)
                {
                    pin = code.InnerText;
                    break;
                }
                if (pin == null)
                    return;
                frmMain.TwitterConn.AcquireAccessToken(pin);
                worker.RunWorkerCompleted += (object ee_sender, RunWorkerCompletedEventArgs ee_e) =>
                {
                    wizardControl.NextPage(wPageLoginSuccess);
                };
            };
            worker.RunWorkerAsync();
        }
    }
}
