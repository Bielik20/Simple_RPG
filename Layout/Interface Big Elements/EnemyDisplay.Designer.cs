namespace Layout
{
    partial class EnemyDisplay
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
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.portraitBox = new System.Windows.Forms.PictureBox();
            this.expBox = new Layout.GameTextBox();
            this.expText = new Layout.GameTextBox();
            this.gameTextBox1 = new Layout.GameTextBox();
            this.maxHealthBox = new Layout.GameTextBox();
            this.currHealthBox = new Layout.GameTextBox();
            this.healthText = new Layout.GameTextBox();
            this.nameTextBox = new Layout.GameTextBox();
            this.backgroundPanel1 = new Layout.BackgroundPanel();
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.Red;
            this.healthBar.Location = new System.Drawing.Point(57, 702);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(255, 35);
            this.healthBar.TabIndex = 31;
            // 
            // portraitBox
            // 
            this.portraitBox.Location = new System.Drawing.Point(57, 248);
            this.portraitBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portraitBox.Name = "portraitBox";
            this.portraitBox.Size = new System.Drawing.Size(255, 369);
            this.portraitBox.TabIndex = 21;
            this.portraitBox.TabStop = false;
            // 
            // expBox
            // 
            this.expBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.expBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.expBox.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expBox.Location = new System.Drawing.Point(159, 177);
            this.expBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(153, 44);
            this.expBox.TabIndex = 40;
            // 
            // expText
            // 
            this.expText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.expText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.expText.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expText.Location = new System.Drawing.Point(57, 177);
            this.expText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expText.Name = "expText";
            this.expText.Size = new System.Drawing.Size(88, 44);
            this.expText.TabIndex = 33;
            this.expText.Text = "EXP:";
            this.expText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameTextBox1
            // 
            this.gameTextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gameTextBox1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameTextBox1.Location = new System.Drawing.Point(225, 645);
            this.gameTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameTextBox1.Name = "gameTextBox1";
            this.gameTextBox1.Size = new System.Drawing.Size(21, 44);
            this.gameTextBox1.TabIndex = 27;
            this.gameTextBox1.Text = "/";
            // 
            // maxHealthBox
            // 
            this.maxHealthBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.maxHealthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxHealthBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maxHealthBox.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxHealthBox.Location = new System.Drawing.Point(255, 645);
            this.maxHealthBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxHealthBox.Name = "maxHealthBox";
            this.maxHealthBox.Size = new System.Drawing.Size(57, 44);
            this.maxHealthBox.TabIndex = 26;
            // 
            // currHealthBox
            // 
            this.currHealthBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.currHealthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currHealthBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currHealthBox.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currHealthBox.Location = new System.Drawing.Point(159, 645);
            this.currHealthBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currHealthBox.Name = "currHealthBox";
            this.currHealthBox.Size = new System.Drawing.Size(57, 44);
            this.currHealthBox.TabIndex = 25;
            // 
            // healthText
            // 
            this.healthText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.healthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.healthText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.healthText.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.healthText.Location = new System.Drawing.Point(57, 645);
            this.healthText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.healthText.Name = "healthText";
            this.healthText.Size = new System.Drawing.Size(88, 44);
            this.healthText.TabIndex = 24;
            this.healthText.Text = "Health:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameTextBox.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(57, 63);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 44);
            this.nameTextBox.TabIndex = 22;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backgroundPanel1
            // 
            this.backgroundPanel1.BackgroundImage = global::Layout.Properties.Resources.old_paper;
            this.backgroundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backgroundPanel1.Name = "backgroundPanel1";
            this.backgroundPanel1.Size = new System.Drawing.Size(375, 923);
            this.backgroundPanel1.TabIndex = 41;
            // 
            // EnemyDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.expText);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.gameTextBox1);
            this.Controls.Add(this.maxHealthBox);
            this.Controls.Add(this.currHealthBox);
            this.Controls.Add(this.healthText);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.portraitBox);
            this.Controls.Add(this.backgroundPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnemyDisplay";
            this.Size = new System.Drawing.Size(375, 923);
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameTextBox expBox;
        private GameTextBox expText;
        private System.Windows.Forms.ProgressBar healthBar;
        private GameTextBox gameTextBox1;
        private GameTextBox maxHealthBox;
        private GameTextBox currHealthBox;
        private GameTextBox healthText;
        private GameTextBox nameTextBox;
        private System.Windows.Forms.PictureBox portraitBox;
        private BackgroundPanel backgroundPanel1;
    }
}
