using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Controls.WindowsForms;
using System.Diagnostics;
using System.ComponentModel;
using TweetSharp;
using System.Compat.Web;

namespace TwitterBatch
{
    public partial class frmWizard : Form
    {
        private frmEach newForm;
        public frmWizard(frmEach childForm)
        {
            InitializeComponent();
            newForm = childForm;
            wPageLoginSuccess.Commit += (object sender, AeroWizard.WizardPageConfirmEventArgs e) =>
            {
                newForm.Show();
            };
            wizardControl1.SelectedPageChanged += (object sender, EventArgs e) =>
            {
                if (wizardControl1.SelectedPage == wPageLoginPrepare)
                {
                    doLogin();
                }
                else if(wizardControl1.SelectedPage == wPageLoginDo)
                {
                    wBrowserLogin.Navigate(newForm.TwitterConn.GetAuthorizeUrl());
                }
            };
        }

        private void commandLink1_Click(object sender, EventArgs e)
        {
            wizardControl1.NextPage(wPageApikeyAsk);
        }

        private void commandLink2_Click(object sender, EventArgs e)
        {
            wizardControl1.NextPage(wPageApiKeyInput);
        }

        private void commandLink3_Click(object sender, EventArgs e)
        {
            Process.Start("https://apps.twitter.com/");
            wizardControl1.NextPage(wPageApiKeyInput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tBoxConsumerKey.Text = this.tBoxConsumerSecret.Text = "";
            wizardControl1.NextPage(wPageLoginPrepare);
        }

        public void doLogin()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                if (this.tBoxConsumerKey.Text != "" && this.tBoxConsumerSecret.Text != "")
                {
                    newForm.TwitterConn = new TwitterOAuth(this.tBoxConsumerKey.Text, this.tBoxConsumerSecret.Text);
                }
                else
                {
                    newForm.TwitterConn = new TwitterOAuth("yZC4N1tgnLpZZ9EJeK5aFjXxW", "dkRxcHjqerkSgSs7VUVnaKAkwybWxhjNpcy6KlIcMltI3u6Q7F");
                }
                newForm.TwitterConn.AcquireRequestToken();
            };
            worker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                wizardControl1.NextPage(wPageLoginDo);
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
                var info = HttpUtility.ParseQueryString(newForm.TwitterConn.AcquireAccessToken(pin));
                worker.RunWorkerCompleted += (object ee_sender, RunWorkerCompletedEventArgs ee_e) =>
                {
                    wizardControl1.NextPage(wPageLoginSuccess);
                    newForm.Text = "@" + info["screen_name"];
                };
            };
            worker.RunWorkerAsync();
        }
    }
}
