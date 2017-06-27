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
    public partial class BeingView : UserControl
    {
        FileStream fs;
        string beingDir;
        string abilityDir;
        string imageDir;
        string portraitName;

        DataContractSerializer beingSer = new DataContractSerializer(typeof(List<Being>));
        BindingList<Being> beingList;

        DataContractSerializer abilitySer = new DataContractSerializer(typeof(List<Ability>));
        List<Ability> abilityList;

        OpenFileDialog openFileDialog = new OpenFileDialog();


        public BeingView()
        {
            InitializeComponent();
            abilityListBox.DisplayMember = "Name";
            beingListBox.DisplayMember = "Name";
        }

        public void StartUp()
        {
            beingDir = (System.Windows.Forms.Application.OpenForms["SerWindow"] as SerWindow).FolderPath + (System.Windows.Forms.Application.OpenForms["SerWindow"] as SerWindow).FileName;
            abilityDir = (System.Windows.Forms.Application.OpenForms["SerWindow"] as SerWindow).FolderPath + "\\Data\\Scripts\\abilities.xml";
            imageDir = (System.Windows.Forms.Application.OpenForms["SerWindow"] as SerWindow).FolderPath + "\\Data\\Portraits\\";

            beingList = new BindingList<Being>();
            try
            {
                fs = new FileStream(beingDir, FileMode.Open);
                beingList = new BindingList<Being>((List<Being>)beingSer.ReadObject(fs));
                fs.Close();
            }
            catch (DirectoryNotFoundException) { MessageBox.Show("Zły folder dostępu"); }
            catch (FileNotFoundException) { }
            catch (XmlException) { fs.Close(); }
            beingListBox.DataSource = beingList;

            abilityList = new List<Ability>();
            try
            {
                fs = new FileStream(abilityDir, FileMode.Open);
                abilityList = (List<Ability>)abilitySer.ReadObject(fs);
                fs.Close();
            }
            catch (DirectoryNotFoundException) { MessageBox.Show("Zły folder dostępu"); }
            catch (FileNotFoundException) { }
            catch (XmlException) { fs.Close(); }
            abilityListBox.Items.Clear();
            abilityListBox.Items.AddRange(abilityList.ToArray());
        }

        private void AddBeing()
        {
            foreach (Being i in beingList)
                if (i.Name == nameField.Text) { MessageBox.Show("Element o takiej nazwie już istnieje"); return; }

            if (portraitName == null || abilityListBox.CheckedItems.OfType<Ability>().ToArray().Length == 0)
            { MessageBox.Show("Wszystkie pola muszą być uzupełnione"); return; }

            beingList.Add(new Being(
                                nameField.Text, portraitName,
                                double.Parse(maxHealthField.Text), double.Parse(gainHealthField.Text),
                                double.Parse(maxManaField.Text), double.Parse(gainManaField.Text),
                                int.Parse(levelField.Text), double.Parse(maxExpField.Text),
                                abilityListBox.CheckedItems.OfType<Ability>().ToArray()
                            ));

        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                portraitBox.Image = Image.FromFile(openFileDialog.FileName);
                portraitBox.SizeMode = PictureBoxSizeMode.Zoom;
                portraitName = Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void abilityListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && abilityListBox.CheckedItems.Count > 3)
                e.NewValue = CheckState.Unchecked;   
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try { AddBeing(); }
            catch (FormatException) { MessageBox.Show("Zły fomrat danych"); }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddBeing();
                beingList.RemoveAt(beingListBox.SelectedIndex);
            }
            catch (FormatException) { MessageBox.Show("Zły fomrat danych"); }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try { beingList.RemoveAt(beingListBox.SelectedIndex); }
            catch (ArgumentOutOfRangeException) { }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nameField.Text = beingList[beingListBox.SelectedIndex].Name;
                this.maxHealthField.Text = beingList[beingListBox.SelectedIndex].MaxHealth.ToString();
                this.gainHealthField.Text = beingList[beingListBox.SelectedIndex].GainHealth.ToString();
                this.maxManaField.Text = beingList[beingListBox.SelectedIndex].MaxMana.ToString();
                this.gainManaField.Text = beingList[beingListBox.SelectedIndex].GainMana.ToString();
                this.levelField.Text = beingList[beingListBox.SelectedIndex].Level.ToString();
                this.maxExpField.Text = beingList[beingListBox.SelectedIndex].MaxExp.ToString();

                this.portraitName = beingList[beingListBox.SelectedIndex].PortraitName;
                this.portraitBox.Image = Image.FromFile(this.imageDir + this.portraitName);

                Ability[] tempList = beingList[beingListBox.SelectedIndex].Abilities;
                foreach (int i in abilityListBox.CheckedIndices)
                    abilityListBox.SetItemChecked(i, false);
                for (int i = 0; i < abilityListBox.Items.Count; i++)
                    foreach (Ability j in tempList)
                        if (abilityList[i].Name == j.Name)
                        { abilityListBox.SetItemChecked(i, true); break; }
            }
            catch (ArgumentException) { MessageBox.Show("Something went wrong"); }

        }

        private void serButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = XmlWriter.Create(beingDir, new XmlWriterSettings { Indent = true }))
                {
                    beingSer.WriteObject(writer, beingList);
                }
            }
            catch (DirectoryNotFoundException) { MessageBox.Show("Zły folder dostępu"); }

            MessageBox.Show("Zakończono serializacje");
        }
    }
}
