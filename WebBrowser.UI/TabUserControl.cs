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
            BookmarkManager.AddItem(item);
        }
    }
}
