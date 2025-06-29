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
            Calendar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)JustData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).BeginInit();
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
            JustData.Location = new Point(234, 288);
            JustData.Name = "JustData";
            JustData.Size = new Size(554, 150);
            JustData.TabIndex = 13;
            // 
            // Calendar
            // 
            Calendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Calendar.Location = new Point(234, 40);
            Calendar.Name = "Calendar";
            Calendar.Size = new Size(554, 242);
            Calendar.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calendar);
            Controls.Add(JustData);
            Controls.Add(AppointB);
            Controls.Add(ManageB);
            Name = "MainForm";
            Text = "Home";
            Load += StartUp;
            ((System.ComponentModel.ISupportInitialize)JustData).EndInit();
            ((System.ComponentModel.ISupportInitialize)Calendar).EndInit();
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


        private void StartUp(object sender, EventArgs e)
        {
            ManageB.Click += ManageB_Click;
            AppointB.Click += AppointB_Click;
        }
        private Button ManageB;
        private Button AppointB;
        private MonthCalendar monthCalendar1;
        private DataGridView JustData;
        private DataGridView Calendar;
    }
}