namespace Project_Radiology
{
    partial class Admin_pages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_pages));
            this.log_btn3 = new System.Windows.Forms.Button();
            this.adddoc_btn = new System.Windows.Forms.Button();
            this.addengineer_btn = new System.Windows.Forms.Button();
            this.addlaborator_btn = new System.Windows.Forms.Button();
            this.addhospital_btn = new System.Windows.Forms.Button();
            this.statistic_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_btn3
            // 
            this.log_btn3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn3.Image = ((System.Drawing.Image)(resources.GetObject("log_btn3.Image")));
            this.log_btn3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log_btn3.Location = new System.Drawing.Point(793, 65);
            this.log_btn3.Name = "log_btn3";
            this.log_btn3.Size = new System.Drawing.Size(75, 25);
            this.log_btn3.TabIndex = 1;
            this.log_btn3.Text = "LogOut";
            this.log_btn3.UseVisualStyleBackColor = true;
            this.log_btn3.Click += new System.EventHandler(this.log_btn3_Click);
            // 
            // adddoc_btn
            // 
            this.adddoc_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adddoc_btn.Location = new System.Drawing.Point(392, 154);
            this.adddoc_btn.Name = "adddoc_btn";
            this.adddoc_btn.Size = new System.Drawing.Size(160, 36);
            this.adddoc_btn.TabIndex = 2;
            this.adddoc_btn.Text = "Add a doctor";
            this.adddoc_btn.UseVisualStyleBackColor = true;
            this.adddoc_btn.Click += new System.EventHandler(this.adddoc_btn_Click);
            // 
            // addengineer_btn
            // 
            this.addengineer_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addengineer_btn.Location = new System.Drawing.Point(392, 207);
            this.addengineer_btn.Name = "addengineer_btn";
            this.addengineer_btn.Size = new System.Drawing.Size(160, 36);
            this.addengineer_btn.TabIndex = 3;
            this.addengineer_btn.Text = "Add a engineer";
            this.addengineer_btn.UseVisualStyleBackColor = true;
            this.addengineer_btn.Click += new System.EventHandler(this.addengineer_btn_Click);
            // 
            // addlaborator_btn
            // 
            this.addlaborator_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addlaborator_btn.Location = new System.Drawing.Point(392, 260);
            this.addlaborator_btn.Name = "addlaborator_btn";
            this.addlaborator_btn.Size = new System.Drawing.Size(160, 36);
            this.addlaborator_btn.TabIndex = 4;
            this.addlaborator_btn.Text = "Add a labotatory";
            this.addlaborator_btn.UseVisualStyleBackColor = true;
            this.addlaborator_btn.Click += new System.EventHandler(this.addlaborator_btn_Click);
            // 
            // addhospital_btn
            // 
            this.addhospital_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addhospital_btn.Location = new System.Drawing.Point(392, 312);
            this.addhospital_btn.Name = "addhospital_btn";
            this.addhospital_btn.Size = new System.Drawing.Size(160, 36);
            this.addhospital_btn.TabIndex = 5;
            this.addhospital_btn.Text = "Add a hospital";
            this.addhospital_btn.UseVisualStyleBackColor = true;
            this.addhospital_btn.Click += new System.EventHandler(this.addhospital_btn_Click);
            // 
            // statistic_btn
            // 
            this.statistic_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistic_btn.Location = new System.Drawing.Point(392, 367);
            this.statistic_btn.Name = "statistic_btn";
            this.statistic_btn.Size = new System.Drawing.Size(160, 36);
            this.statistic_btn.TabIndex = 6;
            this.statistic_btn.Text = "Statistic";
            this.statistic_btn.UseVisualStyleBackColor = true;
            this.statistic_btn.Click += new System.EventHandler(this.statistic_btn_Click);
            // 
            // Admin_pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.statistic_btn);
            this.Controls.Add(this.addhospital_btn);
            this.Controls.Add(this.addlaborator_btn);
            this.Controls.Add(this.addengineer_btn);
            this.Controls.Add(this.adddoc_btn);
            this.Controls.Add(this.log_btn3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_pages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin\'s page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button log_btn3;
        private System.Windows.Forms.Button adddoc_btn;
        private System.Windows.Forms.Button addengineer_btn;
        private System.Windows.Forms.Button addlaborator_btn;
        private System.Windows.Forms.Button addhospital_btn;
        private System.Windows.Forms.Button statistic_btn;
    }
}