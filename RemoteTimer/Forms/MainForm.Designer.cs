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
            this.WorkDescriptionTextBox = new TextBox();
            this.BreakDescriptionTextBox = new TextBox();
            this.WorkLabel = new Label();
            this.BreakLabel = new Label();
            this.SummaryGrid = new DataGridView();
            this.SummaryUsername = new DataGridViewTextBoxColumn();
            this.Day = new DataGridViewTextBoxColumn();
            this.WorkTime = new DataGridViewTextBoxColumn();
            this.BreakTime = new DataGridViewTextBoxColumn();
            this.TotalTime = new DataGridViewTextBoxColumn();
            this.Toll = new DataGridViewTextBoxColumn();
            this.SummaryLabel = new Label();
            this.WorkTimer = new TextBox();
            this.BreakTimer = new TextBox();
            this.TodayGrid = new DataGridView();
            this.TodayUsername = new DataGridViewTextBoxColumn();
            this.Type = new DataGridViewTextBoxColumn();
            this.Start = new DataGridViewTextBoxColumn();
            this.Stop = new DataGridViewTextBoxColumn();
            this.Description = new DataGridViewTextBoxColumn();
            this.TodayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)this.SummaryGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TodayGrid).BeginInit();
            SuspendLayout();
            // 
            // StartWorkButton
            // 
            this.StartWorkButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.StartWorkButton.Location = new Point(551, 12);
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
            this.StopWorkButton.Location = new Point(606, 12);
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
            this.StartBreakButton.Location = new Point(551, 41);
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
            this.StopBreakButton.Location = new Point(606, 41);
            this.StopBreakButton.Name = "StopBreakButton";
            this.StopBreakButton.Size = new Size(49, 23);
            this.StopBreakButton.TabIndex = 3;
            this.StopBreakButton.Text = "Stop";
            this.StopBreakButton.UseVisualStyleBackColor = true;
            this.StopBreakButton.Click += OnStopBreakButtonClick;
            // 
            // WorkDescriptionTextBox
            // 
            this.WorkDescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.WorkDescriptionTextBox.Location = new Point(76, 12);
            this.WorkDescriptionTextBox.Name = "WorkDescriptionTextBox";
            this.WorkDescriptionTextBox.Size = new Size(469, 23);
            this.WorkDescriptionTextBox.TabIndex = 4;
            // 
            // BreakDescriptionTextBox
            // 
            this.BreakDescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.BreakDescriptionTextBox.Location = new Point(76, 41);
            this.BreakDescriptionTextBox.Name = "BreakDescriptionTextBox";
            this.BreakDescriptionTextBox.Size = new Size(469, 23);
            this.BreakDescriptionTextBox.TabIndex = 5;
            // 
            // WorkLabel
            // 
            this.WorkLabel.AutoSize = true;
            this.WorkLabel.Location = new Point(32, 16);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new Size(35, 15);
            this.WorkLabel.TabIndex = 6;
            this.WorkLabel.Text = "Work";
            // 
            // BreakLabel
            // 
            this.BreakLabel.AutoSize = true;
            this.BreakLabel.Location = new Point(32, 45);
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
            this.SummaryGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.SummaryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryGrid.Columns.AddRange(new DataGridViewColumn[] { this.SummaryUsername, this.Day, this.WorkTime, this.BreakTime, this.TotalTime, this.Toll });
            this.SummaryGrid.Location = new Point(76, 182);
            this.SummaryGrid.Name = "SummaryGrid";
            this.SummaryGrid.ReadOnly = true;
            this.SummaryGrid.Size = new Size(643, 105);
            this.SummaryGrid.TabIndex = 8;
            // 
            // SummaryUsername
            // 
            this.SummaryUsername.HeaderText = "Username";
            this.SummaryUsername.Name = "SummaryUsername";
            this.SummaryUsername.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // WorkTime
            // 
            this.WorkTime.HeaderText = "Work time";
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.ReadOnly = true;
            // 
            // BreakTime
            // 
            this.BreakTime.HeaderText = "Break time";
            this.BreakTime.Name = "BreakTime";
            this.BreakTime.ReadOnly = true;
            // 
            // TotalTime
            // 
            this.TotalTime.HeaderText = "Total time";
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            // 
            // Toll
            // 
            this.Toll.HeaderText = "Toll (to 8h)";
            this.Toll.Name = "Toll";
            this.Toll.ReadOnly = true;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new Point(12, 185);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new Size(58, 15);
            this.SummaryLabel.TabIndex = 9;
            this.SummaryLabel.Text = "Summary";
            // 
            // WorkTimer
            // 
            this.WorkTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.WorkTimer.Location = new Point(661, 12);
            this.WorkTimer.Name = "WorkTimer";
            this.WorkTimer.Size = new Size(58, 23);
            this.WorkTimer.TabIndex = 10;
            // 
            // BreakTimer
            // 
            this.BreakTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.BreakTimer.Location = new Point(661, 40);
            this.BreakTimer.Name = "BreakTimer";
            this.BreakTimer.Size = new Size(58, 23);
            this.BreakTimer.TabIndex = 11;
            // 
            // TodayGrid
            // 
            this.TodayGrid.AllowUserToAddRows = false;
            this.TodayGrid.AllowUserToDeleteRows = false;
            this.TodayGrid.AllowUserToOrderColumns = true;
            this.TodayGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.TodayGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodayGrid.Columns.AddRange(new DataGridViewColumn[] { this.TodayUsername, this.Type, this.Start, this.Stop, this.Description });
            this.TodayGrid.Location = new Point(76, 70);
            this.TodayGrid.Name = "TodayGrid";
            this.TodayGrid.ReadOnly = true;
            this.TodayGrid.Size = new Size(643, 105);
            this.TodayGrid.TabIndex = 12;
            // 
            // TodayUsername
            // 
            this.TodayUsername.HeaderText = "Username";
            this.TodayUsername.Name = "TodayUsername";
            this.TodayUsername.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // Stop
            // 
            this.Stop.HeaderText = "Stop";
            this.Stop.Name = "Stop";
            this.Stop.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Location = new Point(32, 73);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new Size(38, 15);
            this.TodayLabel.TabIndex = 13;
            this.TodayLabel.Text = "Today";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(728, 299);
            this.Controls.Add(this.TodayLabel);
            this.Controls.Add(this.TodayGrid);
            this.Controls.Add(this.BreakTimer);
            this.Controls.Add(this.WorkTimer);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.SummaryGrid);
            this.Controls.Add(this.BreakLabel);
            this.Controls.Add(this.WorkLabel);
            this.Controls.Add(this.BreakDescriptionTextBox);
            this.Controls.Add(this.WorkDescriptionTextBox);
            this.Controls.Add(this.StopBreakButton);
            this.Controls.Add(this.StartBreakButton);
            this.Controls.Add(this.StopWorkButton);
            this.Controls.Add(this.StartWorkButton);
            this.MinimumSize = new Size(500, 338);
            this.Name = "MainForm";
            this.Text = "Remote Timer";
            ((System.ComponentModel.ISupportInitialize)this.SummaryGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TodayGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartWorkButton;
        private Button StopWorkButton;
        private Button StartBreakButton;
        private Button StopBreakButton;
        private TextBox WorkDescriptionTextBox;
        private TextBox BreakDescriptionTextBox;
        private Label WorkLabel;
        private Label BreakLabel;
        private DataGridView SummaryGrid;
        private Label SummaryLabel;
        private TextBox WorkTimer;
        private TextBox BreakTimer;
        private DataGridView TodayGrid;
        private Label TodayLabel;
        private DataGridViewTextBoxColumn SummaryUsername;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn WorkTime;
        private DataGridViewTextBoxColumn BreakTime;
        private DataGridViewTextBoxColumn TotalTime;
        private DataGridViewTextBoxColumn Toll;
        private DataGridViewTextBoxColumn TodayUsername;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn Stop;
        private DataGridViewTextBoxColumn Description;
    }
}
