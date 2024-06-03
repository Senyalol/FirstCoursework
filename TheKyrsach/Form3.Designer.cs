namespace TheKyrsach
{
    partial class Form3
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
            this.PredatorButton = new System.Windows.Forms.Button();
            this.HerbivoresButton = new System.Windows.Forms.Button();
            this.PlantButton = new System.Windows.Forms.Button();
            this.InsectButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PredatorButton
            // 
            this.PredatorButton.BackColor = System.Drawing.Color.IndianRed;
            this.PredatorButton.FlatAppearance.BorderSize = 2;
            this.PredatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredatorButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PredatorButton.Location = new System.Drawing.Point(0, 31);
            this.PredatorButton.Name = "PredatorButton";
            this.PredatorButton.Size = new System.Drawing.Size(270, 116);
            this.PredatorButton.TabIndex = 0;
            this.PredatorButton.Text = "Хищник";
            this.PredatorButton.UseVisualStyleBackColor = false;
            this.PredatorButton.Click += new System.EventHandler(this.PredatorButton_Click);
            // 
            // HerbivoresButton
            // 
            this.HerbivoresButton.BackColor = System.Drawing.Color.YellowGreen;
            this.HerbivoresButton.FlatAppearance.BorderSize = 2;
            this.HerbivoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HerbivoresButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HerbivoresButton.Location = new System.Drawing.Point(276, 31);
            this.HerbivoresButton.Name = "HerbivoresButton";
            this.HerbivoresButton.Size = new System.Drawing.Size(271, 116);
            this.HerbivoresButton.TabIndex = 1;
            this.HerbivoresButton.Text = "Травоядные";
            this.HerbivoresButton.UseVisualStyleBackColor = false;
            this.HerbivoresButton.Click += new System.EventHandler(this.HerbivoresButton_Click);
            // 
            // PlantButton
            // 
            this.PlantButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PlantButton.FlatAppearance.BorderSize = 2;
            this.PlantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlantButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlantButton.Location = new System.Drawing.Point(0, 153);
            this.PlantButton.Name = "PlantButton";
            this.PlantButton.Size = new System.Drawing.Size(270, 130);
            this.PlantButton.TabIndex = 2;
            this.PlantButton.Text = "Растения";
            this.PlantButton.UseVisualStyleBackColor = false;
            this.PlantButton.Click += new System.EventHandler(this.PlantButton_Click);
            // 
            // InsectButton
            // 
            this.InsectButton.BackColor = System.Drawing.Color.RosyBrown;
            this.InsectButton.FlatAppearance.BorderSize = 2;
            this.InsectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsectButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsectButton.Location = new System.Drawing.Point(276, 153);
            this.InsectButton.Name = "InsectButton";
            this.InsectButton.Size = new System.Drawing.Size(271, 130);
            this.InsectButton.TabIndex = 3;
            this.InsectButton.Text = "Насекомые";
            this.InsectButton.UseVisualStyleBackColor = false;
            this.InsectButton.Click += new System.EventHandler(this.InsectButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 286);
            this.Controls.Add(this.InsectButton);
            this.Controls.Add(this.PlantButton);
            this.Controls.Add(this.HerbivoresButton);
            this.Controls.Add(this.PredatorButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PredatorButton;
        private System.Windows.Forms.Button HerbivoresButton;
        private System.Windows.Forms.Button PlantButton;
        private System.Windows.Forms.Button InsectButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    }
}