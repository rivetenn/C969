using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using GeoCoordinatePortable;
using System.Text.Json;
namespace C969
{
    public class Location
    {
        public string ip { get; set; }
        public int ip_version { get; set; }
        public string country_name { get; set; }

        public string country_code2 { get; set; }

        public string isp { get; set; }
        public string response_code { get; set; }
        public string response_message { get; set; }
    }
        partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CountryL = new Label();
            LanguageBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            userbox = new TextBox();
            passwordBox = new TextBox();
            LoginB = new Button();
            CancelB = new Button();
            SuspendLayout();
            // 
            // CountryL
            // 
            CountryL.AutoSize = true;
            CountryL.Location = new Point(336, 29);
            CountryL.Name = "CountryL";
            CountryL.Size = new Size(51, 15);
            CountryL.TabIndex = 0;
            CountryL.Text = "Unkown";
            // 
            // LanguageBox
            // 
            LanguageBox.FormattingEnabled = true;
            LanguageBox.Location = new Point(336, 67);
            LanguageBox.Name = "LanguageBox";
            LanguageBox.Size = new Size(121, 23);
            LanguageBox.TabIndex = 1;
            LanguageBox.Text = "Language";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 171);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 218);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // userbox
            // 
            userbox.Location = new Point(117, 163);
            userbox.Name = "userbox";
            userbox.Size = new Size(173, 23);
            userbox.TabIndex = 5;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(117, 210);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(173, 23);
            passwordBox.TabIndex = 6;
            // 
            // LoginB
            // 
            LoginB.Location = new Point(117, 265);
            LoginB.Name = "LoginB";
            LoginB.Size = new Size(75, 23);
            LoginB.TabIndex = 7;
            LoginB.Text = "Login";
            LoginB.UseVisualStyleBackColor = true;
            // 
            // CancelB
            // 
            CancelB.Location = new Point(215, 265);
            CancelB.Name = "CancelB";
            CancelB.Size = new Size(75, 23);
            CancelB.TabIndex = 8;
            CancelB.Text = "Cancel";
            CancelB.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(CancelB);
            Controls.Add(LoginB);
            Controls.Add(passwordBox);
            Controls.Add(userbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LanguageBox);
            Controls.Add(CountryL);
            Name = "LoginScreen";
            Text = "Login";
            Load += StartUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CountryL;
        private ComboBox LanguageBox;
        private Label label3;
        private Label label4;
        private TextBox userbox;
        private TextBox passwordBox;
        private Button LoginB;
        private Button CancelB;

        private string countryN = "Detecting...";
        public string CountryN { get { return countryN; } set { countryN = value; CountryL.Text = countryN; } }


        private void CancelB_Click(object sender, EventArgs e)
        {
            userbox.Text = "";
            passwordBox.Text = "";
        }

        private void LanguageBox_Changed(object sender, EventArgs e)
        {
            if (LanguageBox.SelectedIndex == 0) 
            {
                label3.Text = "Username";
                label4.Text = "Password";
                LoginB.Text = "Login";
                CancelB.Text = "Cancel";
            }
            else if (LanguageBox.SelectedIndex == 1)
            {
                label3.Text = "ユーザー名";
                label4.Text = "パスワード";
                LoginB.Text = "ログイン";
                CancelB.Text = "キャンセル";
            }
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            LoadLocation();
            LVal login = new LVal();
            login.attemptLog(userbox.Text, passwordBox.Text, LanguageBox.SelectedIndex, this);
        }

        private async void LoadLocation()
        {
            string ip = await GetIP();
            Debug.WriteLine("IP: " + ip);
            var cip = string.Format("https://api.iplocation.net/?ip={0}", ip);
            HttpClient wc = new HttpClient();
                       
            string json = await wc.GetStringAsync(cip);
            Location location = System.Text.Json.JsonSerializer.Deserialize<Location>(json);
            CountryN = location.country_name;
           
        }

        private async Task<string> GetIP()
        {
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync("https://api.ipify.org");
        }

        private void StartUp(object sender, EventArgs e)
        {
            CancelB.Click += CancelB_Click;
            LoginB.Click += LoginB_Click;
            LoadLocation();
            CountryL.DataBindings.Add("Text", this, "CountryN");
            LanguageBox.Items.AddRange(new object[] { "English", "Japanese" });
            LanguageBox.SelectedIndex = 0; 
            LanguageBox.SelectedIndexChanged += LanguageBox_Changed;
            LanguageBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
