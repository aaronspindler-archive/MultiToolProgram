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
    public partial class randomPasswordGeneratorForm : Form
    {
        //Variable Declaration
        decimal numberOfPasswords = 0;
        static int PASSWORD_LENGTH = 16;
        char[] password = new char[PASSWORD_LENGTH];
        char[] lowerCase = new char[26] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        char[] upperCase = new char[26] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        char[] specialCharacter = new char[15] {'!','@','#','$','%','^','&','*','_','-','+','=','<','>','?'};
        char[] numbers = new char[10] {'1','2','3','4','5','6','7','8','9','0'};
        //End of Variable Declaration

        public randomPasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void numberOfPasswordsUD_ValueChanged(object sender, EventArgs e)
        {
            numberOfPasswords = numberOfPasswordsUD.Value;
        }

        private void savePasswordsButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("");
            for (int i = 0; i <= numberOfPasswords; i++)
            {

            }
        }

        public void randomPassword()
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new rpOptions();
            frm.Show(this);
        }
    }
}
