namespace RocketLeagueRecentPlayed
{
    partial class Main
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
            this.OpenLogBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenLogBtn
            // 
            this.OpenLogBtn.AutoSize = true;
            this.OpenLogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenLogBtn.Location = new System.Drawing.Point(3, 3);
            this.OpenLogBtn.Name = "OpenLogBtn";
            this.OpenLogBtn.Size = new System.Drawing.Size(691, 52);
            this.OpenLogBtn.TabIndex = 1;
            this.OpenLogBtn.Text = "Open Log";
            this.OpenLogBtn.UseVisualStyleBackColor = true;
            this.OpenLogBtn.Click += new System.EventHandler(this.OpenLogBtn_Click);
            // 
            // LogListBox
            // 
            this.LogListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(3, 61);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(691, 255);
            this.LogListBox.TabIndex = 2;
            this.LogListBox.SelectedIndexChanged += new System.EventHandler(this.LogListBox_SelectedIndexChanged);
            // 
            // UserListBox
            // 
            this.UserListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(3, 322);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(691, 255);
            this.UserListBox.TabIndex = 3;
            this.UserListBox.DoubleClick += new System.EventHandler(this.UserListBox_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.OpenLogBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LogListBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 580);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "Rocket League Recent Players";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenLogBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

