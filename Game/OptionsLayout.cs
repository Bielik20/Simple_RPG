using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Game
{
    public partial class OptionsLayout : UserControl
    {
        public OptionsLayout()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).menuLayout.Show();
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Options.SetMedium();
        }
    }
}
