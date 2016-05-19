namespace Project_Radiology
{
    partial class Doctors_page_STATISTIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors_page_STATISTIC));
            this.back_btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn4
            // 
            this.back_btn4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn4.Image = ((System.Drawing.Image)(resources.GetObject("back_btn4.Image")));
            this.back_btn4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn4.Location = new System.Drawing.Point(784, 61);
            this.back_btn4.Name = "back_btn4";
            this.back_btn4.Size = new System.Drawing.Size(85, 25);
            this.back_btn4.TabIndex = 2;
            this.back_btn4.Text = "Back";
            this.back_btn4.UseVisualStyleBackColor = true;
            this.back_btn4.Click += new System.EventHandler(this.back_btn4_Click);
            // 
            // Doctors_page_STATISTIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.back_btn4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctors_page_STATISTIC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn4;
    }
}