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

        // go button to navigate to url that was input
        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressBarTextBox.Text);
        }

        // on enter key allows for same functionality as go button
        private void addressBarTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goButton_Click(sender, e);
            }
        }

        // refreshes the currently displayed webpage
        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        // goes to the previous history item visited in web browser
        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        // goes to the next history item visited in web browser
        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        // bookmarks the currently selected page
        private void bookmarksButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.DocumentTitle != "")
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
        }

        // on navigation to a webpage, add said web page to history database
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var item = new HistoryItem();
            item.Title = webBrowser1.DocumentTitle;
            item.URL = webBrowser1.Url.ToString();
            item.Date = DateTime.Now;
            HistoryManager.AddItem(item);

        }

        // loading bar and status message to reflect the status of the web page
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = (int)e.CurrentProgress;
            if (e.CurrentProgress == e.MaximumProgress)
            {
                toolStripStatusLabel1.Text = "done";
            }
            else
            {
                toolStripStatusLabel1.Text = "loading";
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }

        // home button navigates to search browser
        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

    }
}
