using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Game
{
    public partial class MainForm : Form
    {
        public MenuLayout menuLayout = new MenuLayout();
        public OptionsLayout optionsLayout = new OptionsLayout();
        public BattleLayout battleLayout = new BattleLayout();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //----------menuLayout------------
            this.Controls.Add(this.menuLayout);
            menuLayout.Show();

            //---------optionsLayout----------
            this.Controls.Add(this.optionsLayout);
            Options.SetMedium();
            optionsLayout.Hide();

            //----------battleLayout----------
            this.Controls.Add(this.battleLayout);
            battleLayout.Hide();

        }
    }
}
