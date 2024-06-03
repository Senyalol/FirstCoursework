namespace TheKyrsach
{
    partial class ChooseForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.NameT = new System.Windows.Forms.Label();
            this.ClassT = new System.Windows.Forms.Label();
            this.speciesT = new System.Windows.Forms.Label();
            this.countT = new System.Windows.Forms.Label();
            this.behaviourT = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.ClassText = new System.Windows.Forms.TextBox();
            this.SpeciesText = new System.Windows.Forms.TextBox();
            this.CountText = new System.Windows.Forms.TextBox();
            this.BehaviourText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.AutoSize = true;
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AcceptButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(12, 309);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(200, 70);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Изменить";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // NameT
            // 
            this.NameT.AutoSize = true;
            this.NameT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameT.Location = new System.Drawing.Point(36, 88);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(98, 23);
            this.NameT.TabIndex = 1;
            this.NameT.Text = "Название";
            // 
            // ClassT
            // 
            this.ClassT.AutoSize = true;
            this.ClassT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassT.Location = new System.Drawing.Point(36, 138);
            this.ClassT.Name = "ClassT";
            this.ClassT.Size = new System.Drawing.Size(64, 23);
            this.ClassT.TabIndex = 2;
            this.ClassT.Text = "Класс";
            // 
            // speciesT
            // 
            this.speciesT.AutoSize = true;
            this.speciesT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speciesT.Location = new System.Drawing.Point(36, 188);
            this.speciesT.Name = "speciesT";
            this.speciesT.Size = new System.Drawing.Size(45, 23);
            this.speciesT.TabIndex = 3;
            this.speciesT.Text = "Вид";
            // 
            // countT
            // 
            this.countT.AutoSize = true;
            this.countT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countT.Location = new System.Drawing.Point(36, 235);
            this.countT.Name = "countT";
            this.countT.Size = new System.Drawing.Size(128, 23);
            this.countT.TabIndex = 4;
            this.countT.Text = "Колличество";
            // 
            // behaviourT
            // 
            this.behaviourT.AutoSize = true;
            this.behaviourT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.behaviourT.Location = new System.Drawing.Point(36, 280);
            this.behaviourT.Name = "behaviourT";
            this.behaviourT.Size = new System.Drawing.Size(158, 23);
            this.behaviourT.TabIndex = 5;
            this.behaviourT.Text = "Поведение вида";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(288, 88);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(464, 22);
            this.NameText.TabIndex = 6;
            // 
            // ClassText
            // 
            this.ClassText.Location = new System.Drawing.Point(288, 138);
            this.ClassText.Multiline = true;
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(464, 22);
            this.ClassText.TabIndex = 7;
            // 
            // SpeciesText
            // 
            this.SpeciesText.Location = new System.Drawing.Point(288, 188);
            this.SpeciesText.Multiline = true;
            this.SpeciesText.Name = "SpeciesText";
            this.SpeciesText.Size = new System.Drawing.Size(464, 22);
            this.SpeciesText.TabIndex = 8;
            // 
            // CountText
            // 
            this.CountText.Location = new System.Drawing.Point(288, 237);
            this.CountText.Multiline = true;
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(464, 22);
            this.CountText.TabIndex = 9;
            // 
            // BehaviourText
            // 
            this.BehaviourText.Location = new System.Drawing.Point(288, 282);
            this.BehaviourText.Multiline = true;
            this.BehaviourText.Name = "BehaviourText";
            this.BehaviourText.Size = new System.Drawing.Size(464, 76);
            this.BehaviourText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Редактирование животного";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(677, 11);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 56);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(764, 391);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BehaviourText);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.SpeciesText);
            this.Controls.Add(this.ClassText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.behaviourT);
            this.Controls.Add(this.countT);
            this.Controls.Add(this.speciesT);
            this.Controls.Add(this.ClassT);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseForm";
            this.Text = "ChooseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label NameT;
        private System.Windows.Forms.Label ClassT;
        private System.Windows.Forms.Label speciesT;
        private System.Windows.Forms.Label countT;
        private System.Windows.Forms.Label behaviourT;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox ClassText;
        private System.Windows.Forms.TextBox SpeciesText;
        private System.Windows.Forms.TextBox CountText;
        private System.Windows.Forms.TextBox BehaviourText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
    }
}