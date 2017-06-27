namespace GameSer
{
    partial class BeingView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.portraitBox = new System.Windows.Forms.PictureBox();
            this.abilityListBox = new System.Windows.Forms.CheckedListBox();
            this.maxHealthField = new System.Windows.Forms.TextBox();
            this.gainHealthField = new System.Windows.Forms.TextBox();
            this.maxManaField = new System.Windows.Forms.TextBox();
            this.gainManaField = new System.Windows.Forms.TextBox();
            this.levelField = new System.Windows.Forms.TextBox();
            this.maxExpField = new System.Windows.Forms.TextBox();
            this.beingListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.serButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Portrait";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaxHealth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GainHealth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MaxMana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "GainMana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "MaxExp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Abilities (4 to choose)";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(110, 36);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 9;
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(307, 34);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(91, 23);
            this.imageButton.TabIndex = 10;
            this.imageButton.Text = "Choose";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // portraitBox
            // 
            this.portraitBox.Location = new System.Drawing.Point(255, 74);
            this.portraitBox.Name = "portraitBox";
            this.portraitBox.Size = new System.Drawing.Size(141, 200);
            this.portraitBox.TabIndex = 11;
            this.portraitBox.TabStop = false;
            // 
            // abilityListBox
            // 
            this.abilityListBox.FormattingEnabled = true;
            this.abilityListBox.Location = new System.Drawing.Point(440, 74);
            this.abilityListBox.Name = "abilityListBox";
            this.abilityListBox.Size = new System.Drawing.Size(154, 199);
            this.abilityListBox.TabIndex = 12;
            this.abilityListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.abilityListBox_ItemCheck);
            // 
            // maxHealthField
            // 
            this.maxHealthField.Location = new System.Drawing.Point(110, 81);
            this.maxHealthField.Name = "maxHealthField";
            this.maxHealthField.Size = new System.Drawing.Size(100, 20);
            this.maxHealthField.TabIndex = 13;
            // 
            // gainHealthField
            // 
            this.gainHealthField.Location = new System.Drawing.Point(110, 112);
            this.gainHealthField.Name = "gainHealthField";
            this.gainHealthField.Size = new System.Drawing.Size(100, 20);
            this.gainHealthField.TabIndex = 14;
            // 
            // maxManaField
            // 
            this.maxManaField.Location = new System.Drawing.Point(110, 153);
            this.maxManaField.Name = "maxManaField";
            this.maxManaField.Size = new System.Drawing.Size(100, 20);
            this.maxManaField.TabIndex = 15;
            // 
            // gainManaField
            // 
            this.gainManaField.Location = new System.Drawing.Point(110, 182);
            this.gainManaField.Name = "gainManaField";
            this.gainManaField.Size = new System.Drawing.Size(100, 20);
            this.gainManaField.TabIndex = 16;
            // 
            // levelField
            // 
            this.levelField.Location = new System.Drawing.Point(110, 227);
            this.levelField.Name = "levelField";
            this.levelField.Size = new System.Drawing.Size(100, 20);
            this.levelField.TabIndex = 17;
            // 
            // maxExpField
            // 
            this.maxExpField.Location = new System.Drawing.Point(110, 253);
            this.maxExpField.Name = "maxExpField";
            this.maxExpField.Size = new System.Drawing.Size(100, 20);
            this.maxExpField.TabIndex = 18;
            // 
            // beingListBox
            // 
            this.beingListBox.FormattingEnabled = true;
            this.beingListBox.Location = new System.Drawing.Point(637, 70);
            this.beingListBox.Name = "beingListBox";
            this.beingListBox.Size = new System.Drawing.Size(156, 316);
            this.beingListBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Being List";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 296);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 33);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(183, 296);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(128, 33);
            this.replaceButton.TabIndex = 22;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(472, 296);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(122, 33);
            this.loadButton.TabIndex = 24;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // serButton
            // 
            this.serButton.Location = new System.Drawing.Point(39, 344);
            this.serButton.Name = "serButton";
            this.serButton.Size = new System.Drawing.Size(555, 40);
            this.serButton.TabIndex = 25;
            this.serButton.Text = "Serialize";
            this.serButton.UseVisualStyleBackColor = true;
            this.serButton.Click += new System.EventHandler(this.serButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(328, 296);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(125, 33);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // BeingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.serButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.beingListBox);
            this.Controls.Add(this.maxExpField);
            this.Controls.Add(this.levelField);
            this.Controls.Add(this.gainManaField);
            this.Controls.Add(this.maxManaField);
            this.Controls.Add(this.gainHealthField);
            this.Controls.Add(this.maxHealthField);
            this.Controls.Add(this.abilityListBox);
            this.Controls.Add(this.portraitBox);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BeingView";
            this.Size = new System.Drawing.Size(844, 439);
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.PictureBox portraitBox;
        private System.Windows.Forms.CheckedListBox abilityListBox;
        private System.Windows.Forms.TextBox maxHealthField;
        private System.Windows.Forms.TextBox gainHealthField;
        private System.Windows.Forms.TextBox maxManaField;
        private System.Windows.Forms.TextBox gainManaField;
        private System.Windows.Forms.TextBox levelField;
        private System.Windows.Forms.TextBox maxExpField;
        private System.Windows.Forms.ListBox beingListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button serButton;
        private System.Windows.Forms.Button removeButton;
    }
}
