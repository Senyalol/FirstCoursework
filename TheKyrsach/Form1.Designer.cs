namespace TheKyrsach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEntity = new System.Windows.Forms.Button();
            this.DeleteEntity = new System.Windows.Forms.Button();
            this.ShowData = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Fbutton = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEntity
            // 
            this.AddEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEntity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEntity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEntity.Location = new System.Drawing.Point(561, 12);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(191, 56);
            this.AddEntity.TabIndex = 0;
            this.AddEntity.Text = "Добавить животное";
            this.AddEntity.UseVisualStyleBackColor = false;
            this.AddEntity.Click += new System.EventHandler(this.AddEntity_Click);
            // 
            // DeleteEntity
            // 
            this.DeleteEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEntity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEntity.Location = new System.Drawing.Point(758, 12);
            this.DeleteEntity.Name = "DeleteEntity";
            this.DeleteEntity.Size = new System.Drawing.Size(196, 55);
            this.DeleteEntity.TabIndex = 2;
            this.DeleteEntity.Text = "Удалить животное";
            this.DeleteEntity.UseVisualStyleBackColor = false;
            this.DeleteEntity.Click += new System.EventHandler(this.DeleteEntity_Click);
            // 
            // ShowData
            // 
            this.ShowData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowData.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowData.Location = new System.Drawing.Point(562, 71);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(190, 56);
            this.ShowData.TabIndex = 3;
            this.ShowData.Text = "Показать все виды";
            this.ShowData.UseVisualStyleBackColor = false;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.Location = new System.Drawing.Point(0, 1);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(555, 519);
            this.Display.TabIndex = 4;
            this.Display.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(563, 316);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(392, 55);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить экран";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // FiltrButton
            // 
            this.FiltrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FiltrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrButton.Location = new System.Drawing.Point(758, 73);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(196, 54);
            this.FiltrButton.TabIndex = 11;
            this.FiltrButton.Text = "Категории";
            this.FiltrButton.UseVisualStyleBackColor = false;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.Location = new System.Drawing.Point(757, 133);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(197, 55);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(562, 133);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(190, 55);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Редактор";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(842, 459);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 50);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Fbutton
            // 
            this.Fbutton.BackColor = System.Drawing.Color.White;
            this.Fbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fbutton.Location = new System.Drawing.Point(561, 194);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(393, 55);
            this.Fbutton.TabIndex = 15;
            this.Fbutton.Text = "Фильтрация";
            this.Fbutton.UseVisualStyleBackColor = false;
            this.Fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.BackColor = System.Drawing.Color.White;
            this.SaveDataButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDataButton.Location = new System.Drawing.Point(563, 255);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(392, 55);
            this.SaveDataButton.TabIndex = 16;
            this.SaveDataButton.Text = "Сохранить данные";
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(966, 521);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.Fbutton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FiltrButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.DeleteEntity);
            this.Controls.Add(this.AddEntity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEntity;
        private System.Windows.Forms.Button DeleteEntity;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.Button SaveDataButton;
    }
}

