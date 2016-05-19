namespace Project_Radiology.Admin_Page
{
    partial class Adm_add_doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm_add_doc));
            this.back_btn1222 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn1222
            // 
            this.back_btn1222.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn1222.Image = ((System.Drawing.Image)(resources.GetObject("back_btn1222.Image")));
            this.back_btn1222.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn1222.Location = new System.Drawing.Point(790, 63);
            this.back_btn1222.Name = "back_btn1222";
            this.back_btn1222.Size = new System.Drawing.Size(75, 25);
            this.back_btn1222.TabIndex = 2;
            this.back_btn1222.Text = "Back";
            this.back_btn1222.UseVisualStyleBackColor = true;
            this.back_btn1222.Click += new System.EventHandler(this.back_btn1222_Click);
            // 
            // Adm_add_doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.back_btn1222);
            this.Name = "Adm_add_doc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm_add_doc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn1222;
    }
}