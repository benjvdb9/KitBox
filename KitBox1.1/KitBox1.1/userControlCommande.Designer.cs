﻿namespace KitBox1._1
{
    partial class userControlCommande
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.armoireCol = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.corniereColor = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(897, 254);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 32);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "  120cm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(897, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 32);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "  42cm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::KitBox1._1.Properties.Resources.pg1_valider_bouton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(881, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 58);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // armoireCol
            // 
            this.armoireCol.BackColor = System.Drawing.Color.SandyBrown;
            this.armoireCol.BackgroundImage = global::KitBox1._1.Properties.Resources.changeColor;
            this.armoireCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.armoireCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armoireCol.Location = new System.Drawing.Point(996, 527);
            this.armoireCol.Name = "armoireCol";
            this.armoireCol.Size = new System.Drawing.Size(50, 50);
            this.armoireCol.TabIndex = 12;
            this.armoireCol.UseVisualStyleBackColor = false;
            this.armoireCol.Click += new System.EventHandler(this.formColor_Click);
            // 
            // corniereColor
            // 
            this.corniereColor.BackColor = System.Drawing.Color.Maroon;
            this.corniereColor.BackgroundImage = global::KitBox1._1.Properties.Resources.changeColor;
            this.corniereColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.corniereColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corniereColor.Location = new System.Drawing.Point(996, 389);
            this.corniereColor.Name = "corniereColor";
            this.corniereColor.Size = new System.Drawing.Size(50, 50);
            this.corniereColor.TabIndex = 13;
            this.corniereColor.UseVisualStyleBackColor = false;
            this.corniereColor.Click += new System.EventHandler(this.corniereColor_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1009, 473);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::KitBox1._1.Properties.Resources.interoggation_point;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(1067, 394);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 15;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // userControlCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::KitBox1._1.Properties.Resources.pg1_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.corniereColor);
            this.Controls.Add(this.armoireCol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Name = "userControlCommande";
            this.Size = new System.Drawing.Size(1236, 697);
            this.Load += new System.EventHandler(this.userControlCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button armoireCol;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button corniereColor;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnInfo;
    }
}
