namespace C969
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
            UserSched = new DataGridView();
            ML = new Label();
            AllUsers = new DataGridView();
            CancelB = new Button();
            MonthlyReps = new DataGridView();
            UserL = new Label();
            ScheduleL = new Label();
            TOTL = new Label();
            LambdaRL = new Label();
            ((System.ComponentModel.ISupportInitialize)UserSched).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MonthlyReps).BeginInit();
            SuspendLayout();
            // 
            // UserSched
            // 
            UserSched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserSched.Location = new Point(285, 259);
            UserSched.Name = "UserSched";
            UserSched.Size = new Size(501, 140);
            UserSched.TabIndex = 1;
            // 
            // ML
            // 
            ML.AutoSize = true;
            ML.Location = new Point(70, 21);
            ML.Name = "ML";
            ML.Size = new Size(131, 15);
            ML.TabIndex = 3;
            ML.Text = "Reports By Month/Type";
            // 
            // AllUsers
            // 
            AllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllUsers.Location = new Point(285, 39);
            AllUsers.Name = "AllUsers";
            AllUsers.Size = new Size(234, 192);
            AllUsers.TabIndex = 4;
            // 
            // CancelB
            // 
            CancelB.Location = new Point(711, 415);
            CancelB.Name = "CancelB";
            CancelB.Size = new Size(75, 23);
            CancelB.TabIndex = 5;
            CancelB.Text = "Exit";
            CancelB.UseVisualStyleBackColor = true;
            // 
            // MonthlyReps
            // 
            MonthlyReps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonthlyReps.Location = new Point(12, 39);
            MonthlyReps.Name = "MonthlyReps";
            MonthlyReps.Size = new Size(248, 360);
            MonthlyReps.TabIndex = 7;
            // 
            // UserL
            // 
            UserL.AutoSize = true;
            UserL.Location = new Point(382, 21);
            UserL.Name = "UserL";
            UserL.Size = new Size(35, 15);
            UserL.TabIndex = 8;
            UserL.Text = "Users";
            // 
            // ScheduleL
            // 
            ScheduleL.AutoSize = true;
            ScheduleL.Location = new Point(382, 241);
            ScheduleL.Name = "ScheduleL";
            ScheduleL.Size = new Size(55, 15);
            ScheduleL.TabIndex = 9;
            ScheduleL.Text = "Schedule";
            // 
            // TOTL
            // 
            TOTL.AutoSize = true;
            TOTL.Location = new Point(575, 39);
            TOTL.Name = "TOTL";
            TOTL.Size = new Size(134, 15);
            TOTL.TabIndex = 10;
            TOTL.Text = "Total Upcoming Reports";
            // 
            // LambdaRL
            // 
            LambdaRL.AutoSize = true;
            LambdaRL.Location = new Point(635, 54);
            LambdaRL.Name = "LambdaRL";
            LambdaRL.Size = new Size(13, 15);
            LambdaRL.TabIndex = 11;
            LambdaRL.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LambdaRL);
            Controls.Add(TOTL);
            Controls.Add(ScheduleL);
            Controls.Add(UserL);
            Controls.Add(MonthlyReps);
            Controls.Add(CancelB);
            Controls.Add(AllUsers);
            Controls.Add(ML);
            Controls.Add(UserSched);
            Name = "Form1";
            Text = "Reports";
            Load += Startup;
            ((System.ComponentModel.ISupportInitialize)UserSched).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)MonthlyReps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AllUsers.Rows.Count)
            {
                string selectedUser = AllUsers.CurrentRow.Cells[0].Value.ToString();
                UserSched.DataSource = ReportsLambda.UserApps(selectedUser);
            }
        }

        private void Startup(object sender, EventArgs e)
        {
            CancelB.Click += CancelB_Click;
            ReportsLambda.UpdateDataH();
            MonthlyReps.DataSource = ReportsLambda.MonthAndAll();
            SQLStuff.UpdateDataH();
            AllUsers.DataSource = ReportsLambda.GetAllUsers()
                .Select(u => new { Name = u }) 
                .ToList();
            AllUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllUsers.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AllUsers.CellClick += UserClick;
            LambdaRL.Text = ReportsLambda.Count().ToString();

        }

        #endregion
        private DataGridView UserSched;
        private Label ML;
        private DataGridView AllUsers;
        private Button CancelB;
        private DataGridView MonthlyReps;
        private Label UserL;
        private Label ScheduleL;
        private Label TOTL;
        private Label LambdaRL;
    }
}