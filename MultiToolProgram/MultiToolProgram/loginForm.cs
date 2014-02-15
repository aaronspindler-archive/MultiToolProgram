using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiToolProgram
{
    public partial class loginForm : Form
    {
        //@author xNovax
        //Variable Declaration Start
        String username;
        String password;
        Boolean firstLoad = Properties.Settings.Default.firstLoad;
        Boolean loginSuccessful;
        Boolean usernameHasText = false;
        Boolean passwordHasText = false;
        //End of Variable Declaration

        public loginForm()
        {
            InitializeComponent();
        }

        public void checkForText()
        {
           if ((usernameField.Text == (""))||(passwordField.Text == ("")))
           {
               loginButton.Enabled = false;
               usernameHasText = false;
               passwordHasText = false;
           }
           else
           {
               loginButton.Enabled = true;
               usernameHasText = true;
               passwordHasText = true;
           }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (firstLoad == true)
            {
                var frm = new createYourUserForm();
                frm.Show(this);
                firstLoad = false;
            }
            else
            {
                firstLoad = false;
            }
            Properties.Settings.Default.firstLoad = firstLoad;
            Properties.Settings.Default.Save();
            checkForText();
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            username = usernameField.Text;
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Save();
            checkForText();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            password = passwordField.Text;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Save();
            checkForText();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            checkForText();
            Console.WriteLine(username);
            Console.WriteLine(password);
            if ((username.Equals("xNovax"))&&(password.Equals("password")))
            {
                loginSuccessful = true;
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Login Failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                loginSuccessful = false;
            }
            if (loginSuccessful == true)
            {
                var frm = new mainApplicationForm();
                frm.Show(this);
            }
        }
    }
}
