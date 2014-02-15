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
    public partial class rpOptions : Form
    {
        //@author xNovax
        //Variable Declaration
        Boolean normalPass;
        Boolean numberPass;
        Boolean specialCharPass;
        //End of Variable Declaration
        public rpOptions()
        {
            InitializeComponent();
        }

        public void enableDisable()
        {
            //Checks to see if the normalPass variable is true. If it is true set its check box to checked and disable all other check boxes.
            if (normalPass == true)
            {
                normalPassCheckbox.Checked = true;
                numberPassCheckbox.Checked = false;
                specialCharCheckBox.Checked = false;

                normalPassCheckbox.Enabled = true;
                numberPassCheckbox.Enabled = false;
                specialCharCheckBox.Enabled = false;

                normalPass = true;
                numberPass = false;
                specialCharPass = false;
            }
            else
            {
                //Checks to see if the numberPass variable is true. If it is true set its check box to checked and disable all other check boxes.
                if (numberPass == true)
                {
                    normalPassCheckbox.Checked = false;
                    numberPassCheckbox.Checked = true;
                    specialCharCheckBox.Checked = false;

                    normalPassCheckbox.Enabled = false;
                    numberPassCheckbox.Enabled = true;
                    specialCharCheckBox.Enabled = false;

                    normalPass = false;
                    numberPass = true;
                    specialCharPass = false;
                }
                else
                {
                    //Checks to see if the specialCharPass variable is true. If it is true set its check box to checked and disable all other check boxes.
                    if (specialCharPass == true)
                    {
                        normalPassCheckbox.Checked = false;
                        numberPassCheckbox.Checked = false;
                        specialCharCheckBox.Checked = true;

                        normalPassCheckbox.Enabled = false;
                        numberPassCheckbox.Enabled = false;
                        specialCharCheckBox.Enabled = true;

                        normalPass = false;
                        numberPass = false;
                        specialCharPass = true;
                    }
                    //If none of the options above result in a true it will set all of the boxes to unchecked and enable all check boxes.
                    else
                    {
                        normalPassCheckbox.Checked = false;
                        numberPassCheckbox.Checked = false;
                        specialCharCheckBox.Checked = false;

                        normalPassCheckbox.Enabled = true;
                        numberPassCheckbox.Enabled = true;
                        specialCharCheckBox.Enabled = true;

                        normalPass = false;
                        numberPass = false;
                        specialCharPass = false;
                    }
                }
            }
        }
        //This is ran when the window is loaded
        private void rpOptions_Load(object sender, EventArgs e)
        {
            normalPass = Properties.Settings.Default.randomPassNormal;
            numberPass = Properties.Settings.Default.randomPassNumber;
            specialCharPass = Properties.Settings.Default.randomPassSpecialChar;
            enableDisable();
        }

        //Runs this code when the form is closing
        private void rpOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.randomPassNormal = normalPass;
            Properties.Settings.Default.randomPassNumber = numberPass;
            Properties.Settings.Default.randomPassSpecialChar = specialCharPass;
            Properties.Settings.Default.Save();
        }

        //Checks to see if the normalPassCheckbox's state has changed
        private void normalPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (normalPassCheckbox.Checked == true)
            {
                normalPass = true;
            }
            else
            {
                normalPass = false;
            }
            enableDisable();
        }

        //Checks to see if the numberPassCheckbox's state has changed
        private void numberPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (numberPassCheckbox.Checked == true)
            {
                numberPass = true;
            }
            else
            {
                numberPass = false;
            }
            enableDisable();
        }

        //Checks to see if the specialCharCheckbox's state has changed
        private void specialCharCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (specialCharCheckBox.Checked == true)
            {
                specialCharPass = true;
            }
            else
            {
                specialCharPass = false;
            }
            enableDisable();
        }
    }
}
