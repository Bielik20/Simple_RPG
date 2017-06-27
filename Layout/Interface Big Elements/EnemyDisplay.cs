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
    public partial class EnemyDisplay : UserControl
    {
        public EnemyDisplay()
        {
            InitializeComponent();
        }

        public void StartUp(Image portrait, string name, int dmg, int exp, int currHealth, int maxHealth)
        {
            this.portraitBox.Image = portrait;
            this.nameTextBox.Text = name;
            this.Update( dmg, exp, currHealth, maxHealth);
        }

        public void Update( int dmg, int exp, int currHealth, int maxHealth)
        {
            this.expBox.Text = exp.ToString();
            this.currHealthBox.Text = currHealth.ToString();
            this.maxHealthBox.Text = maxHealth.ToString();

            this.healthBar.Maximum = maxHealth;
            this.healthBar.Value = currHealth;
        }
    }
}
