using Mysqlx.Crud;

namespace C969
{
    partial class Records
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
            NameL = new Label();
            PhoneL = new Label();
            AddressL = new Label();
            AddB = new Button();
            UpdateB = new Button();
            DeleteB = new Button();
            SqlDataView = new DataGridView();
            NameBox = new TextBox();
            PhoneBox = new TextBox();
            AddressBox = new TextBox();
            ZipL = new Label();
            label1 = new Label();
            label2 = new Label();
            CountryBox = new TextBox();
            CityBox = new TextBox();
            ZipBox = new TextBox();
            Addres2Box = new TextBox();
            label3 = new Label();
            ClearB = new Button();
            ((System.ComponentModel.ISupportInitialize)SqlDataView).BeginInit();
            SuspendLayout();
            // 
            // NameL
            // 
            NameL.AutoSize = true;
            NameL.Location = new Point(34, 250);
            NameL.Name = "NameL";
            NameL.Size = new Size(39, 15);
            NameL.TabIndex = 0;
            NameL.Text = "Name";
            // 
            // PhoneL
            // 
            PhoneL.AutoSize = true;
            PhoneL.Location = new Point(22, 305);
            PhoneL.Name = "PhoneL";
            PhoneL.Size = new Size(51, 15);
            PhoneL.TabIndex = 1;
            PhoneL.Text = "Phone #";
            // 
            // AddressL
            // 
            AddressL.AutoSize = true;
            AddressL.Location = new Point(24, 361);
            AddressL.Name = "AddressL";
            AddressL.Size = new Size(49, 15);
            AddressL.TabIndex = 2;
            AddressL.Text = "Address";
            // 
            // AddB
            // 
            AddB.Location = new Point(34, 33);
            AddB.Name = "AddB";
            AddB.Size = new Size(75, 23);
            AddB.TabIndex = 3;
            AddB.Text = "Add";
            AddB.UseVisualStyleBackColor = true;
            // 
            // UpdateB
            // 
            UpdateB.Location = new Point(34, 102);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(75, 23);
            UpdateB.TabIndex = 4;
            UpdateB.Text = "Modify";
            UpdateB.UseVisualStyleBackColor = true;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(34, 175);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(75, 23);
            DeleteB.TabIndex = 5;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            // 
            // SqlDataView
            // 
            SqlDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SqlDataView.Location = new Point(138, 33);
            SqlDataView.Name = "SqlDataView";
            SqlDataView.Size = new Size(355, 165);
            SqlDataView.TabIndex = 6;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(93, 242);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 7;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(93, 297);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(100, 23);
            PhoneBox.TabIndex = 8;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(93, 353);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(100, 23);
            AddressBox.TabIndex = 9;
            // 
            // ZipL
            // 
            ZipL.AutoSize = true;
            ZipL.Location = new Point(211, 361);
            ZipL.Name = "ZipL";
            ZipL.Size = new Size(55, 15);
            ZipL.TabIndex = 10;
            ZipL.Text = "Zip Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 305);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 11;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 245);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 12;
            label2.Text = "Country";
            // 
            // CountryBox
            // 
            CountryBox.Location = new Point(276, 242);
            CountryBox.Name = "CountryBox";
            CountryBox.Size = new Size(100, 23);
            CountryBox.TabIndex = 13;
            // 
            // CityBox
            // 
            CityBox.Location = new Point(276, 297);
            CityBox.Name = "CityBox";
            CityBox.Size = new Size(100, 23);
            CityBox.TabIndex = 14;
            // 
            // ZipBox
            // 
            ZipBox.Location = new Point(276, 353);
            ZipBox.Name = "ZipBox";
            ZipBox.Size = new Size(100, 23);
            ZipBox.TabIndex = 15;
            // 
            // Addres2Box
            // 
            Addres2Box.Location = new Point(93, 402);
            Addres2Box.Name = "Addres2Box";
            Addres2Box.Size = new Size(100, 23);
            Addres2Box.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 410);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 17;
            label3.Text = "Address 2";
            // 
            // ClearB
            // 
            ClearB.Location = new Point(276, 401);
            ClearB.Name = "ClearB";
            ClearB.Size = new Size(75, 23);
            ClearB.TabIndex = 18;
            ClearB.Text = "Clear";
            ClearB.UseVisualStyleBackColor = true;
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(ClearB);
            Controls.Add(label3);
            Controls.Add(Addres2Box);
            Controls.Add(ZipBox);
            Controls.Add(CityBox);
            Controls.Add(CountryBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ZipL);
            Controls.Add(AddressBox);
            Controls.Add(PhoneBox);
            Controls.Add(NameBox);
            Controls.Add(SqlDataView);
            Controls.Add(DeleteB);
            Controls.Add(UpdateB);
            Controls.Add(AddB);
            Controls.Add(AddressL);
            Controls.Add(PhoneL);
            Controls.Add(NameL);
            Name = "Records";
            Text = "Records Management";
            Load += StartUp;
            ((System.ComponentModel.ISupportInitialize)SqlDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private void AddB_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerData newCustomer = new CustomerData(NameBox.Text, AddressBox.Text, PhoneBox.Text,  
                    CountryBox.Text, CityBox.Text, ZipBox.Text, Addres2Box.Text);
                SQLStuff.AddCustomer(newCustomer);
                SQLStuff.UpdateDataH();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data: " + ex.Message);
            }
        }
        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (SqlDataView.SelectedRows.Count > 0)
            {
                int crustomer = SqlDataView.SelectedRows[0].Index;
                CustomerData custId = SQLStuff.DataHolder[crustomer];
                if (custId.CustId.HasValue)
                {
                    SQLStuff.DeleteCustomer(custId);
                    ClearTextBoxes();
                }
            }
        }
        private void UpdateD_Click(object sender, EventArgs e)
        {
            if (SqlDataView.SelectedRows.Count > 0)
            {
                int crustomer = SqlDataView.SelectedRows[0].Index;
                CustomerData custId = SQLStuff.DataHolder[crustomer];
                if (custId.CustId.HasValue)
                {
                    SQLStuff.UpdateCustomer(custId);
                    ClearTextBoxes();
                }
            }
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Selectedthis(object sender, DataGridViewCellEventArgs e)
        {
            if (SqlDataView.SelectedRows.Count > 0)
            {
                int num = SqlDataView.SelectedRows[0].Index;
                CustomerData toboxes = SQLStuff.DataHolder[num];
                NameBox.Text = toboxes.Name;
                PhoneBox.Text = toboxes.Phone;
                AddressBox.Text = toboxes.Address;
                CountryBox.Text = toboxes.Country;
                CityBox.Text = toboxes.City;
                ZipBox.Text = toboxes.PostalCode;
                Addres2Box.Text = toboxes.Address2;
            }
        }

        private void StartUp(object sender, EventArgs e)
        {
            AddB.Click += AddB_Click;
            DeleteB.Click += DeleteB_Click;
            UpdateB.Click += UpdateD_Click;
            ClearB.Click += ClearB_Click;
            SQLStuff.UpdateDataH();
            SqlDataView.DataSource = SQLStuff.DataHolder;
            SqlDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SqlDataView.Columns["CustId"].Visible = false;
            SqlDataView.MultiSelect = false;
            SqlDataView.CellClick += Selectedthis;
        }

        private void ClearTextBoxes()
        {
            NameBox.Clear();
            PhoneBox.Clear();
            AddressBox.Clear();
            CountryBox.Clear();
            CityBox.Clear();
            ZipBox.Clear();
            Addres2Box.Clear();
        }
        private Label NameL;
        private Label PhoneL;
        private Label AddressL;
        private Button AddB;
        private Button UpdateB;
        private Button DeleteB;
        private DataGridView SqlDataView;
        private TextBox NameBox;
        private TextBox PhoneBox;
        private TextBox AddressBox;
        private Label ZipL;
        private Label label1;
        private Label label2;
        private TextBox CountryBox;
        private TextBox CityBox;
        private TextBox ZipBox;
        private TextBox Addres2Box;
        private Label label3;
        private Button ClearB;
    }
}