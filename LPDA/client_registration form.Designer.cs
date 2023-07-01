namespace LPDA
{
    partial class client_registration_form
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
            this.Client_registration_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Client_registration_button
            // 
            this.Client_registration_button.BackColor = System.Drawing.Color.Transparent;
            this.Client_registration_button.BackgroundImage = global::LPDA.Properties.Resources.x;
            this.Client_registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Client_registration_button.Location = new System.Drawing.Point(256, 119);
            this.Client_registration_button.Name = "Client_registration_button";
            this.Client_registration_button.Size = new System.Drawing.Size(1100, 590);
            this.Client_registration_button.TabIndex = 1;
            this.Client_registration_button.UseVisualStyleBackColor = false;
            this.Client_registration_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LPDA.Properties.Resources.pic5;
            this.pictureBox1.Image = global::LPDA.Properties.Resources.pic4;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1611, 832);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Back_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Back_button.Location = new System.Drawing.Point(107, 714);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(94, 40);
            this.Back_button.TabIndex = 2;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // client_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 784);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Client_registration_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "client_registration_form";
            this.Text = "client_registration_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Client_registration_button;
        private System.Windows.Forms.Button Back_button;
    }
}