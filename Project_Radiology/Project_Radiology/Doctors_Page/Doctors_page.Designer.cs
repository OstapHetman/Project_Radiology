namespace Project_Radiology
{
    partial class Doctors_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors_page));
            this.log_btn1 = new System.Windows.Forms.Button();
            this.newpatient_btn = new System.Windows.Forms.Button();
            this.databse_btn = new System.Windows.Forms.Button();
            this.createanalysis_btn = new System.Windows.Forms.Button();
            this.statistic_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_btn1
            // 
            this.log_btn1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn1.Image = ((System.Drawing.Image)(resources.GetObject("log_btn1.Image")));
            this.log_btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log_btn1.Location = new System.Drawing.Point(788, 60);
            this.log_btn1.Name = "log_btn1";
            this.log_btn1.Size = new System.Drawing.Size(85, 25);
            this.log_btn1.TabIndex = 0;
            this.log_btn1.Text = "LogOut";
            this.log_btn1.UseVisualStyleBackColor = true;
            this.log_btn1.Click += new System.EventHandler(this.log_btn1_Click);
            // 
            // newpatient_btn
            // 
            this.newpatient_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpatient_btn.Image = ((System.Drawing.Image)(resources.GetObject("newpatient_btn.Image")));
            this.newpatient_btn.Location = new System.Drawing.Point(388, 147);
            this.newpatient_btn.Name = "newpatient_btn";
            this.newpatient_btn.Size = new System.Drawing.Size(189, 38);
            this.newpatient_btn.TabIndex = 1;
            this.newpatient_btn.Text = "New patient";
            this.newpatient_btn.UseVisualStyleBackColor = true;
            this.newpatient_btn.Click += new System.EventHandler(this.newpatient_btn_Click);
            // 
            // databse_btn
            // 
            this.databse_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databse_btn.Location = new System.Drawing.Point(388, 325);
            this.databse_btn.Name = "databse_btn";
            this.databse_btn.Size = new System.Drawing.Size(189, 38);
            this.databse_btn.TabIndex = 2;
            this.databse_btn.Text = "View analysis";
            this.databse_btn.UseVisualStyleBackColor = true;
            this.databse_btn.Click += new System.EventHandler(this.databse_btn_Click);
            // 
            // createanalysis_btn
            // 
            this.createanalysis_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createanalysis_btn.Location = new System.Drawing.Point(388, 268);
            this.createanalysis_btn.Name = "createanalysis_btn";
            this.createanalysis_btn.Size = new System.Drawing.Size(189, 38);
            this.createanalysis_btn.TabIndex = 3;
            this.createanalysis_btn.Text = "Create analysis";
            this.createanalysis_btn.UseVisualStyleBackColor = true;
            this.createanalysis_btn.Click += new System.EventHandler(this.createanalysis_btn_Click);
            // 
            // statistic_btn
            // 
            this.statistic_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistic_btn.Location = new System.Drawing.Point(388, 384);
            this.statistic_btn.Name = "statistic_btn";
            this.statistic_btn.Size = new System.Drawing.Size(189, 38);
            this.statistic_btn.TabIndex = 4;
            this.statistic_btn.Text = "Statistic";
            this.statistic_btn.UseVisualStyleBackColor = true;
            this.statistic_btn.Click += new System.EventHandler(this.statistic_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(388, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "View patients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Doctors_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statistic_btn);
            this.Controls.Add(this.createanalysis_btn);
            this.Controls.Add(this.databse_btn);
            this.Controls.Add(this.newpatient_btn);
            this.Controls.Add(this.log_btn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctors_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctro\'s page";
            this.Load += new System.EventHandler(this.Doctors_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button log_btn1;
        private System.Windows.Forms.Button newpatient_btn;
        private System.Windows.Forms.Button databse_btn;
        private System.Windows.Forms.Button createanalysis_btn;
        private System.Windows.Forms.Button statistic_btn;
        private System.Windows.Forms.Button button1;
    }
}