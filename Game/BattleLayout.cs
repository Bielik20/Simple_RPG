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
    public partial class BattleLayout : UserControl
    {
        Being player;
        Being enemy;

        public BattleLayout()
        {
            InitializeComponent();
        }

        //private void exitButton_Click(object sender, EventArgs e)
        //{
        //    (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).Close();
        //}

        public void StartUp(Being player, Being enemy)
        {
            this.player = player;
            this.enemy = enemy;

            this.firstRadio.Text = player.Abilities[1].Name;

            this.playerDisplay.StartUp(player.Portrait, player.Name, player.Level, player.CurrExp, player.MaxExp, player.CurrHealth, player.MaxHealth, player.CurrMana, player.MaxMana);
            this.enemyDisplay.StartUp(player.Portrait, player.Name, player.Level, player.CurrExp, player.MaxExp, player.CurrHealth, player.MaxHealth, player.CurrMana, player.MaxMana);
        }

        public void UpdateLayout()
        {
            this.playerDisplay.Update(player.Level, player.CurrExp, player.MaxExp, player.CurrHealth, player.MaxHealth, player.CurrMana, player.MaxMana);
            this.enemyDisplay.Update(player.Level, player.CurrExp, player.MaxExp, player.CurrHealth, player.MaxHealth, player.CurrMana, player.MaxMana);
        }


    }
}
