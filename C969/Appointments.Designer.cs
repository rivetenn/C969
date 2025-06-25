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
            TimeZoneCBox = new ComboBox();
            TimeZ = new Label();
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
            TimeStart.Format = DateTimePickerFormat.Time;
            TimeStart.Location = new Point(104, 370);
            TimeStart.Name = "TimeStart";
            TimeStart.Size = new Size(106, 23);
            TimeStart.TabIndex = 17;
            // 
            // TimeEnd
            // 
            TimeEnd.Format = DateTimePickerFormat.Time;
            TimeEnd.Location = new Point(216, 370);
            TimeEnd.Name = "TimeEnd";
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
            // TimeZoneCBox
            // 
            TimeZoneCBox.FormattingEnabled = true;
            TimeZoneCBox.Location = new Point(297, 326);
            TimeZoneCBox.Name = "TimeZoneCBox";
            TimeZoneCBox.Size = new Size(121, 23);
            TimeZoneCBox.TabIndex = 24;
            // 
            // TimeZ
            // 
            TimeZ.AutoSize = true;
            TimeZ.Location = new Point(225, 332);
            TimeZ.Name = "TimeZ";
            TimeZ.Size = new Size(66, 15);
            TimeZ.TabIndex = 25;
            TimeZ.Text = "Time Zone:";
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 699);
            Controls.Add(TimeZ);
            Controls.Add(TimeZoneCBox);
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
            ((System.ComponentModel.ISupportInitialize)DataApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Load += StartUp;
        }
        #endregion

        private void StartUp(object sender, EventArgs e)
        {

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
        private ComboBox TimeZoneCBox;
        private Label TimeZ;
    }
}