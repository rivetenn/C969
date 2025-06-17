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

        private void AddB_Click(object sender, EventArgs e)
        {
            // Code to handle adding an item
        }
        private void DeleteB_Click(object sender, EventArgs e)
        {
            // Code to handle deleting an item
        }
        private void UpdateD_Click(object sender, EventArgs e)
        {
            // Code to handle updating an item
        }

        private void StartUp(object sender, EventArgs e)
        {
            AddB.Click += AddB_Click;
            DeleteB.Click += DeleteB_Click;
            UpdateB.Click += UpdateD_Click;
        }

        private Button AddB;
        private Button UpdateB;
        private Button DeleteB;
        private DataGridView SqlDataView;
    }
}