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
        String[] password = new String[16];
        Boolean progressBarFull = false;
        Boolean errorOccured = false;
        //Array of characters that are allowed in the normal password type
        String[] normalPasswordArray = new String[52]{"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        //Array of characters that are allowed in the numbers password type
        String[] numbersPasswordArray = new String[62] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","1","2","3","4","5","6","7","8","9","0"};
        //Array of characters that are allowed in the special password type
        String[] specialPasswordArray = new String[77] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","1","2","3","4","5","6","7","8","9","0","!","@","#","$","%","^","&","*","_","-","+","=","<",">","?"};
        //Creates variables for which kind of password to use.
        Boolean normalPass;
        Boolean numberPass;
        Boolean specialCharPass;
        //Creates a random number generator
        Random gen = new Random(Guid.NewGuid().GetHashCode());
        //End of Variable Declaration

        public randomPasswordGeneratorForm()
        {
            InitializeComponent();
        }

        //Creates the random passwords
        public void randomPassword()
        {
            normalPass = Properties.Settings.Default.randomPassNormal;
            numberPass = Properties.Settings.Default.randomPassNumber;
            specialCharPass = Properties.Settings.Default.randomPassSpecialChar;
            
            for(int i = 0;i < PASSWORD_LENGTH;i++)
            {
                if (normalPass == true)
                {
                    int x = gen.Next(52);
                    password[i] = normalPasswordArray[x];
                }
                else
                {
                    if (numberPass == true)
                    {
                        int x = gen.Next(62);
                        password[i] = numbersPasswordArray[x];
                    }
                    else
                    {
                        if (specialCharPass == true)
                        {
                            int x = gen.Next(77);
                            password[i] = specialPasswordArray[x];
                        }
                    }
                }
            }
        }

        //Fills the progress bar
        public void fillProgress()
        {
            if ((progressBarFull == false)&&(errorOccured == false))
            {
                for (int i = 0; i < 101; i++)
                {
                    progressBar.Value = i;
                }
                progressBarFull = true;
            }
            else
            {
                emptyProgress();
                for (int i = 0; i < 101; i++)
                {
                    progressBar.Value = i;
                }
                progressBarFull = true;
            }
        }

        //Empties the progress bar
        public void emptyProgress()
        {
            progressBar.Value = 0;
            progressBarFull = false;
        }

        //Changes the value of the variable when the user changes it in the UI.
        private void numberOfPasswordsUD_ValueChanged(object sender, EventArgs e)
        {
            numberOfPasswords = numberOfPasswordsUD.Value;
        }

        //This code is run when a user clicks on the save password button.
        private void savePasswordsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < numberOfPasswords; i++)
                {
                    randomPassword();
                    for (int x = 0; x < PASSWORD_LENGTH; x++)
                    {
                        writer.Write(password[i]);
                    }
                    writer.WriteLine();
                }
                writer.Close();
                outputLabel.ForeColor = System.Drawing.Color.Black;
                outputLabel.Text = ("Your passwords have been saved to: " + saveFileDialog.FileName);
                fillProgress();
            }
            else
            {
                emptyProgress();
                outputLabel.ForeColor = System.Drawing.Color.Red;
                outputLabel.Text = ("An error has occured");
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Instead of closing the window it is hidden
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        //When the options menu item is clicked it will open up the options window for the random password generator program.
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new rpOptions();
            frm.Show(this);
        }
    }
}
