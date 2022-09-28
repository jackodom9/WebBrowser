namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBookmarkManager = new System.Windows.Forms.ListBox();
            this.textBoxBookMarkManagerSearch = new System.Windows.Forms.TextBox();
            this.btnBookmarkSearch = new System.Windows.Forms.Button();
            this.btnBookmarkDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBookmarkManager
            // 
            this.listBoxBookmarkManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxBookmarkManager.FormattingEnabled = true;
            this.listBoxBookmarkManager.Location = new System.Drawing.Point(0, 37);
            this.listBoxBookmarkManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxBookmarkManager.Name = "listBoxBookmarkManager";
            this.listBoxBookmarkManager.Size = new System.Drawing.Size(600, 329);
            this.listBoxBookmarkManager.TabIndex = 0;
            this.listBoxBookmarkManager.SelectedIndexChanged += new System.EventHandler(this.listBoxBookmarkManager_SelectedIndexChanged);
            // 
            // textBoxBookMarkManagerSearch
            // 
            this.textBoxBookMarkManagerSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxBookMarkManagerSearch.Name = "textBoxBookMarkManagerSearch";
            this.textBoxBookMarkManagerSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookMarkManagerSearch.TabIndex = 1;
            // 
            // btnBookmarkSearch
            // 
            this.btnBookmarkSearch.Location = new System.Drawing.Point(134, 12);
            this.btnBookmarkSearch.Name = "btnBookmarkSearch";
            this.btnBookmarkSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookmarkSearch.TabIndex = 2;
            this.btnBookmarkSearch.Text = "Search";
            this.btnBookmarkSearch.UseVisualStyleBackColor = true;
            this.btnBookmarkSearch.Click += new System.EventHandler(this.btnBookmarkSearch_Click);
            // 
            // btnBookmarkDelete
            // 
            this.btnBookmarkDelete.Location = new System.Drawing.Point(234, 12);
            this.btnBookmarkDelete.Name = "btnBookmarkDelete";
            this.btnBookmarkDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBookmarkDelete.TabIndex = 3;
            this.btnBookmarkDelete.Text = "Delete";
            this.btnBookmarkDelete.UseVisualStyleBackColor = true;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBookmarkDelete);
            this.Controls.Add(this.btnBookmarkSearch);
            this.Controls.Add(this.textBoxBookMarkManagerSearch);
            this.Controls.Add(this.listBoxBookmarkManager);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmarkManager;
        private System.Windows.Forms.TextBox textBoxBookMarkManagerSearch;
        private System.Windows.Forms.Button btnBookmarkSearch;
        private System.Windows.Forms.Button btnBookmarkDelete;
    }
}