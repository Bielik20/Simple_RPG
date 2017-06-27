namespace Game
{
    partial class BattleLayout
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
            this.playerDisplay = new Layout.BeingDisplay();
            this.enemyDisplay = new Layout.BeingDisplay();
            this.abilitiesPanel = new System.Windows.Forms.Panel();
            this.firstRadio = new Layout.GameRadioButton();
            this.secondRadio = new Layout.GameRadioButton();
            this.thirdRadio = new Layout.GameRadioButton();
            this.forthRadio = new Layout.GameRadioButton();
            this.useButton = new Layout.GameButton();
            this.backgroundPanel1.SuspendLayout();
            this.abilitiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel1
            // 
            this.backgroundPanel1.BackgroundImage = global::Game.Properties.Resources.battle_background;
            this.backgroundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel1.Controls.Add(this.abilitiesPanel);
            this.backgroundPanel1.Controls.Add(this.enemyDisplay);
            this.backgroundPanel1.Controls.Add(this.playerDisplay);
            this.backgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backgroundPanel1.Name = "backgroundPanel1";
            this.backgroundPanel1.Size = new System.Drawing.Size(1100, 700);
            this.backgroundPanel1.TabIndex = 0;
            // 
            // playerDisplay
            // 
            this.playerDisplay.Location = new System.Drawing.Point(50, 39);
            this.playerDisplay.Name = "playerDisplay";
            this.playerDisplay.Size = new System.Drawing.Size(250, 600);
            this.playerDisplay.TabIndex = 0;
            // 
            // enemyDisplay
            // 
            this.enemyDisplay.Location = new System.Drawing.Point(794, 39);
            this.enemyDisplay.Name = "enemyDisplay";
            this.enemyDisplay.Size = new System.Drawing.Size(250, 600);
            this.enemyDisplay.TabIndex = 1;
            // 
            // abilitiesPanel
            // 
            this.abilitiesPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.abilitiesPanel.Controls.Add(this.useButton);
            this.abilitiesPanel.Controls.Add(this.forthRadio);
            this.abilitiesPanel.Controls.Add(this.thirdRadio);
            this.abilitiesPanel.Controls.Add(this.secondRadio);
            this.abilitiesPanel.Controls.Add(this.firstRadio);
            this.abilitiesPanel.Location = new System.Drawing.Point(403, 288);
            this.abilitiesPanel.Name = "abilitiesPanel";
            this.abilitiesPanel.Size = new System.Drawing.Size(292, 326);
            this.abilitiesPanel.TabIndex = 2;
            // 
            // firstRadio
            // 
            this.firstRadio.AutoSize = true;
            this.firstRadio.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstRadio.Location = new System.Drawing.Point(66, 35);
            this.firstRadio.Name = "firstRadio";
            this.firstRadio.Size = new System.Drawing.Size(91, 26);
            this.firstRadio.TabIndex = 0;
            this.firstRadio.TabStop = true;
            this.firstRadio.Text = "firstRadio";
            this.firstRadio.UseVisualStyleBackColor = true;
            // 
            // secondRadio
            // 
            this.secondRadio.AutoSize = true;
            this.secondRadio.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondRadio.Location = new System.Drawing.Point(66, 90);
            this.secondRadio.Name = "secondRadio";
            this.secondRadio.Size = new System.Drawing.Size(151, 26);
            this.secondRadio.TabIndex = 1;
            this.secondRadio.TabStop = true;
            this.secondRadio.Text = "gameRadioButton2";
            this.secondRadio.UseVisualStyleBackColor = true;
            // 
            // thirdRadio
            // 
            this.thirdRadio.AutoSize = true;
            this.thirdRadio.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirdRadio.Location = new System.Drawing.Point(66, 144);
            this.thirdRadio.Name = "thirdRadio";
            this.thirdRadio.Size = new System.Drawing.Size(151, 26);
            this.thirdRadio.TabIndex = 2;
            this.thirdRadio.TabStop = true;
            this.thirdRadio.Text = "gameRadioButton3";
            this.thirdRadio.UseVisualStyleBackColor = true;
            // 
            // forthRadio
            // 
            this.forthRadio.AutoSize = true;
            this.forthRadio.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forthRadio.Location = new System.Drawing.Point(66, 194);
            this.forthRadio.Name = "forthRadio";
            this.forthRadio.Size = new System.Drawing.Size(151, 26);
            this.forthRadio.TabIndex = 3;
            this.forthRadio.TabStop = true;
            this.forthRadio.Text = "gameRadioButton4";
            this.forthRadio.UseVisualStyleBackColor = true;
            // 
            // useButton
            // 
            this.useButton.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.useButton.Location = new System.Drawing.Point(47, 246);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(200, 50);
            this.useButton.TabIndex = 4;
            this.useButton.Text = "Use";
            this.useButton.UseVisualStyleBackColor = true;
            // 
            // BattleLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BattleLayout";
            this.Size = new System.Drawing.Size(1100, 700);
            this.backgroundPanel1.ResumeLayout(false);
            this.abilitiesPanel.ResumeLayout(false);
            this.abilitiesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Layout.BackgroundPanel backgroundPanel1;
        private Layout.BeingDisplay enemyDisplay;
        private Layout.BeingDisplay playerDisplay;
        private System.Windows.Forms.Panel abilitiesPanel;
        private Layout.GameButton useButton;
        private Layout.GameRadioButton forthRadio;
        private Layout.GameRadioButton thirdRadio;
        private Layout.GameRadioButton secondRadio;
        private Layout.GameRadioButton firstRadio;
    }
}
