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
    public partial class BrowserUI : Form
    {
        public BrowserUI()
        {
            InitializeComponent();
        }

        private void BrowserUI_Load(object sender, EventArgs e)
        {

        }

        // toolstrip menu item to exit application
        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // toolstrip menu item to display some basic information about app and creator
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This is a tool for users to browse different web pages. " +
                "Make sure to explore the menu options to familiarize yourself with the" +
                " controls. Created for CPSC 2710.\nCreated By: Jack Odom\nStudent ID: " +
                "903526855\nUsername: jeo0011";
            MessageBox.Show(message);
        }

        private void goButton_Click(object sender, EventArgs e)
        {

        }

        private void addressBarTextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        // allows for CTRL & T to open a new tab and CTRL & W to close the current tab
        private void BrowserUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
            {
                newTabToolStripMenuItem_Click(sender, e);
            }

            if (e.Control && (e.KeyCode == Keys.W))
            {
                closeCurrentTabToolStripMenuItem_Click(sender, e);
            }
        }

        // toolstrip menu item to create new tab
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("New Tab        ");
            TabUserControl newTabUserControl = new TabUserControl();
            newTabUserControl.Dock = DockStyle.Fill;
            newTab.Controls.Add(newTabUserControl);
            var lastIndex = this.tabControl1.TabCount - 1;
            this.tabControl1.TabPages.Insert(lastIndex, newTab);
        }

        // toolstrip menu item to close current tab
        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }

        private void tabUserControl1_Load(object sender, EventArgs e)
        {

        }

        // toolstrip menu item to open history manager
        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm historyManagerForm = new HistoryManagerForm();
            historyManagerForm.ShowDialog();
        }

        // toolstrip menu item to open boomark manager
        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm bookmarkManagerForm = new BookmarkManagerForm();
            bookmarkManagerForm.ShowDialog();
        }

        // when hovering over a link, display the link in the bottom right hand corner of string
        private void browserMouseMoved(object sender, HtmlElementEventArgs e)
        {
            string element = tabUserControl1.webBrowser1.Document.GetElementFromPoint(e.ClientMousePosition).GetAttribute("href");

            tabUserControl1.toolStripStatusLabel2.Text = "Link = " + element;
        }

        // accessory method for link display
        private void BrowserUI_MouseMove(object sender, MouseEventArgs e)
        {
            try 
            { 
                if (tabUserControl1.webBrowser1.ClientRectangle.Contains(Cursor.Position))
                {
                    tabUserControl1.webBrowser1.Document.MouseOver += new HtmlElementEventHandler(this.browserMouseMoved);
                }
            }
            catch
            {

            }
        }

        // toolstrip menu item to clear history
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearItems();
        }

        // makes last tab a button to open new tabs
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            if (this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                newTabToolStripMenuItem_Click(sender, e);
            }
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle rect = tabControl1.GetTabRect(i);

                Rectangle closeButton = new Rectangle(rect.Right - 15, rect.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    this.tabControl1.TabPages.RemoveAt(i);
                   
                }
            }
        }

        // draws "x" buttons on tabs for closing
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        // toolstrip menu item to save page as html
        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabUserControl1.webBrowser1.ShowSaveAsDialog();
        }


        // toolstrip menu item to print page
        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                tabUserControl1.webBrowser1.ShowPrintDialog();
        }

        private void tabPage1_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void tabPage1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void tabPage1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
