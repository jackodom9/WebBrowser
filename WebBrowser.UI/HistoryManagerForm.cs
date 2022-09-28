﻿using System;
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
            
            foreach(var item in items)
            {
                var date = item.Date.ToString();
                var title = item.Title;
                var URL = item.URL;
                if (date.Contains(textBoxHistorySearch.Text) || title.Contains(textBoxHistorySearch.Text) || date.Contains(textBoxHistorySearch.Text))
                {
                    listBoxHistoryManager.Items.Add(string.Format("[{0}] {1} ({2})", date, title, URL));
                }
            }
        }
    }
}
