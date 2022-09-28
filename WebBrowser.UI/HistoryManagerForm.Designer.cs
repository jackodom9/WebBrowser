namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.listBoxHistoryManager = new System.Windows.Forms.ListBox();
            this.textBoxHistorySearch = new System.Windows.Forms.TextBox();
            this.btnHistorySearch = new System.Windows.Forms.Button();
            this.btnHistoryManagerDelete = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHistoryManager
            // 
            this.listBoxHistoryManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxHistoryManager.FormattingEnabled = true;
            this.listBoxHistoryManager.Location = new System.Drawing.Point(0, 37);
            this.listBoxHistoryManager.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxHistoryManager.Name = "listBoxHistoryManager";
            this.listBoxHistoryManager.Size = new System.Drawing.Size(600, 329);
            this.listBoxHistoryManager.TabIndex = 0;
            // 
            // textBoxHistorySearch
            // 
            this.textBoxHistorySearch.Location = new System.Drawing.Point(0, 12);
            this.textBoxHistorySearch.Name = "textBoxHistorySearch";
            this.textBoxHistorySearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxHistorySearch.TabIndex = 1;
            // 
            // btnHistorySearch
            // 
            this.btnHistorySearch.Location = new System.Drawing.Point(119, 8);
            this.btnHistorySearch.Name = "btnHistorySearch";
            this.btnHistorySearch.Size = new System.Drawing.Size(75, 23);
            this.btnHistorySearch.TabIndex = 2;
            this.btnHistorySearch.Text = "Search";
            this.btnHistorySearch.UseVisualStyleBackColor = true;
            this.btnHistorySearch.Click += new System.EventHandler(this.btnHistorySearch_Click);
            // 
            // btnHistoryManagerDelete
            // 
            this.btnHistoryManagerDelete.Location = new System.Drawing.Point(218, 8);
            this.btnHistoryManagerDelete.Name = "btnHistoryManagerDelete";
            this.btnHistoryManagerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnHistoryManagerDelete.TabIndex = 3;
            this.btnHistoryManagerDelete.Text = "Delete";
            this.btnHistoryManagerDelete.UseVisualStyleBackColor = true;
            this.btnHistoryManagerDelete.Click += new System.EventHandler(this.btnHistoryManagerDelete_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(312, 8);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btnClearHistory.TabIndex = 4;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnHistoryManagerDelete);
            this.Controls.Add(this.btnHistorySearch);
            this.Controls.Add(this.textBoxHistorySearch);
            this.Controls.Add(this.listBoxHistoryManager);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistoryManager;
        private System.Windows.Forms.TextBox textBoxHistorySearch;
        private System.Windows.Forms.Button btnHistorySearch;
        private System.Windows.Forms.Button btnHistoryManagerDelete;
        private System.Windows.Forms.Button btnClearHistory;
    }
}