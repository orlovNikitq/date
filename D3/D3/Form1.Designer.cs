namespace D3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.Additional_information = new System.Windows.Forms.TextBox();
            this.Family_status = new System.Windows.Forms.TextBox();
            this.Date_of_birth = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Family status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Additional information";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(78, 75);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(150, 20);
            this.Surname.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(78, 126);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(150, 20);
            this.Name.TabIndex = 8;
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(78, 175);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(150, 20);
            this.Patronymic.TabIndex = 9;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(78, 220);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(150, 20);
            this.Gender.TabIndex = 10;
            // 
            // Additional_information
            // 
            this.Additional_information.Location = new System.Drawing.Point(78, 343);
            this.Additional_information.Name = "Additional_information";
            this.Additional_information.Size = new System.Drawing.Size(150, 20);
            this.Additional_information.TabIndex = 12;
            // 
            // Family_status
            // 
            this.Family_status.Location = new System.Drawing.Point(78, 302);
            this.Family_status.Name = "Family_status";
            this.Family_status.Size = new System.Drawing.Size(150, 20);
            this.Family_status.TabIndex = 13;
            // 
            // Date_of_birth
            // 
            this.Date_of_birth.Location = new System.Drawing.Point(78, 263);
            this.Date_of_birth.Name = "Date_of_birth";
            this.Date_of_birth.Size = new System.Drawing.Size(150, 20);
            this.Date_of_birth.TabIndex = 14;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(454, 194);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(149, 33);
            this.Save_button.TabIndex = 15;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Date_of_birth);
            this.Controls.Add(this.Family_status);
            this.Controls.Add(this.Additional_information);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
 
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox Additional_information;
        private System.Windows.Forms.TextBox Family_status;
        private System.Windows.Forms.TextBox Date_of_birth;
        private System.Windows.Forms.Button Save_button;
    }
}

