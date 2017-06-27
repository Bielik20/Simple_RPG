using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSer
{
    public partial class SerWindow : Form
    {
        AbilityView abilityView = new AbilityView();
        BeingView beingView = new BeingView();
        public string FolderPath { get; private set; }
        public string FileName { get; private set; }
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        public SerWindow()
        {
            InitializeComponent();

            this.Controls.Add(this.abilityView);
            abilityView.Hide();
            this.Controls.Add(this.beingView);
            beingView.Hide();

            try
            {
                using (StreamReader outfile = new StreamReader("directory.txt"))
                {
                    FolderPath = outfile.ReadLine();
                }
            }
            catch (FileNotFoundException) { FolderPath = ""; }
        }

        private void HideAll()
        {
            this.abilityView.Hide();
            this.beingView.Hide();
        }
 

        private void setLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                FolderPath = folderBrowserDialog.SelectedPath ;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void SerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter outfile = new StreamWriter("directory.txt"))
            {
                outfile.Write(FolderPath);
            }
        }

        private void abilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            FileName = "\\Data\\Scripts\\abilities.xml";
            this.abilityView.StartUp();
            this.abilityView.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            FileName = "\\Data\\Scripts\\classes.xml";
            this.beingView.StartUp();
            this.beingView.Show();
        }

        private void enemiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAll();
            FileName = "\\Data\\Scripts\\enemies.xml";
            this.beingView.StartUp();
            this.beingView.Show();
        }
    }
}
