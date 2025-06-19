using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label addressL;
            AddB = new Button();
            UpdateB = new Button();
            DeleteB = new Button();
            SqlDataView = new DataGridView();
            this.NameL = new Label();
            this.PhoneL = new Label();
            this.NameBox = new TextBox();
            this.AddressBox = new TextBox();
            this.PhoneBox = new TextBox();
            addressL = new Label();
            ((ISupportInitialize)SqlDataView).BeginInit();
            SuspendLayout();
            // 
            // AddB
            // 
            AddB.Location = new Point(38, 49);
            AddB.Name = "AddB";
            AddB.Size = new Size(75, 23);
            AddB.TabIndex = 0;
            AddB.Text = "Add";
            AddB.UseVisualStyleBackColor = true;
            // 
            // UpdateB
            // 
            UpdateB.Location = new Point(38, 110);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(75, 23);
            UpdateB.TabIndex = 1;
            UpdateB.Text = "Update";
            UpdateB.UseVisualStyleBackColor = true;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(38, 176);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(75, 23);
            DeleteB.TabIndex = 2;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            // 
            // SqlDataView
            // 
            SqlDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SqlDataView.Location = new Point(147, 49);
            SqlDataView.Name = "SqlDataView";
            SqlDataView.Size = new Size(336, 150);
            SqlDataView.TabIndex = 3;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new Point(38, 270);
            this.NameL.Name = "NameL";
            this.NameL.Size = new Size(39, 15);
            this.NameL.TabIndex = 4;
            this.NameL.Text = "Name";
            // 
            // addressL
            // 
            addressL.AutoSize = true;
            addressL.Location = new Point(38, 333);
            addressL.Name = "addressL";
            addressL.Size = new Size(49, 15);
            addressL.TabIndex = 5;
            addressL.Text = "Address";
            // 
            // PhoneL
            // 
            this.PhoneL.AutoSize = true;
            this.PhoneL.Location = new Point(38, 395);
            this.PhoneL.Name = "PhoneL";
            this.PhoneL.Size = new Size(41, 15);
            this.PhoneL.TabIndex = 6;
            this.PhoneL.Text = "Phone";
            // 
            // NameBox
            // 
            this.NameBox.Location = new Point(108, 262);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new Size(100, 23);
            this.NameBox.TabIndex = 7;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new Point(108, 325);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new Size(100, 23);
            this.AddressBox.TabIndex = 8;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new Point(108, 387);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new Size(100, 23);
            this.PhoneBox.TabIndex = 9;
            // 
            // Records
            // 
            ClientSize = new Size(495, 488);
            Controls.Add(this.PhoneBox);
            Controls.Add(this.AddressBox);
            Controls.Add(this.NameBox);
            Controls.Add(this.PhoneL);
            Controls.Add(addressL);
            Controls.Add(this.NameL);
            Controls.Add(SqlDataView);
            Controls.Add(DeleteB);
            Controls.Add(UpdateB);
            Controls.Add(AddB);
            Name = "Records";
            ((ISupportInitialize)SqlDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
