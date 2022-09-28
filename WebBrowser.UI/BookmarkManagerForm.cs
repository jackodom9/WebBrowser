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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            listBoxBookmarkManager.Items.Clear();

            foreach (var item in items)
            {
                listBoxBookmarkManager.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));

            }
        }

        private void listBoxBookmarkManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBookmarkSearch_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            listBoxBookmarkManager.Items.Clear();
            var searchItem = textBoxBookMarkManagerSearch.Text.ToLower();
            foreach (var item in items)
            {
                string title = item.Title.ToLower();
                string URL = item.URL.ToLower();
                if (title.Contains(searchItem) || URL.Contains(searchItem))
                {
                    listBoxBookmarkManager.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void btnBookmarkDelete_Click(object sender, EventArgs e)
        {
            string itemStr = (string)listBoxBookmarkManager.SelectedItem;
            int index = listBoxBookmarkManager.SelectedIndex;
            string URL = getSubStringFromString("(", ")", itemStr);
            string title = itemStr.Split('(')[0];
            BookmarkManager.DeleteItem(index, title, URL);
            listBoxBookmarkManager.Items.RemoveAt(listBoxBookmarkManager.SelectedIndex);
        }

        private string getSubStringFromString(string begin, string end, string result)
        {
            return result.Substring((result.IndexOf(begin) + begin.Length), (result.IndexOf(end) - result.IndexOf(begin) - begin.Length));
        }
    }
}
