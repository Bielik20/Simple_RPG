using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layout;

namespace Game
{
    public partial class MenuLayout : UserControl
    {
        public MenuLayout()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).Close();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).optionsLayout.Show();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
           // (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).battleLayout.StartUp(new Logic.Player("Restokses"), new Logic.Enemy());
            this.Hide();
            (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).battleLayout.Show();
        }


    }
}
