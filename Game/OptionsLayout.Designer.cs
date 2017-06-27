namespace Game
{
    partial class OptionsLayout
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundPanel1 = new Layout.BackgroundPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.difficutlyText = new Layout.GameTextBox();
            this.mediumRadioButton = new Layout.GameRadioButton();
            this.hardRadioButton = new Layout.GameRadioButton();
            this.easyRadioButton = new Layout.GameRadioButton();
            this.okButton = new Layout.GameButton();
            this.backgroundPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel1
            // 
            this.backgroundPanel1.BackgroundImage = global::Game.Properties.Resources.options_background;
            this.backgroundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel1.Controls.Add(this.panel1);
            this.backgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel1.Name = "backgroundPanel1";
            this.backgroundPanel1.Size = new System.Drawing.Size(1100, 700);
            this.backgroundPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.easyRadioButton);
            this.panel1.Controls.Add(this.hardRadioButton);
            this.panel1.Controls.Add(this.mediumRadioButton);
            this.panel1.Controls.Add(this.difficutlyText);
            this.panel1.Location = new System.Drawing.Point(79, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 330);
            this.panel1.TabIndex = 0;
            // 
            // difficutlyText
            // 
            this.difficutlyText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.difficutlyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.difficutlyText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.difficutlyText.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficutlyText.Location = new System.Drawing.Point(66, 32);
            this.difficutlyText.Name = "difficutlyText";
            this.difficutlyText.Size = new System.Drawing.Size(100, 30);
            this.difficutlyText.TabIndex = 0;
            this.difficutlyText.Text = "Difficulty";
            this.difficutlyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Checked = true;
            this.mediumRadioButton.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mediumRadioButton.Location = new System.Drawing.Point(66, 130);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(82, 26);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hardRadioButton.Location = new System.Drawing.Point(66, 81);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(61, 26);
            this.hardRadioButton.TabIndex = 2;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easyRadioButton.Location = new System.Drawing.Point(66, 181);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(57, 26);
            this.easyRadioButton.TabIndex = 3;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.Location = new System.Drawing.Point(66, 241);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 50);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // OptionsLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel1);
            this.Name = "OptionsLayout";
            this.Size = new System.Drawing.Size(1100, 700);
            this.backgroundPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Layout.BackgroundPanel backgroundPanel1;
        private System.Windows.Forms.Panel panel1;
        private Layout.GameButton okButton;
        private Layout.GameRadioButton easyRadioButton;
        private Layout.GameRadioButton hardRadioButton;
        private Layout.GameRadioButton mediumRadioButton;
        private Layout.GameTextBox difficutlyText;
    }
}
