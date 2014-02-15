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
        //@author xNovax
        //Variable Declaration
        decimal numberOfPasswords = 0;
        static int PASSWORD_LENGTH = 16;
        char[] password = new char[PASSWORD_LENGTH];
        //Array of characters that are allowed in the normal password type
        char[] normalPasswordArray = new char[52]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        //Array of characters that are allowed in the numbers password type
        char[] numbersPasswordArray = new char[62] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        //Array of characters that are allowed in the special password type
        char[] specialPasswordArray = new char[77] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0','!','@','#','$','%','^','&','*','_','-','+','=','<','>','?'};
        //End of Variable Declaration

        public randomPasswordGeneratorForm()
        {
            InitializeComponent();
        }

        public void randomPassword()
        {

        }

        private void numberOfPasswordsUD_ValueChanged(object sender, EventArgs e)
        {
            numberOfPasswords = numberOfPasswordsUD.Value;
        }

        private void savePasswordsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i <= numberOfPasswords; i++)
                {

                }
            }
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
