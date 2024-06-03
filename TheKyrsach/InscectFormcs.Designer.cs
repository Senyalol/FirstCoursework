namespace TheKyrsach
{
    partial class InscectFormcs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CansellButton = new System.Windows.Forms.Button();
            this.InsectAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountI = new System.Windows.Forms.TextBox();
            this.BehaviourI = new System.Windows.Forms.TextBox();
            this.ClassI = new System.Windows.Forms.TextBox();
            this.SpeciesI = new System.Windows.Forms.TextBox();
            this.NameI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CansellButton
            // 
            this.CansellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CansellButton.FlatAppearance.BorderSize = 2;
            this.CansellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CansellButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CansellButton.Location = new System.Drawing.Point(12, 407);
            this.CansellButton.Name = "CansellButton";
            this.CansellButton.Size = new System.Drawing.Size(133, 38);
            this.CansellButton.TabIndex = 0;
            this.CansellButton.Text = "Отмена";
            this.CansellButton.UseVisualStyleBackColor = false;
            this.CansellButton.Click += new System.EventHandler(this.CansellButton_Click);
            // 
            // InsectAddButton
            // 
            this.InsectAddButton.BackColor = System.Drawing.Color.Aqua;
            this.InsectAddButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsectAddButton.Location = new System.Drawing.Point(509, 398);
            this.InsectAddButton.Name = "InsectAddButton";
            this.InsectAddButton.Size = new System.Drawing.Size(279, 47);
            this.InsectAddButton.TabIndex = 1;
            this.InsectAddButton.Text = "Добавить";
            this.InsectAddButton.UseVisualStyleBackColor = false;
            this.InsectAddButton.Click += new System.EventHandler(this.InsectAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Класс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Колличество особей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Опишите поведение вида";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(447, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "Добавить насекомое";
            // 
            // CountI
            // 
            this.CountI.Location = new System.Drawing.Point(355, 214);
            this.CountI.Multiline = true;
            this.CountI.Name = "CountI";
            this.CountI.Size = new System.Drawing.Size(302, 27);
            this.CountI.TabIndex = 8;
            // 
            // BehaviourI
            // 
            this.BehaviourI.Location = new System.Drawing.Point(355, 264);
            this.BehaviourI.Multiline = true;
            this.BehaviourI.Name = "BehaviourI";
            this.BehaviourI.Size = new System.Drawing.Size(433, 96);
            this.BehaviourI.TabIndex = 9;
            // 
            // ClassI
            // 
            this.ClassI.Location = new System.Drawing.Point(355, 112);
            this.ClassI.Multiline = true;
            this.ClassI.Name = "ClassI";
            this.ClassI.Size = new System.Drawing.Size(302, 27);
            this.ClassI.TabIndex = 10;
            // 
            // SpeciesI
            // 
            this.SpeciesI.Location = new System.Drawing.Point(355, 163);
            this.SpeciesI.Multiline = true;
            this.SpeciesI.Name = "SpeciesI";
            this.SpeciesI.Size = new System.Drawing.Size(302, 27);
            this.SpeciesI.TabIndex = 11;
            // 
            // NameI
            // 
            this.NameI.Location = new System.Drawing.Point(355, 64);
            this.NameI.Multiline = true;
            this.NameI.Name = "NameI";
            this.NameI.Size = new System.Drawing.Size(302, 27);
            this.NameI.TabIndex = 12;
            // 
            // InscectFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.ControlBox = false;
            this.Controls.Add(this.NameI);
            this.Controls.Add(this.SpeciesI);
            this.Controls.Add(this.ClassI);
            this.Controls.Add(this.BehaviourI);
            this.Controls.Add(this.CountI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsectAddButton);
            this.Controls.Add(this.CansellButton);
            this.Name = "InscectFormcs";
            this.Text = "InscectFormcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CansellButton;
        private System.Windows.Forms.Button InsectAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CountI;
        private System.Windows.Forms.TextBox BehaviourI;
        private System.Windows.Forms.TextBox ClassI;
        private System.Windows.Forms.TextBox SpeciesI;
        private System.Windows.Forms.TextBox NameI;
    }
}