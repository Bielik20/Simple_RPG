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
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace GameSer
{
    public partial class AbilityView : UserControl
    { 
        FileStream fs;
        string directory;
        DataContractSerializer ser = new DataContractSerializer(typeof(List<Ability>));
        BindingList<Ability> abilityList = new BindingList<Ability>();

        public AbilityView()
        {
            InitializeComponent();
            listBox.DisplayMember = "Name";
        }


        internal void StartUp()
        {
            directory = (System.Windows.Forms.Application.OpenForms["SerWindow"] as SerWindow).FolderPath + (System.Windows.Forms.Application.OpenForms["SerWindow"] as SerWindow).FileName;

            try
            {
                fs = new FileStream(directory, FileMode.Open);
                abilityList = new BindingList<Ability>((List<Ability>)ser.ReadObject(fs));
                fs.Close();
            }
            catch (DirectoryNotFoundException) { MessageBox.Show("Zły folder dostępu"); }
            catch (FileNotFoundException) { }
            catch (XmlException) { fs.Close(); }

            listBox.DataSource = abilityList;
        }

        private void AddAbility()
        {
            foreach (Ability i in abilityList)
            {
                if (i.Name == nameField.Text) { MessageBox.Show("Element o takiej nazwie już istnieje"); return; }
            }
            abilityList.Add(new Ability(nameField.Text, int.Parse(plusHealthField.Text), int.Parse(plusManaField.Text), int.Parse(damageHealthField.Text), int.Parse(damageManaField.Text), int.Parse(costHealthField.Text), int.Parse(costManaField.Text)));

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddAbility();
            }
            catch (FormatException) { MessageBox.Show("Zły fomrat danych"); }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddAbility();
                abilityList.RemoveAt(listBox.SelectedIndex);
            }
            catch (FormatException) { MessageBox.Show("Zły fomrat danych"); }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                abilityList.RemoveAt(listBox.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nameField.Text = abilityList[listBox.SelectedIndex].Name;
                this.plusHealthField.Text = abilityList[listBox.SelectedIndex].PlusHealth.ToString();
                this.plusManaField.Text = abilityList[listBox.SelectedIndex].PlusMana.ToString();
                this.damageHealthField.Text = abilityList[listBox.SelectedIndex].DamageHealth.ToString();
                this.damageManaField.Text = abilityList[listBox.SelectedIndex].DamageMana.ToString();
                this.costHealthField.Text = abilityList[listBox.SelectedIndex].CostHealth.ToString();
                this.costManaField.Text = abilityList[listBox.SelectedIndex].CostMana.ToString();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void serButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = XmlWriter.Create(directory, new XmlWriterSettings { Indent = true }))
                {
                    ser.WriteObject(writer, abilityList);
                }
            }
            catch (DirectoryNotFoundException) { MessageBox.Show("Zły folder dostępu"); }

            MessageBox.Show("Zakończono serializacje");
            
        }
    }
}
