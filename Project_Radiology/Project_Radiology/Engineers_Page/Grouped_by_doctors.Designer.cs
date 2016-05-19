namespace Project_Radiology.Engineers_Page
{
    partial class Grouped_by_doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grouped_by_doctors));
            this.back_btn4z = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn4z
            // 
            this.back_btn4z.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn4z.Image = ((System.Drawing.Image)(resources.GetObject("back_btn4z.Image")));
            this.back_btn4z.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn4z.Location = new System.Drawing.Point(792, 63);
            this.back_btn4z.Name = "back_btn4z";
            this.back_btn4z.Size = new System.Drawing.Size(75, 25);
            this.back_btn4z.TabIndex = 4;
            this.back_btn4z.Text = "Back";
            this.back_btn4z.UseVisualStyleBackColor = true;
            this.back_btn4z.Click += new System.EventHandler(this.back_btn4z_Click);
            // 
            // Grouped_by_doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.back_btn4z);
            this.Name = "Grouped_by_doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grouped_by_doctors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn4z;
    }
}