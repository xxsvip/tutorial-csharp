namespace WindowsFormsApp
{
    partial class Dashboard
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
            this.PeopleFoundList = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundList
            // 
            this.PeopleFoundList.FormattingEnabled = true;
            this.PeopleFoundList.ItemHeight = 57;
            this.PeopleFoundList.Location = new System.Drawing.Point(143, 598);
            this.PeopleFoundList.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PeopleFoundList.Name = "PeopleFoundList";
            this.PeopleFoundList.Size = new System.Drawing.Size(866, 745);
            this.PeopleFoundList.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(559, 278);
            this.LastNameText.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(450, 64);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(230, 278);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(316, 83);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "姓名";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(390, 428);
            this.searchButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(342, 104);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(2150, 1374);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleFoundList);
            this.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MES操作系统";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;

        private System.Windows.Forms.ListBox PeopleFoundList;

        #endregion
    }
}