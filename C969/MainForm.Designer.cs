namespace C969
{
    partial class MainForm
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
            ManageB = new Button();
            AppointB = new Button();
            JustData = new DataGridView();
            monthCalendar2 = new MonthCalendar();
            ReportB = new Button();
            ((System.ComponentModel.ISupportInitialize)JustData).BeginInit();
            SuspendLayout();
            // 
            // ManageB
            // 
            ManageB.Location = new Point(47, 59);
            ManageB.Name = "ManageB";
            ManageB.Size = new Size(75, 23);
            ManageB.TabIndex = 0;
            ManageB.Text = "Manage ";
            ManageB.UseVisualStyleBackColor = true;
            // 
            // AppointB
            // 
            AppointB.Location = new Point(47, 185);
            AppointB.Name = "AppointB";
            AppointB.Size = new Size(75, 23);
            AppointB.TabIndex = 12;
            AppointB.Text = "Schedule";
            AppointB.UseVisualStyleBackColor = true;
            // 
            // JustData
            // 
            JustData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JustData.Location = new Point(234, 270);
            JustData.Name = "JustData";
            JustData.Size = new Size(554, 168);
            JustData.TabIndex = 13;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(234, 59);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 14;
            // 
            // ReportB
            // 
            ReportB.Location = new Point(47, 309);
            ReportB.Name = "ReportB";
            ReportB.Size = new Size(75, 23);
            ReportB.TabIndex = 15;
            ReportB.Text = "Reports";
            ReportB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportB);
            Controls.Add(monthCalendar2);
            Controls.Add(JustData);
            Controls.Add(AppointB);
            Controls.Add(ManageB);
            Name = "MainForm";
            Text = "Home";
            Load += StartUp;
            ((System.ComponentModel.ISupportInitialize)JustData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        void ManageB_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.ShowDialog();
        }

        void AppointB_Click(object sender, EventArgs e)
        {
            Appointments schedule = new Appointments();
            schedule.ShowDialog();
        }

        void ReportB_Click(object sender, EventArgs e)
        {
            Form1 reports = new Form1();
            reports.ShowDialog();
        }   


        private void StartUp(object sender, EventArgs e)
        {
            ManageB.Click += ManageB_Click;
            AppointB.Click += AppointB_Click;
            monthCalendar2.DateChanged += Calendar2_DateChanged;

            JustData.DataSource = SQLApp.Dailyr;
            JustData.Columns["appID"].Visible = false;
            JustData.Columns["custid"].Visible = false;
            JustData.Columns["userid"].Visible = false;
            JustData.Columns["title"].Visible = false;
            JustData.Columns["url"].Visible = false;
            JustData.Columns["Name"].HeaderText ="Name";
            JustData.Columns["description"].HeaderText = "Description";
            JustData.Columns["location"].HeaderText = "Location";
            JustData.Columns["cont"].HeaderText = "Contact";
            JustData.Columns["type"].HeaderText = "Type";
            JustData.Columns["start"].HeaderText = "Start Time";
            JustData.Columns["end"].HeaderText = "End Time";
            SQLApp.CheckFA();
            ReportB.Click += ReportB_Click;
            initialUp();

        }

        private void Calendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar2.SelectionStart;
            DateTime end = monthCalendar2.SelectionEnd;
            SQLApp.DateApps(start, end);
        }
        private void initialUp()
        {
            SQLApp.DateApps(DateTime.Today, DateTime.Today.AddDays(1));
            JustData.Refresh();
        }

        private Button ManageB;
        private Button AppointB;
        private DataGridView JustData;
        private MonthCalendar monthCalendar2;
        private Button ReportB;
    }
}