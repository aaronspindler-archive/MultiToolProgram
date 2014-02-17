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
    //@author xNovax
    public partial class mainApplicationForm : Form
    {
        public mainApplicationForm()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new programInfo();
            frm.Show(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new optionsForm();
            frm.Show(this);
        }

        private void userSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new userSettingsForm();
            frm.Show(this);
        }

        private void randomPasswordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new rpForm();
            frm.Show(this);
        }
    }
}
