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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ManageB);
            Name = "MainForm";
            Text = "Home";
            Load += StartUp;
            ResumeLayout(false);
        }

        #endregion
        void ManageB_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.ShowDialog();
        }


        private void StartUp(object sender, EventArgs e)
        {
            ManageB.Click += ManageB_Click;
        }
        private Button ManageB;
    }
}