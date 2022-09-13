using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void BrowserUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
            {
                TabPage newTab = new TabPage("New Tab");
                TabUserControl newTabUserControl = new TabUserControl();
                newTabUserControl.Dock = DockStyle.Fill;
                newTab.Controls.Add(newTabUserControl);
                this.tabControl1.TabPages.Add(newTab);
            }
        }
    }
}
