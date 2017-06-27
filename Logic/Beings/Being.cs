using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;
using System.IO;

namespace Logic
{
    [DataContract]
    public class Being
    {
        #region Fields
        //-----------------------
        [DataMember]
        protected string name;
        public string Name
        {
            get { return name; }
        }
        //-----------------------
        protected Image portrait;
        public Image Portrait
        {
            get { return portrait; }
        }
        private string portraitName;
        [DataMember]
        public string PortraitName
        {
            get { return portraitName; }
            set 
            {
                portraitName = value;
                //WAŻNE!!! Wypadało by naprawić
                try { portrait = Image.FromFile(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Data\\Portraits\\" + portraitName); }
                catch (FileNotFoundException) { };
            }
        }
        //-----------------------
        [DataMember]
        protected double maxHealth;
        public double MaxHealth
        {
            get { return maxHealth; }
        }
        //-----------------------
        [DataMember]
        protected double currHealth;
        public double CurrHealth
        {
            set
            {
                if (currHealth <= 0) alive = false;
                currHealth = value; 
            }
            get { return currHealth; }
        }
        //-----------------------
        [DataMember]
        protected double gainHealth;
        public double GainHealth
        {
            get { return gainHealth; }
        }
        //-----------------------
        [DataMember]
        protected double maxMana;
        public double MaxMana
        {
            get { return maxMana; }
        }
        //-----------------------
        [DataMember]
        protected double currMana;
        public double CurrMana
        {
            set { currMana = value; }
            get { return currMana; }
        }
        //-----------------------
        [DataMember]
        protected double gainMana;
        public double GainMana
        {
            get { return gainMana; }
        }
        //-----------------------
        [DataMember]
        protected int level;
        public int Level
        {
            set { level = value; }
            get { return level; }
        }
        //-----------------------
        [DataMember]
        protected double maxExp;
        public double MaxExp
        {
            get { return maxExp; }
        }
        //-----------------------
        [DataMember]
        protected double currExp;
        public double CurrExp
        {
            get { return currExp; }
        }
        //-----------------------
        [DataMember]
        protected bool alive;
        //------------------------
        [DataMember]
        protected Ability[] abilities = new Ability[4];
        public Ability[] Abilities
        {
            get { return abilities; }
            //private set { abilities = value; }
        }
        //-----------------------
        #endregion

        public delegate int DiffDel(int value);
        public static DiffDel ModPlus;
        public static DiffDel ModMinus;

        public Being(string name, string portraitName, double maxHealth, double gainHealth, double maxMana, double gainMana, int level, double maxExp, Ability[] abilities)
        {
            this.name = name;
            this.portraitName = portraitName;
            this.maxHealth = maxHealth;
            this.currHealth = maxHealth;
            this.gainHealth = gainHealth;
            this.maxMana = maxMana;
            this.currMana = maxMana;
            this.gainMana = gainMana;
            this.level = level;
            this.maxExp = maxExp;
            this.currExp = 0;
            this.alive = true;
            this.abilities = abilities;
        }

        public void LevelCheck()
        {
            if (currExp >= maxExp)
            {
                currExp -= maxExp;
                this.LevelUp();
            }
        }

        public void LevelUp()
        {
            maxExp *= 2;
            level++;
            maxHealth += GainHealth;
            currHealth = maxHealth;
            maxMana += GainMana;
            currMana = maxMana;
        }

        public void OnKill(Being oponent)
        {
            currExp += oponent.MaxExp * 0.1;
            MessageBox.Show("Zabiłeś przeciwnika - Koniec gry");
            this.LevelCheck();
        }

        public void OnDeath()
        {
            MessageBox.Show("Umarłeś");
        }
    }
}
