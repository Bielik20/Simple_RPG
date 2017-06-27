namespace GameSer
{
    partial class AbilityView
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
            this.nameField = new System.Windows.Forms.RichTextBox();
            this.plusHealthField = new System.Windows.Forms.RichTextBox();
            this.plusManaField = new System.Windows.Forms.RichTextBox();
            this.damageHealthField = new System.Windows.Forms.RichTextBox();
            this.damageManaField = new System.Windows.Forms.RichTextBox();
            this.costHealthField = new System.Windows.Forms.RichTextBox();
            this.costManaField = new System.Windows.Forms.RichTextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(141, 38);
            this.nameField.Margin = new System.Windows.Forms.Padding(2);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(87, 18);
            this.nameField.TabIndex = 7;
            this.nameField.Text = "";
            // 
            // plusHealthField
            // 
            this.plusHealthField.Location = new System.Drawing.Point(141, 70);
            this.plusHealthField.Margin = new System.Windows.Forms.Padding(2);
            this.plusHealthField.Name = "plusHealthField";
            this.plusHealthField.Size = new System.Drawing.Size(87, 18);
            this.plusHealthField.TabIndex = 8;
            this.plusHealthField.Text = "";
            // 
            // plusManaField
            // 
            this.plusManaField.Location = new System.Drawing.Point(141, 99);
            this.plusManaField.Margin = new System.Windows.Forms.Padding(2);
            this.plusManaField.Name = "plusManaField";
            this.plusManaField.Size = new System.Drawing.Size(87, 18);
            this.plusManaField.TabIndex = 9;
            this.plusManaField.Text = "";
            // 
            // damageHealthField
            // 
            this.damageHealthField.Location = new System.Drawing.Point(141, 128);
            this.damageHealthField.Margin = new System.Windows.Forms.Padding(2);
            this.damageHealthField.Name = "damageHealthField";
            this.damageHealthField.Size = new System.Drawing.Size(87, 18);
            this.damageHealthField.TabIndex = 10;
            this.damageHealthField.Text = "";
            // 
            // damageManaField
            // 
            this.damageManaField.Location = new System.Drawing.Point(141, 159);
            this.damageManaField.Margin = new System.Windows.Forms.Padding(2);
            this.damageManaField.Name = "damageManaField";
            this.damageManaField.Size = new System.Drawing.Size(87, 18);
            this.damageManaField.TabIndex = 11;
            this.damageManaField.Text = "";
            // 
            // costHealthField
            // 
            this.costHealthField.Location = new System.Drawing.Point(141, 190);
            this.costHealthField.Margin = new System.Windows.Forms.Padding(2);
            this.costHealthField.Name = "costHealthField";
            this.costHealthField.Size = new System.Drawing.Size(87, 18);
            this.costHealthField.TabIndex = 12;
            this.costHealthField.Text = "";
            // 
            // costManaField
            // 
            this.costManaField.Location = new System.Drawing.Point(141, 220);
            this.costManaField.Margin = new System.Windows.Forms.Padding(2);
            this.costManaField.Name = "costManaField";
            this.costManaField.Size = new System.Drawing.Size(87, 18);
            this.costManaField.TabIndex = 13;
            this.costManaField.Text = "";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(274, 38);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(143, 199);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 14;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(46, 253);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 26);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(46, 283);
            this.replaceButton.Margin = new System.Windows.Forms.Padding(2);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(181, 26);
            this.replaceButton.TabIndex = 16;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(274, 253);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(141, 26);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "PlusHealth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "PlusMana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "DamageHealth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "DamageMana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "CostHealth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "CostMana";
            // 
            // serButton
            // 
            this.serButton.Location = new System.Drawing.Point(46, 324);
            this.serButton.Margin = new System.Windows.Forms.Padding(2);
            this.serButton.Name = "serButton";
            this.serButton.Size = new System.Drawing.Size(369, 30);
            this.serButton.TabIndex = 25;
            this.serButton.Text = "Serialize";
            this.serButton.UseVisualStyleBackColor = true;
            this.serButton.Click += new System.EventHandler(this.serButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(274, 283);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(141, 26);
            this.removeButton.TabIndex = 26;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AbilityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.serButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.costManaField);
            this.Controls.Add(this.costHealthField);
            this.Controls.Add(this.damageManaField);
            this.Controls.Add(this.damageHealthField);
            this.Controls.Add(this.plusManaField);
            this.Controls.Add(this.plusHealthField);
            this.Controls.Add(this.nameField);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AbilityView";
            this.Size = new System.Drawing.Size(461, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameField;
        private System.Windows.Forms.RichTextBox plusHealthField;
        private System.Windows.Forms.RichTextBox plusManaField;
        private System.Windows.Forms.RichTextBox damageHealthField;
        private System.Windows.Forms.RichTextBox damageManaField;
        private System.Windows.Forms.RichTextBox costHealthField;
        private System.Windows.Forms.RichTextBox costManaField;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button serButton;
        private System.Windows.Forms.Button removeButton;
    }
}
