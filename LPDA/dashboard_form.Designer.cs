namespace LPDA
{
    partial class dashboard_form
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
            this.CR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CR
            // 
            this.CR.Location = new System.Drawing.Point(108, 114);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(253, 102);
            this.CR.TabIndex = 1;
            this.CR.Text = "c_R";
            this.CR.UseVisualStyleBackColor = true;
            // 
            // dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CR);
            this.Name = "dashboard_form";
            this.Text = "dashboard_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CR;
    }
}