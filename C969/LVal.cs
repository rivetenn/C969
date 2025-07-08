using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C969
{
    public class LVal
    {
        bool vallog;
        public void attemptLog(string iuser, string ipass, int language, LoginScreen loginscreen)
        {
            vallog = SQLStuff.CheckUser(iuser,ipass);
            LoginTracker(iuser, vallog);
            if (!vallog)
            {
                if (language == 0) { MessageBox.Show("The username and password do not match."); }
                else if (language == 1) { MessageBox.Show("ユーザー名とパスワードが一致しません。"); }
            }
            else
            {
                loginscreen.Hide();
                MainForm mainform = new MainForm();
                mainform.FormClosed += (s, args) => loginscreen.Close();
                mainform.Show();

            }


        }

    static void LoginTracker(string iuser, bool val)
        {   
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string logDir = Path.Combine(projectRoot, "Logs");
            Directory.CreateDirectory(logDir);
            string logPath = Path.Combine(logDir, "Login_History.txt");
            using (StreamWriter writer = new StreamWriter(logPath, append: true))
            {
                Debug.WriteLine("Saving to: " + Path.GetFullPath("Login_History.txt"));
                if (val){
                    writer.WriteLine($"{iuser} has logged in at {DateTime.UtcNow} UTC");
                }
                else
                {
                    writer.WriteLine($"{iuser} failed log in at {DateTime.UtcNow} UTC");
                }


            }
        }
        
    }
}
