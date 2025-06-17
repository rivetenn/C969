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
            AddB = new Button();
            UpdateB = new Button();
            DeleteB = new Button();
            this.SqlDataView = new DataGridView();
            ((ISupportInitialize)this.SqlDataView).BeginInit();
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
            UpdateB.Location = new Point(38, 106);
            UpdateB.Name = "UpdateB";
            UpdateB.Size = new Size(75, 23);
            UpdateB.TabIndex = 1;
            UpdateB.Text = "Update";
            UpdateB.UseVisualStyleBackColor = true;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(38, 160);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(75, 23);
            DeleteB.TabIndex = 2;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            // 
            // SqlDataView
            // 
            this.SqlDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SqlDataView.Location = new Point(147, 49);
            this.SqlDataView.Name = "SqlDataView";
            this.SqlDataView.Size = new Size(336, 150);
            this.SqlDataView.TabIndex = 3;
            // 
            // Records
            // 
            ClientSize = new Size(495, 488);
            Controls.Add(this.SqlDataView);
            Controls.Add(DeleteB);
            Controls.Add(UpdateB);
            Controls.Add(AddB);
            Name = "Records";
            ((ISupportInitialize)this.SqlDataView).EndInit();
            ResumeLayout(false);

        }
    }
}
