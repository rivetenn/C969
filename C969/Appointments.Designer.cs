using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C969
{
    partial class Appointments
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
            PeopleL = new Label();
            ClientBox = new ComboBox();
            TitlL = new Label();
            DescriptionL = new Label();
            Loc = new Label();
            ContactL = new Label();
            TypeL = new Label();
            label7 = new Label();
            label1 = new Label();
            TitleBox = new TextBox();
            DescBox = new TextBox();
            LBox = new TextBox();
            ContactBox = new TextBox();
            TypeBox = new TextBox();
            DateO = new DateTimePicker();
            TimeStart = new DateTimePicker();
            TimeEnd = new DateTimePicker();
            DataApp = new DataGridView();
            CancelB = new Button();
            SaveB = new Button();
            UpdateB = new Button();
            DeleteB = new Button();
            ClearB = new Button();
            TimeZL = new Label();
            label2 = new Label();
            label3 = new Label();
            ESTStart = new DateTimePicker();
            ESTend = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataApp).BeginInit();
            SuspendLayout();
            // 
            // PeopleL
            // 
            PeopleL.AutoSize = true;
            PeopleL.Location = new Point(37, 44);
            PeopleL.Name = "PeopleL";
            PeopleL.Size = new Size(41, 15);
            PeopleL.TabIndex = 0;
            PeopleL.Text = "Client:";
            // 
            // ClientBox
            // 
            ClientBox.FormattingEnabled = true;
            ClientBox.Location = new Point(104, 37);
            ClientBox.Name = "ClientBox";
            ClientBox.Size = new Size(121, 23);
            ClientBox.TabIndex = 1;
            // 
            // TitlL
            // 
            TitlL.AutoSize = true;
            TitlL.Location = new Point(46, 92);
            TitlL.Name = "TitlL";
            TitlL.Size = new Size(32, 15);
            TitlL.TabIndex = 3;
            TitlL.Text = "Title:";
            // 
            // DescriptionL
            // 
            DescriptionL.AutoSize = true;
            DescriptionL.Location = new Point(8, 138);
            DescriptionL.Name = "DescriptionL";
            DescriptionL.Size = new Size(70, 15);
            DescriptionL.TabIndex = 4;
            DescriptionL.Text = "Description:";
            // 
            // Loc
            // 
            Loc.AutoSize = true;
            Loc.Location = new Point(22, 185);
            Loc.Name = "Loc";
            Loc.Size = new Size(56, 15);
            Loc.TabIndex = 5;
            Loc.Text = "Location:";
            // 
            // ContactL
            // 
            ContactL.AutoSize = true;
            ContactL.Location = new Point(26, 236);
            ContactL.Name = "ContactL";
            ContactL.Size = new Size(52, 15);
            ContactL.TabIndex = 6;
            ContactL.Text = "Contact:";
            // 
            // TypeL
            // 
            TypeL.AutoSize = true;
            TypeL.Location = new Point(44, 281);
            TypeL.Name = "TypeL";
            TypeL.Size = new Size(34, 15);
            TypeL.TabIndex = 8;
            TypeL.Text = "Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 332);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 9;
            label7.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 378);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Time:";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(104, 84);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(169, 23);
            TitleBox.TabIndex = 11;
            // 
            // DescBox
            // 
            DescBox.Location = new Point(104, 130);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(169, 23);
            DescBox.TabIndex = 12;
            // 
            // LBox
            // 
            LBox.Location = new Point(104, 177);
            LBox.Name = "LBox";
            LBox.Size = new Size(169, 23);
            LBox.TabIndex = 13;
            // 
            // ContactBox
            // 
            ContactBox.Location = new Point(104, 228);
            ContactBox.Name = "ContactBox";
            ContactBox.Size = new Size(169, 23);
            ContactBox.TabIndex = 14;
            // 
            // TypeBox
            // 
            TypeBox.Location = new Point(104, 273);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(169, 23);
            TypeBox.TabIndex = 15;
            // 
            // DateO
            // 
            DateO.Format = DateTimePickerFormat.Short;
            DateO.Location = new Point(104, 326);
            DateO.Name = "DateO";
            DateO.Size = new Size(102, 23);
            DateO.TabIndex = 16;
            // 
            // TimeStart
            // 
            TimeStart.CustomFormat = "hh:mm tt";
            TimeStart.Format = DateTimePickerFormat.Custom;
            TimeStart.Location = new Point(104, 370);
            TimeStart.Name = "TimeStart";
            TimeStart.ShowUpDown = true;
            TimeStart.Size = new Size(106, 23);
            TimeStart.TabIndex = 17;
            // 
            // TimeEnd
            // 
            TimeEnd.CustomFormat = "hh:mm tt";
            TimeEnd.Format = DateTimePickerFormat.Custom;
            TimeEnd.Location = new Point(216, 370);
            TimeEnd.Name = "TimeEnd";
            TimeEnd.ShowUpDown = true;
            TimeEnd.Size = new Size(106, 23);
            TimeEnd.TabIndex = 18;
            // 
            // DataApp
            // 
            DataApp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataApp.Location = new Point(47, 429);
            DataApp.Name = "DataApp";
            DataApp.Size = new Size(636, 227);
            DataApp.TabIndex = 19;
            // 
            // CancelB
            // 
            CancelB.Location = new Point(608, 664);
            CancelB.Name = "CancelB";
            CancelB.Size = new Size(75, 23);
            CancelB.TabIndex = 20;
            CancelB.Text = "Cancel";
            CancelB.UseVisualStyleBackColor = true;
            // 
            // SaveB
            // 
            SaveB.Location = new Point(47, 662);
            SaveB.Name = "SaveB";
            SaveB.Size = new Size(75, 23);
            SaveB.TabIndex = 21;
            SaveB.Text = "Save";
            SaveB.UseVisualStyleBackColor = true;
            // 
            // UpdateB
            // 
            UpdateB.Location = new Point(131, 662);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(75, 23);
            UpdateB.TabIndex = 22;
            UpdateB.Text = "Update";
            UpdateB.UseVisualStyleBackColor = true;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(216, 662);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(75, 23);
            DeleteB.TabIndex = 23;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            // 
            // ClearB
            // 
            ClearB.Location = new Point(482, 664);
            ClearB.Name = "ClearB";
            ClearB.Size = new Size(75, 23);
            ClearB.TabIndex = 27;
            ClearB.Text = "Clear";
            ClearB.UseVisualStyleBackColor = true;
            // 
            // TimeZL
            // 
            TimeZL.AutoSize = true;
            TimeZL.Location = new Point(319, 332);
            TimeZL.Name = "TimeZL";
            TimeZL.Size = new Size(63, 15);
            TimeZL.TabIndex = 28;
            TimeZL.Text = "Time Zone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 332);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 29;
            label2.Text = "Local Time Zone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 334);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 30;
            label3.Text = "EST";
            label3.Click += label3_Click;
            // 
            // ESTStart
            // 
            ESTStart.CustomFormat = "hh:mm tt";
            ESTStart.Format = DateTimePickerFormat.Custom;
            ESTStart.Location = new Point(438, 370);
            ESTStart.Name = "ESTStart";
            ESTStart.ShowUpDown = true;
            ESTStart.Size = new Size(106, 23);
            ESTStart.TabIndex = 31;
            // 
            // ESTend
            // 
            ESTend.CustomFormat = "hh:mm tt";
            ESTend.Format = DateTimePickerFormat.Custom;
            ESTend.Location = new Point(550, 370);
            ESTend.Name = "ESTend";
            ESTend.ShowUpDown = true;
            ESTend.Size = new Size(106, 23);
            ESTend.TabIndex = 32;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 699);
            Controls.Add(ESTend);
            Controls.Add(ESTStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TimeZL);
            Controls.Add(ClearB);
            Controls.Add(DeleteB);
            Controls.Add(UpdateB);
            Controls.Add(SaveB);
            Controls.Add(CancelB);
            Controls.Add(DataApp);
            Controls.Add(TimeEnd);
            Controls.Add(TimeStart);
            Controls.Add(DateO);
            Controls.Add(TypeBox);
            Controls.Add(ContactBox);
            Controls.Add(LBox);
            Controls.Add(DescBox);
            Controls.Add(TitleBox);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(TypeL);
            Controls.Add(ContactL);
            Controls.Add(Loc);
            Controls.Add(DescriptionL);
            Controls.Add(TitlL);
            Controls.Add(ClientBox);
            Controls.Add(PeopleL);
            Name = "Appointments";
            Text = "Appointments";
            Load += StartUp;
            ((System.ComponentModel.ISupportInitialize)DataApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        public static Dictionary<string, int> ApDic = new Dictionary<string, int>() ;
        private void Add_Click(object sender, EventArgs e)
        {try{
            if (ClientBox.SelectedItem == null) return;

            TimeManagement(-1);
            var app = new AppTools(GetUserID(ClientBox.Text), GetselfID(), ClientBox.Text, TitleBox.Text, DescBox.Text,
                LBox.Text, ContactBox.Text, TypeBox.Text, start, end);

            SQLApp.AddAppointment(app);
            SQLApp.UpdateDataH();
                ClearAll(); }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try{
            if (DataApp.SelectedRows.Count == 0) return;
            int appId = (int)DataApp.SelectedRows[0].Cells["appID"].Value;
            TimeManagement(appId);

            var app = new AppTools(GetUserID(ClientBox.Text), GetselfID(), ClientBox.Text, TitleBox.Text, DescBox.Text,
                LBox.Text, ContactBox.Text, TypeBox.Text, start, end, appID: appId);

            SQLApp.UpdateAppointment(app);
            SQLApp.UpdateDataH();
                ClearAll(); }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }
        private void StartUp(object sender, EventArgs e)
        {
            SQLStuff.GetNames(ClientBox, ApDic);
            DataApp.DataSource = SQLApp.DataHolder;
            SQLApp.UpdateDataH();
            DataApp.Columns["appID"].Visible = false;
            DataApp.Columns["custid"].Visible = false;
            DataApp.Columns["userid"].Visible = false;
            DataApp.ReadOnly = true;
            DataApp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SaveB.Click += Add_Click;
            CancelB.Click += Cancel_Click;
            DeleteB.Click += Delete_Click;
            UpdateB.Click += Update_Click;
            DataApp.CellClick += Selectedthis;
            ClearB.Click += Clear_Click;
            TimeZL.Text = TimeZoneInfo.Local.ToString();
            TimeStart.ValueChanged += updateClock;
            TimeEnd.ValueChanged += updateClock;
            ESTStart.Enabled = false;
            ESTend.Enabled = false;


        }
        private void updateClock(object sender, EventArgs e)
        {
            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            DateTime localStart = DateO.Value.Date + TimeStart.Value.TimeOfDay;
            DateTime localEnd = DateO.Value.Date + TimeEnd.Value.TimeOfDay;

            localStart = DateTime.SpecifyKind(localStart, DateTimeKind.Local);
            localEnd = DateTime.SpecifyKind(localEnd, DateTimeKind.Local);

            DateTime estStart = TimeZoneInfo.ConvertTime(localStart, estZone);
            DateTime estEnd = TimeZoneInfo.ConvertTime(localEnd, estZone);

            ESTStart.Value = estStart;
            ESTend.Value = estEnd;
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            if (DataApp.SelectedRows.Count == 0)
            {
                return;
            }
            int appId = (int)DataApp.SelectedRows[0].Cells["appID"].Value;
            SQLApp.DeleteAppointment(appId);
        }

        private int GetUserID(string name)
        {
            return ApDic.TryGetValue(name, out int userId) ? userId : 0;
        }

        private int GetselfID()
        {
            return SQLStuff.GetselfId();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        DateTime start;
        DateTime end;


        private void TimeManagement(int? id)
        {
            if (DateO.Value.DayOfWeek == DayOfWeek.Saturday || DateO.Value.DayOfWeek == DayOfWeek.Sunday)
                throw new Exception("Invalid Date: Cannot be on a weekend.");

            DateTime localStart = DateO.Value.Date + TimeStart.Value.TimeOfDay;
            DateTime localEnd = DateO.Value.Date + TimeEnd.Value.TimeOfDay;

            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime estStart = TimeZoneInfo.ConvertTime(localStart, TimeZoneInfo.Local, estZone);
            DateTime estEnd = TimeZoneInfo.ConvertTime(localEnd, TimeZoneInfo.Local, estZone);

            if (estStart.Hour < 9 || estEnd.Hour > 17 || (estEnd.Hour == 17 && estEnd.Minute > 0) || estEnd <= estStart)
                throw new Exception("Invalid Time: Must be between 9 AM and 5 PM EST");

            start = TimeZoneInfo.ConvertTimeToUtc(localStart, TimeZoneInfo.Local);
            end = TimeZoneInfo.ConvertTimeToUtc(localEnd, TimeZoneInfo.Local);

            if (id == -1)
            {
                if (SQLApp.CheckForApp(start, end))
                    throw new Exception("Appointment Exists");
            }
            else
            {
                if (SQLApp.CheckForApp(start, end, id.Value))
                    throw new Exception("Appointment Exists");
            }
        }


        private void Selectedthis(object sender, DataGridViewCellEventArgs e)
        {
            if (DataApp.SelectedRows.Count > 0)
            {
                int index = DataApp.SelectedRows[0].Index;
                AppTools selected = SQLApp.DataHolder[index];

                ClientBox.SelectedItem = selected.name;
                TitleBox.Text = selected.title;
                DescBox.Text = selected.description;
                LBox.Text = selected.location;
                ContactBox.Text = selected.cont;
                TypeBox.Text = selected.type;
                DateO.Value = selected.start.Date;
                TimeStart.Value = selected.start;
                TimeEnd.Value = selected.end;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            ClientBox.SelectedIndex = -1;
            TitleBox.Clear();
            DescBox.Clear();
            LBox.Clear();
            ContactBox.Clear();
            TypeBox.Clear();
            DateO.Value = DateTime.Now;
            TimeStart.Value = DateTime.Now;
            TimeEnd.Value = DateTime.Now;
        }

        private Label PeopleL;
        private ComboBox ClientBox;
        private Label TitlL;
        private Label DescriptionL;
        private Label Loc;
        private Label ContactL;
        private Label TypeL;
        private Label label7;
        private Label label1;
        private TextBox TitleBox;
        private TextBox DescBox;
        private TextBox LBox;
        private TextBox ContactBox;
        private TextBox TypeBox;
        private DateTimePicker DateO;
        private DateTimePicker TimeStart;
        private DateTimePicker TimeEnd;
        private DataGridView DataApp;
        private Button CancelB;
        private Button SaveB;
        private Button UpdateB;
        private Button DeleteB;
        private Button ClearB;
        private Label TimeZL;
        private Label label2;
        private Label label3;
        private DateTimePicker ESTStart;
        private DateTimePicker ESTend;
    }
}