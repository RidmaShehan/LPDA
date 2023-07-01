namespace LPDA
{
    partial class peronal_detail_form
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
            this.Full_Name_textBox = new System.Windows.Forms.TextBox();
            this.NIC_NO_textBox = new System.Windows.Forms.TextBox();
            this.Date_of_Birth_textBox = new System.Windows.Forms.TextBox();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Full_Name_label = new System.Windows.Forms.Label();
            this.NIC_label = new System.Windows.Forms.Label();
            this.Date_of_birth_label = new System.Windows.Forms.Label();
            this.Age_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Male_radio = new System.Windows.Forms.RadioButton();
            this.Female_radio = new System.Windows.Forms.RadioButton();
            this.other_radio = new System.Windows.Forms.RadioButton();
            this.Back_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Full_Name_textBox
            // 
            this.Full_Name_textBox.Location = new System.Drawing.Point(282, 318);
            this.Full_Name_textBox.Multiline = true;
            this.Full_Name_textBox.Name = "Full_Name_textBox";
            this.Full_Name_textBox.Size = new System.Drawing.Size(433, 32);
            this.Full_Name_textBox.TabIndex = 1;
            this.Full_Name_textBox.Visible = false;
            this.Full_Name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NIC_NO_textBox
            // 
            this.NIC_NO_textBox.Location = new System.Drawing.Point(282, 419);
            this.NIC_NO_textBox.Multiline = true;
            this.NIC_NO_textBox.Name = "NIC_NO_textBox";
            this.NIC_NO_textBox.Size = new System.Drawing.Size(433, 32);
            this.NIC_NO_textBox.TabIndex = 2;
            this.NIC_NO_textBox.TextChanged += new System.EventHandler(this.NIC_NO_textBox_TextChanged);
            // 
            // Date_of_Birth_textBox
            // 
            this.Date_of_Birth_textBox.Location = new System.Drawing.Point(282, 518);
            this.Date_of_Birth_textBox.Multiline = true;
            this.Date_of_Birth_textBox.Name = "Date_of_Birth_textBox";
            this.Date_of_Birth_textBox.Size = new System.Drawing.Size(433, 32);
            this.Date_of_Birth_textBox.TabIndex = 3;
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(842, 318);
            this.Age_textBox.Multiline = true;
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(433, 32);
            this.Age_textBox.TabIndex = 4;
            // 
            // Full_Name_label
            // 
            this.Full_Name_label.AutoSize = true;
            this.Full_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name_label.ForeColor = System.Drawing.Color.Red;
            this.Full_Name_label.Location = new System.Drawing.Point(279, 353);
            this.Full_Name_label.Name = "Full_Name_label";
            this.Full_Name_label.Size = new System.Drawing.Size(187, 18);
            this.Full_Name_label.TabIndex = 6;
            this.Full_Name_label.Text = "Please Enter the Full Name";
            // 
            // NIC_label
            // 
            this.NIC_label.AutoSize = true;
            this.NIC_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC_label.ForeColor = System.Drawing.Color.Red;
            this.NIC_label.Location = new System.Drawing.Point(279, 454);
            this.NIC_label.Name = "NIC_label";
            this.NIC_label.Size = new System.Drawing.Size(172, 18);
            this.NIC_label.TabIndex = 7;
            this.NIC_label.Text = "Please Enter the NIC NO";
            // 
            // Date_of_birth_label
            // 
            this.Date_of_birth_label.AutoSize = true;
            this.Date_of_birth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_of_birth_label.ForeColor = System.Drawing.Color.Red;
            this.Date_of_birth_label.Location = new System.Drawing.Point(279, 553);
            this.Date_of_birth_label.Name = "Date_of_birth_label";
            this.Date_of_birth_label.Size = new System.Drawing.Size(202, 18);
            this.Date_of_birth_label.TabIndex = 8;
            this.Date_of_birth_label.Text = "Please Enter the Date of Birth";
            // 
            // Age_label
            // 
            this.Age_label.AutoSize = true;
            this.Age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_label.ForeColor = System.Drawing.Color.Red;
            this.Age_label.Location = new System.Drawing.Point(839, 353);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size(145, 18);
            this.Age_label.TabIndex = 9;
            this.Age_label.Text = "Please Enter the Age";
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_label.ForeColor = System.Drawing.Color.Red;
            this.Gender_label.Location = new System.Drawing.Point(839, 454);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(169, 18);
            this.Gender_label.TabIndex = 10;
            this.Gender_label.Text = "Please Enter the Gender";
            // 
            // Male_radio
            // 
            this.Male_radio.AutoSize = true;
            this.Male_radio.Location = new System.Drawing.Point(854, 420);
            this.Male_radio.Name = "Male_radio";
            this.Male_radio.Size = new System.Drawing.Size(58, 20);
            this.Male_radio.TabIndex = 11;
            this.Male_radio.TabStop = true;
            this.Male_radio.Text = "Male";
            this.Male_radio.UseVisualStyleBackColor = true;
            // 
            // Female_radio
            // 
            this.Female_radio.AutoSize = true;
            this.Female_radio.Location = new System.Drawing.Point(1010, 419);
            this.Female_radio.Name = "Female_radio";
            this.Female_radio.Size = new System.Drawing.Size(74, 20);
            this.Female_radio.TabIndex = 12;
            this.Female_radio.TabStop = true;
            this.Female_radio.Text = "Female";
            this.Female_radio.UseVisualStyleBackColor = true;
            // 
            // other_radio
            // 
            this.other_radio.AutoSize = true;
            this.other_radio.Location = new System.Drawing.Point(1189, 420);
            this.other_radio.Name = "other_radio";
            this.other_radio.Size = new System.Drawing.Size(58, 20);
            this.other_radio.TabIndex = 13;
            this.other_radio.TabStop = true;
            this.other_radio.Text = "other";
            this.other_radio.UseVisualStyleBackColor = true;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.Back_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Back_button.Location = new System.Drawing.Point(282, 623);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(94, 40);
            this.Back_button.TabIndex = 14;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Next_button.Location = new System.Drawing.Point(1212, 619);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(94, 40);
            this.Next_button.TabIndex = 15;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = false;
            this.Next_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LPDA.Properties.Resources.pic2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1612, 832);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // peronal_detail_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 784);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.other_radio);
            this.Controls.Add(this.Female_radio);
            this.Controls.Add(this.Male_radio);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.Age_label);
            this.Controls.Add(this.Date_of_birth_label);
            this.Controls.Add(this.NIC_label);
            this.Controls.Add(this.Full_Name_label);
            this.Controls.Add(this.Age_textBox);
            this.Controls.Add(this.Date_of_Birth_textBox);
            this.Controls.Add(this.NIC_NO_textBox);
            this.Controls.Add(this.Full_Name_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "peronal_detail_form";
            this.Text = "peronal_detail_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Full_Name_textBox;
        private System.Windows.Forms.TextBox NIC_NO_textBox;
        private System.Windows.Forms.TextBox Date_of_Birth_textBox;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.Label Full_Name_label;
        private System.Windows.Forms.Label NIC_label;
        private System.Windows.Forms.Label Date_of_birth_label;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.RadioButton Male_radio;
        private System.Windows.Forms.RadioButton Female_radio;
        private System.Windows.Forms.RadioButton other_radio;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Next_button;
    }
}