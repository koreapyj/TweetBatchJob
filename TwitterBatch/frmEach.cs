using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace TwitterBatch
{
    public partial class frmEach : Form
    {
        public TwitterOAuth TwitterConn;
        private string responseText;
        private dynamic responseObject;
        private Stack<string> displayStack = new Stack<string>();
        public frmEach()
        {
            InitializeComponent();
        }

        private void frmEach_Shown(object sender, EventArgs e)
        {
        }

        private void exec(string action)
        {
            displayStack = new Stack<string>();
            var worker = new BackgroundWorker();
            worker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                responseText = null;
                responseObject = null;

                try
                {
                    responseText = TwitterConn.Get(action);
                }
                catch (Exception ex)
                {
                    if(MessageBox.Show("동작을 실행하던 중 오류가 발생했습니다." + Environment.NewLine + Environment.NewLine + ex.Message, "헉", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        worker.RunWorkerCompleted += (object e_sender, RunWorkerCompletedEventArgs e_e) =>
                        {
                            exec(action);
                        };
                        return;
                    }
                    return;
                }
                switch(responseText.Substring(0, 1))
                {
                    case "[":
                        responseObject = JArray.Parse(responseText);
                        break;
                    default:
                        responseObject = JObject.Parse(responseText);
                        break;
                }
                worker.RunWorkerCompleted += (object e_sender, RunWorkerCompletedEventArgs e_e) =>
                {
                    displayDynamicObject();
                };
            };
            worker.RunWorkerAsync();
        }

        private void displayDynamicObject()
        {
            lvResult.Items.Clear();
            lvResult.Columns.Clear();
            var tmpObject = responseObject;
            if (displayStack.Count > 0)
            {
                foreach (string index in displayStack.Reverse())
                {
                    tmpObject = tmpObject[index];
                }
            }

            if (tmpObject.GetType().Name == "JArray")
            {

                lvResult.Columns.Add(" ");
                foreach (dynamic eachRow in tmpObject)
                {
                    string before = null;
                    foreach (dynamic each in eachRow)
                    {
                        if(!lvResult.Columns.ContainsKey(each.Name))
                        {
                            ColumnHeader n = new ColumnHeader();
                            n.Name = each.Name;
                            n.Text = each.Name;
                            int key;
                            if ((key = lvResult.Columns.IndexOfKey(before)) > -1)
                                lvResult.Columns.Insert(key+1, n);
                            else
                                lvResult.Columns.Add(n);
                        }
                        before = each.Name;
                    }
                }

                int idx = 0;
                foreach (dynamic eachRow in tmpObject)
                {
                    displayDynamicSingle(eachRow, ++idx);
                }
            }
            else// if(tmpObject.GetType().Name == "JObject")
            {
                lvResult.Columns.Add(" ");
                string before = null;
                foreach (dynamic each in tmpObject)
                {
                    if (!lvResult.Columns.ContainsKey(each.Name))
                    {
                        ColumnHeader n = new ColumnHeader();
                        n.Name = each.Name;
                        n.Text = each.Name;
                        int key;
                        if ((key = lvResult.Columns.IndexOfKey(before)) > -1)
                            lvResult.Columns.Insert(key + 1, n);
                        else
                            lvResult.Columns.Add(n);
                    }
                    before = each.Name;
                }

                displayDynamicSingle(tmpObject);
            }
        }

        private void displayDynamicSingle(dynamic target, int idx = 1)
        {
            var row = new ListViewItem();
            row.Text = idx.ToString();

            foreach (ColumnHeader each in lvResult.Columns)
            {
                if (each.Index == 0)
                    continue;
                ListViewItem.ListViewSubItem n = new ListViewItem.ListViewSubItem();
                n.Name = each.Name;
                if (target[each.Name] == null)
                {
                    n.Text = "";
                }
                else
                {
                    n.Text = target[each.Name].ToString();
                }
                row.SubItems.Add(n);
            }
            lvResult.Items.Add(row);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 실행RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exec(toolStripComboBox1.Text);
        }

        private void lvResult_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var key = lvResult.Columns[e.Column].Text;
            displayStack.Push(key);
            displayDynamicObject();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (displayStack.Count < 1)
                return;
            displayStack.Pop();
            displayDynamicObject();
        }
    }
}
