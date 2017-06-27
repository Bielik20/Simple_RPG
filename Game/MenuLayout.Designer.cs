namespace Game
{
    partial class MenuLayout
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
            this.exitButton = new Layout.GameButton();
            this.optionsButton = new Layout.GameButton();
            this.newGameButton = new Layout.GameButton();
            this.backgroundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel1
            // 
            this.backgroundPanel1.BackgroundImage = global::Game.Properties.Resources.main_menu;
            this.backgroundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel1.Controls.Add(this.exitButton);
            this.backgroundPanel1.Controls.Add(this.optionsButton);
            this.backgroundPanel1.Controls.Add(this.newGameButton);
            this.backgroundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel1.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel1.Name = "backgroundPanel1";
            this.backgroundPanel1.Size = new System.Drawing.Size(1100, 700);
            this.backgroundPanel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.Location = new System.Drawing.Point(450, 480);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsButton.Location = new System.Drawing.Point(450, 400);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(200, 50);
            this.optionsButton.TabIndex = 1;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameButton.Location = new System.Drawing.Point(450, 320);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(200, 50);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // MenuLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel1);
            this.Name = "MenuLayout";
            this.Size = new System.Drawing.Size(1100, 700);
            this.backgroundPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Layout.BackgroundPanel backgroundPanel1;
        private Layout.GameButton newGameButton;
        private Layout.GameButton exitButton;
        private Layout.GameButton optionsButton;
    }
}
