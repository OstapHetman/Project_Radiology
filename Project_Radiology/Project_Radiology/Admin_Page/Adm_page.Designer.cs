namespace Project_Radiology.Admin_Page
{
    partial class Adm_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm_page));
            this.adddoc_btn = new System.Windows.Forms.Button();
            this.addengineer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adddoc_btn
            // 
            this.adddoc_btn.Location = new System.Drawing.Point(383, 143);
            this.adddoc_btn.Name = "adddoc_btn";
            this.adddoc_btn.Size = new System.Drawing.Size(184, 38);
            this.adddoc_btn.TabIndex = 0;
            this.adddoc_btn.Text = "Add a doctor";
            this.adddoc_btn.UseVisualStyleBackColor = true;
            this.adddoc_btn.Click += new System.EventHandler(this.adddoc_btn_Click);
            // 
            // addengineer_btn
            // 
            this.addengineer_btn.Location = new System.Drawing.Point(383, 202);
            this.addengineer_btn.Name = "addengineer_btn";
            this.addengineer_btn.Size = new System.Drawing.Size(184, 38);
            this.addengineer_btn.TabIndex = 1;
            this.addengineer_btn.Text = "Add a engineer";
            this.addengineer_btn.UseVisualStyleBackColor = true;
            // 
            // Adm_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.addengineer_btn);
            this.Controls.Add(this.adddoc_btn);
            this.Name = "Adm_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm_page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adddoc_btn;
        private System.Windows.Forms.Button addengineer_btn;
    }
}