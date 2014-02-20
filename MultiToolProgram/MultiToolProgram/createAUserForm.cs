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
    public partial class createAUserForm : Form
    {
        //@author xNovax
        //Variable Declaration
        String username;
        String password;
        String fileName;
        //End of Varible Declaration
        public createAUserForm()
        {
            InitializeComponent();
        }

        private void createAUserForm_Load(object sender, EventArgs e)
        {
            checkForText();
        }
        public void writeUserInfo()
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("userInformation.txt", true);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Close();
        }

        public void checkForText()
        {
            if ((usernameField.Text == (""))||(passwordField.Text == ("")))
            {
                createUserButton.Enabled = false;
            }
            else
            {
                createUserButton.Enabled = true;
            }
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            username = usernameField.Text;
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            password = passwordField.Text;
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            writeUserInfo();
        }
    }
}
