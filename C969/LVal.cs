using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C969
{
    internal class LVal
    {
        private string user = "test";
        private string pass = "test";

        public void attemptLog(string iuser, string ipass, int language, LoginScreen loginscreen)
        {
            if(iuser != user || ipass != pass)
            {
                if (language == 0){ MessageBox.Show("The username and password do not match."); }
                else if (language == 1) { MessageBox.Show("ユーザー名とパスワードが一致しません。"); }
            }
            else
            {
                loginscreen.Hide();
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => loginscreen.Close();
                mainForm.Show();

            }

        }
    }
}
