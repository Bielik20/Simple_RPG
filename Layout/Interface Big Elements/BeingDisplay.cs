using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    public partial class BeingDisplay : UserControl
    {
        public BeingDisplay()
        {
            InitializeComponent();
        }

        public void StartUp(Image portrait, string name, int lvl, double currExp, double maxExp, double currHealth, double maxHealth, double currMana, double maxMana)
        {
            this.portraitBox.Image = portrait;
            this.nameTextBox.Text = name;
            this.Update(lvl, currExp, maxExp, currHealth, maxHealth, currMana, maxMana);
        }

        public void Update(int lvl, double currExp, double maxExp, double currHealth, double maxHealth, double currMana, double maxMana)
        {
            this.lvlBox.Text = lvl.ToString();
            this.currExpBox.Text = currExp.ToString();
            this.maxExpBox.Text = maxExp.ToString();
            this.currHealthBox.Text = currHealth.ToString();
            this.maxHealthBox.Text = maxHealth.ToString();
            this.currManaBox.Text = currMana.ToString();
            this.maxManaBox.Text = maxMana.ToString();

            this.healthBar.Maximum = (int)maxHealth;
            this.healthBar.Value = (int)currHealth;

            this.manaBar.Maximum = (int)maxMana;
            this.manaBar.Value = (int)currMana;
        }


    }
}
