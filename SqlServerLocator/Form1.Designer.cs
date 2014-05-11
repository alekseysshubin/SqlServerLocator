namespace SqlServerLocator
{
    partial class Form1
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
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServersListBox
            // 
            this.ServersListBox.FormattingEnabled = true;
            this.ServersListBox.Location = new System.Drawing.Point(12, 7);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.Size = new System.Drawing.Size(260, 199);
            this.ServersListBox.TabIndex = 0;
            this.ServersListBox.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(197, 226);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(116, 226);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ServersListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ServersListBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button TestButton;
    }
}

