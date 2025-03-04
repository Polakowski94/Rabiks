namespace RemoteTimer.Forms
{
    partial class DatabaseConnectionForm
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
            this.SearchButton = new Button();
            this.PathTextBox = new TextBox();
            this.PathLabel = new Label();
            this.ConnectButton = new Button();
            SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.SearchButton.Location = new Point(216, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += this.OnSearchButtonClick;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.PathTextBox.Location = new Point(49, 12);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new Size(161, 23);
            this.PathTextBox.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new Point(12, 15);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new Size(31, 15);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.ConnectButton.Location = new Point(297, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new Size(75, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += this.OnConnectButtonClick;
            // 
            // DatabaseConnectionForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(384, 46);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.SearchButton);
            this.MinimumSize = new Size(400, 85);
            this.Name = "DatabaseConnectionForm";
            this.Text = "Connect to database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox PathTextBox;
        private Label PathLabel;
        private Button ConnectButton;
    }
}