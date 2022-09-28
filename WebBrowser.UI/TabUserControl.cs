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
    public partial class TabUserControl : UserControl
    {
        public TabUserControl()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressBarTextBox.Text);
        }

        private void addressBarTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goButton_Click(sender, e);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void bookmarksButton_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem();
            item.Title = webBrowser1.DocumentTitle;
            item.URL = webBrowser1.Url.ToString();
            var currentBookmarks = BookmarkManager.GetItems();
            bool bookmarkCreated = false;
            foreach (var bookmark in currentBookmarks)
            {
                if (bookmark.Title == item.Title && bookmark.URL == item.URL)
                {
                    bookmarkCreated = true;
                }
            }
            if (bookmarkCreated == false)
            {
                BookmarkManager.AddItem(item);
            }
            else
            {
                MessageBox.Show("Bookmark already exists!");
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var item = new HistoryItem();
            item.Title = webBrowser1.DocumentTitle;
            item.URL = webBrowser1.Url.ToString();
            item.Date = DateTime.Now;
            HistoryManager.AddItem(item);
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = (int)e.CurrentProgress;
        }
    }
}
