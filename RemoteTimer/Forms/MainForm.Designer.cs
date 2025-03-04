namespace RemoteTimer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartWorkButton = new Button();
            this.StopWorkButton = new Button();
            this.StartBreakButton = new Button();
            this.StopBreakButton = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.WorkLabel = new Label();
            this.BreakLabel = new Label();
            this.SummaryGrid = new DataGridView();
            this.SummaryLabel = new Label();
            this.WorkTimer = new TextBox();
            this.BreakTimer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)this.SummaryGrid).BeginInit();
            SuspendLayout();
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.StartWorkButton.Location = new Point(307, 12);
            this.StartWorkButton.Name = "StartWorkButton";
            this.StartWorkButton.Size = new Size(49, 23);
            this.StartWorkButton.TabIndex = 0;
            this.StartWorkButton.Text = "Start";
            this.StartWorkButton.UseVisualStyleBackColor = true;
            this.StartWorkButton.Click += OnStartWorkButtonClick;
            // 
            // StopWorkButton
            // 
            this.StopWorkButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.StopWorkButton.Location = new Point(362, 12);
            this.StopWorkButton.Name = "StopWorkButton";
            this.StopWorkButton.Size = new Size(49, 23);
            this.StopWorkButton.TabIndex = 1;
            this.StopWorkButton.Text = "Stop";
            this.StopWorkButton.UseVisualStyleBackColor = true;
            this.StopWorkButton.Click += OnStopWorkButtonClick;
            // 
            // StartBreakButton
            // 
            this.StartBreakButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.StartBreakButton.Location = new Point(307, 41);
            this.StartBreakButton.Name = "StartBreakButton";
            this.StartBreakButton.Size = new Size(49, 23);
            this.StartBreakButton.TabIndex = 2;
            this.StartBreakButton.Text = "Start";
            this.StartBreakButton.UseVisualStyleBackColor = true;
            this.StartBreakButton.Click += OnStartBreakButtonClick;
            // 
            // StopBreakButton
            // 
            this.StopBreakButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.StopBreakButton.Location = new Point(362, 41);
            this.StopBreakButton.Name = "StopBreakButton";
            this.StopBreakButton.Size = new Size(49, 23);
            this.StopBreakButton.TabIndex = 3;
            this.StopBreakButton.Text = "Stop";
            this.StopBreakButton.UseVisualStyleBackColor = true;
            this.StopBreakButton.Click += OnStopBreakButtonClick;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox1.Location = new Point(76, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(225, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBox2.Location = new Point(76, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(225, 23);
            this.textBox2.TabIndex = 5;
            // 
            // WorkLabel
            // 
            this.WorkLabel.AutoSize = true;
            this.WorkLabel.Location = new Point(12, 16);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new Size(35, 15);
            this.WorkLabel.TabIndex = 6;
            this.WorkLabel.Text = "Work";
            // 
            // BreakLabel
            // 
            this.BreakLabel.AutoSize = true;
            this.BreakLabel.Location = new Point(12, 45);
            this.BreakLabel.Name = "BreakLabel";
            this.BreakLabel.Size = new Size(36, 15);
            this.BreakLabel.TabIndex = 7;
            this.BreakLabel.Text = "Break";
            // 
            // SummaryGrid
            // 
            this.SummaryGrid.AllowUserToAddRows = false;
            this.SummaryGrid.AllowUserToDeleteRows = false;
            this.SummaryGrid.AllowUserToOrderColumns = true;
            this.SummaryGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.SummaryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryGrid.Location = new Point(76, 70);
            this.SummaryGrid.Name = "SummaryGrid";
            this.SummaryGrid.ReadOnly = true;
            this.SummaryGrid.Size = new Size(399, 179);
            this.SummaryGrid.TabIndex = 8;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new Point(12, 73);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new Size(58, 15);
            this.SummaryLabel.TabIndex = 9;
            this.SummaryLabel.Text = "Summary";
            // 
            // WorkTimer
            // 
            this.WorkTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.WorkTimer.Location = new Point(417, 12);
            this.WorkTimer.Name = "WorkTimer";
            this.WorkTimer.Size = new Size(58, 23);
            this.WorkTimer.TabIndex = 10;
            // 
            // BreakTimer
            // 
            this.BreakTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.BreakTimer.Location = new Point(417, 40);
            this.BreakTimer.Name = "BreakTimer";
            this.BreakTimer.Size = new Size(58, 23);
            this.BreakTimer.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(484, 261);
            this.Controls.Add(this.BreakTimer);
            this.Controls.Add(this.WorkTimer);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.SummaryGrid);
            this.Controls.Add(this.BreakLabel);
            this.Controls.Add(this.WorkLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StopBreakButton);
            this.Controls.Add(this.StartBreakButton);
            this.Controls.Add(this.StopWorkButton);
            this.Controls.Add(this.StartWorkButton);
            this.MinimumSize = new Size(500, 300);
            this.Name = "MainForm";
            this.Text = "Remote Timer";
            ((System.ComponentModel.ISupportInitialize)this.SummaryGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartWorkButton;
        private Button StopWorkButton;
        private Button StartBreakButton;
        private Button StopBreakButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label WorkLabel;
        private Label BreakLabel;
        private DataGridView SummaryGrid;
        private Label SummaryLabel;
        private TextBox WorkTimer;
        private TextBox BreakTimer;
    }
}
