namespace LPDA
{
    partial class create_account_form_02
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
            this.background = new System.Windows.Forms.PictureBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.user_name_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.phone_number_text = new System.Windows.Forms.TextBox();
            this.zip_code_text = new System.Windows.Forms.TextBox();
            this.confirm_password_text = new System.Windows.Forms.TextBox();
            this.back_butten_form_02 = new System.Windows.Forms.Button();
            this.next_butten_form_02 = new System.Windows.Forms.Button();
            this.phone_number_error_picture = new System.Windows.Forms.PictureBox();
            this.email_error_picture = new System.Windows.Forms.PictureBox();
            this.zipcode_error_picture = new System.Windows.Forms.PictureBox();
            this.user_name_error_picture = new System.Windows.Forms.PictureBox();
            this.confirm_password_error_picture = new System.Windows.Forms.PictureBox();
            this.password_error_picture = new System.Windows.Forms.PictureBox();
            this.email_correct_picture = new System.Windows.Forms.PictureBox();
            this.phone_number_correct_picture = new System.Windows.Forms.PictureBox();
            this.zipcode_correct_picture = new System.Windows.Forms.PictureBox();
            this.user_name_correct_picture = new System.Windows.Forms.PictureBox();
            this.password_correct_picture = new System.Windows.Forms.PictureBox();
            this.confirm_password_correct_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_number_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipcode_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_password_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_number_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipcode_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_password_correct_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = global::LPDA.Properties.Resources.registar_form_02;
            this.background.Location = new System.Drawing.Point(0, 1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1623, 880);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // email_text
            // 
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(310, 346);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(417, 27);
            this.email_text.TabIndex = 1;
            this.email_text.TextChanged += new System.EventHandler(this.email_text_TextChanged);
            this.email_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_text_KeyDown);
            // 
            // user_name_text
            // 
            this.user_name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_text.Location = new System.Drawing.Point(310, 448);
            this.user_name_text.Name = "user_name_text";
            this.user_name_text.Size = new System.Drawing.Size(417, 27);
            this.user_name_text.TabIndex = 1;
            this.user_name_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_name_text_KeyDown);
            // 
            // password_text
            // 
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(310, 546);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(417, 27);
            this.password_text.TabIndex = 1;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            this.password_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_text_KeyDown);
            // 
            // phone_number_text
            // 
            this.phone_number_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_number_text.Location = new System.Drawing.Point(892, 346);
            this.phone_number_text.MaxLength = 10;
            this.phone_number_text.Name = "phone_number_text";
            this.phone_number_text.Size = new System.Drawing.Size(417, 27);
            this.phone_number_text.TabIndex = 1;
            this.phone_number_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_number_text_KeyDown);
            // 
            // zip_code_text
            // 
            this.zip_code_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip_code_text.Location = new System.Drawing.Point(892, 448);
            this.zip_code_text.MaxLength = 5;
            this.zip_code_text.Name = "zip_code_text";
            this.zip_code_text.Size = new System.Drawing.Size(417, 27);
            this.zip_code_text.TabIndex = 1;
            this.zip_code_text.TextChanged += new System.EventHandler(this.zip_code_text_TextChanged);
            this.zip_code_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zip_code_text_KeyDown);
            // 
            // confirm_password_text
            // 
            this.confirm_password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_text.Location = new System.Drawing.Point(892, 546);
            this.confirm_password_text.Name = "confirm_password_text";
            this.confirm_password_text.Size = new System.Drawing.Size(417, 27);
            this.confirm_password_text.TabIndex = 1;
            this.confirm_password_text.TextChanged += new System.EventHandler(this.confirm_password_TextChanged);
            this.confirm_password_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirm_password_KeyDown);
            // 
            // back_butten_form_02
            // 
            this.back_butten_form_02.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_butten_form_02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_butten_form_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_butten_form_02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_butten_form_02.Location = new System.Drawing.Point(300, 673);
            this.back_butten_form_02.Name = "back_butten_form_02";
            this.back_butten_form_02.Size = new System.Drawing.Size(144, 31);
            this.back_butten_form_02.TabIndex = 2;
            this.back_butten_form_02.Text = "B A C K";
            this.back_butten_form_02.UseVisualStyleBackColor = false;
            // 
            // next_butten_form_02
            // 
            this.next_butten_form_02.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_butten_form_02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_butten_form_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_butten_form_02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next_butten_form_02.Location = new System.Drawing.Point(1170, 673);
            this.next_butten_form_02.Name = "next_butten_form_02";
            this.next_butten_form_02.Size = new System.Drawing.Size(144, 31);
            this.next_butten_form_02.TabIndex = 2;
            this.next_butten_form_02.Text = "N E X T";
            this.next_butten_form_02.UseVisualStyleBackColor = false;
            this.next_butten_form_02.Click += new System.EventHandler(this.next_butten_form_02_Click);
            // 
            // phone_number_error_picture
            // 
            this.phone_number_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.phone_number_error_picture.Location = new System.Drawing.Point(879, 319);
            this.phone_number_error_picture.Name = "phone_number_error_picture";
            this.phone_number_error_picture.Size = new System.Drawing.Size(5, 59);
            this.phone_number_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phone_number_error_picture.TabIndex = 3;
            this.phone_number_error_picture.TabStop = false;
            this.phone_number_error_picture.Visible = false;
            // 
            // email_error_picture
            // 
            this.email_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.email_error_picture.Location = new System.Drawing.Point(298, 319);
            this.email_error_picture.Name = "email_error_picture";
            this.email_error_picture.Size = new System.Drawing.Size(5, 59);
            this.email_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.email_error_picture.TabIndex = 3;
            this.email_error_picture.TabStop = false;
            this.email_error_picture.Visible = false;
            // 
            // zipcode_error_picture
            // 
            this.zipcode_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.zipcode_error_picture.Location = new System.Drawing.Point(879, 420);
            this.zipcode_error_picture.Name = "zipcode_error_picture";
            this.zipcode_error_picture.Size = new System.Drawing.Size(5, 59);
            this.zipcode_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zipcode_error_picture.TabIndex = 3;
            this.zipcode_error_picture.TabStop = false;
            this.zipcode_error_picture.Visible = false;
            // 
            // user_name_error_picture
            // 
            this.user_name_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.user_name_error_picture.Location = new System.Drawing.Point(298, 420);
            this.user_name_error_picture.Name = "user_name_error_picture";
            this.user_name_error_picture.Size = new System.Drawing.Size(5, 59);
            this.user_name_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_name_error_picture.TabIndex = 3;
            this.user_name_error_picture.TabStop = false;
            this.user_name_error_picture.Visible = false;
            // 
            // confirm_password_error_picture
            // 
            this.confirm_password_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.confirm_password_error_picture.Location = new System.Drawing.Point(879, 521);
            this.confirm_password_error_picture.Name = "confirm_password_error_picture";
            this.confirm_password_error_picture.Size = new System.Drawing.Size(5, 59);
            this.confirm_password_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirm_password_error_picture.TabIndex = 3;
            this.confirm_password_error_picture.TabStop = false;
            this.confirm_password_error_picture.Visible = false;
            // 
            // password_error_picture
            // 
            this.password_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.password_error_picture.Location = new System.Drawing.Point(299, 521);
            this.password_error_picture.Name = "password_error_picture";
            this.password_error_picture.Size = new System.Drawing.Size(5, 59);
            this.password_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_error_picture.TabIndex = 3;
            this.password_error_picture.TabStop = false;
            this.password_error_picture.Visible = false;
            // 
            // email_correct_picture
            // 
            this.email_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.email_correct_picture.Location = new System.Drawing.Point(299, 319);
            this.email_correct_picture.Name = "email_correct_picture";
            this.email_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.email_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.email_correct_picture.TabIndex = 3;
            this.email_correct_picture.TabStop = false;
            this.email_correct_picture.Visible = false;
            // 
            // phone_number_correct_picture
            // 
            this.phone_number_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.phone_number_correct_picture.Location = new System.Drawing.Point(878, 319);
            this.phone_number_correct_picture.Name = "phone_number_correct_picture";
            this.phone_number_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.phone_number_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phone_number_correct_picture.TabIndex = 3;
            this.phone_number_correct_picture.TabStop = false;
            this.phone_number_correct_picture.Visible = false;
            // 
            // zipcode_correct_picture
            // 
            this.zipcode_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.zipcode_correct_picture.Location = new System.Drawing.Point(878, 420);
            this.zipcode_correct_picture.Name = "zipcode_correct_picture";
            this.zipcode_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.zipcode_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zipcode_correct_picture.TabIndex = 3;
            this.zipcode_correct_picture.TabStop = false;
            this.zipcode_correct_picture.Visible = false;
            // 
            // user_name_correct_picture
            // 
            this.user_name_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.user_name_correct_picture.Location = new System.Drawing.Point(298, 420);
            this.user_name_correct_picture.Name = "user_name_correct_picture";
            this.user_name_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.user_name_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_name_correct_picture.TabIndex = 3;
            this.user_name_correct_picture.TabStop = false;
            this.user_name_correct_picture.Visible = false;
            // 
            // password_correct_picture
            // 
            this.password_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.password_correct_picture.Location = new System.Drawing.Point(298, 521);
            this.password_correct_picture.Name = "password_correct_picture";
            this.password_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.password_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_correct_picture.TabIndex = 3;
            this.password_correct_picture.TabStop = false;
            this.password_correct_picture.Visible = false;
            // 
            // confirm_password_correct_picture
            // 
            this.confirm_password_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.confirm_password_correct_picture.Location = new System.Drawing.Point(878, 521);
            this.confirm_password_correct_picture.Name = "confirm_password_correct_picture";
            this.confirm_password_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.confirm_password_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirm_password_correct_picture.TabIndex = 3;
            this.confirm_password_correct_picture.TabStop = false;
            this.confirm_password_correct_picture.Visible = false;
            // 
            // create_account_form_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 881);
            this.Controls.Add(this.zipcode_correct_picture);
            this.Controls.Add(this.phone_number_correct_picture);
            this.Controls.Add(this.confirm_password_correct_picture);
            this.Controls.Add(this.password_correct_picture);
            this.Controls.Add(this.user_name_correct_picture);
            this.Controls.Add(this.email_correct_picture);
            this.Controls.Add(this.email_error_picture);
            this.Controls.Add(this.user_name_error_picture);
            this.Controls.Add(this.password_error_picture);
            this.Controls.Add(this.confirm_password_error_picture);
            this.Controls.Add(this.zipcode_error_picture);
            this.Controls.Add(this.phone_number_error_picture);
            this.Controls.Add(this.next_butten_form_02);
            this.Controls.Add(this.back_butten_form_02);
            this.Controls.Add(this.confirm_password_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.zip_code_text);
            this.Controls.Add(this.user_name_text);
            this.Controls.Add(this.phone_number_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.background);
            this.Name = "create_account_form_02";
            this.Text = "create_account_form_02";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_number_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipcode_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_password_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_number_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipcode_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_password_correct_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox user_name_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox phone_number_text;
        private System.Windows.Forms.TextBox zip_code_text;
        private System.Windows.Forms.TextBox confirm_password_text;
        private System.Windows.Forms.Button back_butten_form_02;
        private System.Windows.Forms.Button next_butten_form_02;
        private System.Windows.Forms.PictureBox phone_number_error_picture;
        private System.Windows.Forms.PictureBox email_error_picture;
        private System.Windows.Forms.PictureBox zipcode_error_picture;
        private System.Windows.Forms.PictureBox user_name_error_picture;
        private System.Windows.Forms.PictureBox confirm_password_error_picture;
        private System.Windows.Forms.PictureBox password_error_picture;
        private System.Windows.Forms.PictureBox email_correct_picture;
        private System.Windows.Forms.PictureBox phone_number_correct_picture;
        private System.Windows.Forms.PictureBox zipcode_correct_picture;
        private System.Windows.Forms.PictureBox user_name_correct_picture;
        private System.Windows.Forms.PictureBox password_correct_picture;
        private System.Windows.Forms.PictureBox confirm_password_correct_picture;
    }
}