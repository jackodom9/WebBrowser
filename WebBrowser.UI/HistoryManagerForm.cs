using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBoxHistoryManager.Items.Clear();

            foreach(var item in items)
            {
                listBoxHistoryManager.Items.Add(string.Format("[{0}] {1} ({2})", item.Date.ToString(), item.Title, item.URL));

            }
        }

        private void btnHistorySearch_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBoxHistoryManager.Items.Clear();
            var searchItem = textBoxHistorySearch.Text.ToLower();
            foreach (var item in items)
            {
                string date = item.Date.ToString().ToLower();
                string title = item.Title.ToLower();
                string URL = item.URL.ToLower();
                if (date.Contains(searchItem) || title.Contains(searchItem) || date.Contains(searchItem))
                {
                    listBoxHistoryManager.Items.Add(string.Format("[{0}] {1} ({2})", item.Date.ToString(), item.Title, item.URL));
                }
            }
        }

        private void btnHistoryManagerDelete_Click(object sender, EventArgs e)
        {
            string itemStr = (string)listBoxHistoryManager.SelectedItem;
            int index = listBoxHistoryManager.SelectedIndex;
            listBoxHistoryManager.Items.RemoveAt(listBoxHistoryManager.SelectedIndex);
            string URL = getSubStringFromString("(", ")", itemStr);
            string title = getSubStringFromString("]", "(", itemStr);
            DateTime date = DateTime.Parse(getSubStringFromString("[", "]", itemStr));
            HistoryManager.DeleteItem(index, title, URL, date);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            listBoxHistoryManager.Items.Clear();
            HistoryManager.ClearItems();
        }

        private string getSubStringFromString(string begin, string end, string result)
        {
            return result.Substring((result.IndexOf(begin) + begin.Length), (result.IndexOf(end) - result.IndexOf(begin) - begin.Length));
        }
    }
}
