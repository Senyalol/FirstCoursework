namespace TheKyrsach
{
    partial class PlantForm
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
            this.CanselButton = new System.Windows.Forms.Button();
            this.AddPlantButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountI = new System.Windows.Forms.TextBox();
            this.NameI = new System.Windows.Forms.TextBox();
            this.BehavourI = new System.Windows.Forms.TextBox();
            this.SepciesI = new System.Windows.Forms.TextBox();
            this.ClassI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CanselButton.FlatAppearance.BorderSize = 2;
            this.CanselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanselButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanselButton.Location = new System.Drawing.Point(12, 407);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(133, 38);
            this.CanselButton.TabIndex = 0;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // AddPlantButton
            // 
            this.AddPlantButton.BackColor = System.Drawing.Color.Aqua;
            this.AddPlantButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPlantButton.Location = new System.Drawing.Point(509, 398);
            this.AddPlantButton.Name = "AddPlantButton";
            this.AddPlantButton.Size = new System.Drawing.Size(279, 47);
            this.AddPlantButton.TabIndex = 1;
            this.AddPlantButton.Text = "Добавить";
            this.AddPlantButton.UseVisualStyleBackColor = false;
            this.AddPlantButton.Click += new System.EventHandler(this.AddPlantButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Класс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Популяция вида";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Опишите поведение вида";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(467, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "Добавить растение";
            // 
            // CountI
            // 
            this.CountI.Location = new System.Drawing.Point(355, 222);
            this.CountI.Multiline = true;
            this.CountI.Name = "CountI";
            this.CountI.Size = new System.Drawing.Size(302, 27);
            this.CountI.TabIndex = 8;
            // 
            // NameI
            // 
            this.NameI.Location = new System.Drawing.Point(355, 67);
            this.NameI.Multiline = true;
            this.NameI.Name = "NameI";
            this.NameI.Size = new System.Drawing.Size(302, 27);
            this.NameI.TabIndex = 9;
            // 
            // BehavourI
            // 
            this.BehavourI.Location = new System.Drawing.Point(355, 276);
            this.BehavourI.Multiline = true;
            this.BehavourI.Name = "BehavourI";
            this.BehavourI.Size = new System.Drawing.Size(433, 96);
            this.BehavourI.TabIndex = 10;
            // 
            // SepciesI
            // 
            this.SepciesI.Location = new System.Drawing.Point(355, 171);
            this.SepciesI.Multiline = true;
            this.SepciesI.Name = "SepciesI";
            this.SepciesI.Size = new System.Drawing.Size(302, 27);
            this.SepciesI.TabIndex = 11;
            // 
            // ClassI
            // 
            this.ClassI.Location = new System.Drawing.Point(355, 117);
            this.ClassI.Multiline = true;
            this.ClassI.Name = "ClassI";
            this.ClassI.Size = new System.Drawing.Size(302, 27);
            this.ClassI.TabIndex = 12;
            // 
            // PlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.ControlBox = false;
            this.Controls.Add(this.ClassI);
            this.Controls.Add(this.SepciesI);
            this.Controls.Add(this.BehavourI);
            this.Controls.Add(this.NameI);
            this.Controls.Add(this.CountI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPlantButton);
            this.Controls.Add(this.CanselButton);
            this.Name = "PlantForm";
            this.Text = "PlantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button AddPlantButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CountI;
        private System.Windows.Forms.TextBox NameI;
        private System.Windows.Forms.TextBox BehavourI;
        private System.Windows.Forms.TextBox SepciesI;
        private System.Windows.Forms.TextBox ClassI;
    }
}