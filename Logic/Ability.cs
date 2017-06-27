using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Logic
{
    [DataContract]
    public class Ability
    {
        [DataMember]
        public string Name { get; private set; }
        [DataMember]

        public int PlusHealth { get; private set; }
        [DataMember]
        public int PlusMana { get; private set; }

        [DataMember]
        public int DamageHealth { get; private set; }
        [DataMember]
        public int DamageMana { get; private set; }

        [DataMember]
        public int CostHealth { get; private set; }
        [DataMember]
        public int CostMana { get; private set; }

        public Ability(string name, int plusHealth, int plusMana, int damageHealth, int damageMana, int costHealth, int costMana)
        {
            this.Name = name;
            this.PlusHealth = plusHealth;
            this.PlusMana = plusMana;
            this.DamageHealth = damageHealth;
            this.DamageMana = damageMana;
            this.CostHealth = costHealth;
            this.CostMana = costMana;
        }

        public void Use(Being user, Being opponent)
        {
            if(CostHealth >= user.CurrHealth || CostMana > user.CurrMana)
            {
                MessageBox.Show("You have failed using ability.");
            }
            else
            {
                user.CurrHealth = user.CurrHealth + 0.2 * user.Level * (PlusHealth - CostHealth);
                user.CurrMana = user.CurrMana + 0.2 * user.Level * (PlusMana - CostMana);

                opponent.CurrHealth -= 0.2 * user.Level * DamageHealth;
                opponent.CurrMana -= 0.2 * user.Level * DamageMana;
            }
        }
    }
}
