namespace Project_Radiology
{
    partial class statistic_eng
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistic_eng));
            this.log_btn3z = new System.Windows.Forms.Button();
            this.hospitalDataSet = new Project_Radiology.HospitalDataSet();
            this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.AnalysisTableAdapter();
            this.grouped_btn = new System.Windows.Forms.Button();
            this.groped_btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // log_btn3z
            // 
            this.log_btn3z.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_btn3z.ForeColor = System.Drawing.Color.DimGray;
            this.log_btn3z.Image = ((System.Drawing.Image)(resources.GetObject("log_btn3z.Image")));
            this.log_btn3z.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log_btn3z.Location = new System.Drawing.Point(788, 59);
            this.log_btn3z.Name = "log_btn3z";
            this.log_btn3z.Size = new System.Drawing.Size(85, 25);
            this.log_btn3z.TabIndex = 3;
            this.log_btn3z.Text = "Back";
            this.log_btn3z.UseVisualStyleBackColor = true;
            this.log_btn3z.Click += new System.EventHandler(this.log_btn3z_Click);
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // analysisBindingSource
            // 
            this.analysisBindingSource.DataMember = "Analysis";
            this.analysisBindingSource.DataSource = this.hospitalDataSet;
            // 
            // analysisTableAdapter
            // 
            this.analysisTableAdapter.ClearBeforeFill = true;
            // 
            // grouped_btn
            // 
            this.grouped_btn.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grouped_btn.ForeColor = System.Drawing.Color.DimGray;
            this.grouped_btn.Image = ((System.Drawing.Image)(resources.GetObject("grouped_btn.Image")));
            this.grouped_btn.Location = new System.Drawing.Point(394, 225);
            this.grouped_btn.Name = "grouped_btn";
            this.grouped_btn.Size = new System.Drawing.Size(160, 36);
            this.grouped_btn.TabIndex = 4;
            this.grouped_btn.Text = "Grouped by doctors";
            this.grouped_btn.UseVisualStyleBackColor = true;
            this.grouped_btn.Click += new System.EventHandler(this.grouped_btn_Click);
            // 
            // groped_btn2
            // 
            this.groped_btn2.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groped_btn2.ForeColor = System.Drawing.Color.DimGray;
            this.groped_btn2.Image = ((System.Drawing.Image)(resources.GetObject("groped_btn2.Image")));
            this.groped_btn2.Location = new System.Drawing.Point(394, 291);
            this.groped_btn2.Name = "groped_btn2";
            this.groped_btn2.Size = new System.Drawing.Size(160, 36);
            this.groped_btn2.TabIndex = 5;
            this.groped_btn2.Text = "Grouped by patients";
            this.groped_btn2.UseVisualStyleBackColor = true;
            this.groped_btn2.Click += new System.EventHandler(this.groped_btn2_Click);
            // 
            // statistic_eng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.groped_btn2);
            this.Controls.Add(this.grouped_btn);
            this.Controls.Add(this.log_btn3z);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "statistic_eng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.statistic_eng_FormClosing);
            this.Load += new System.EventHandler(this.statistic_eng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button log_btn3z;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource analysisBindingSource;
        private HospitalDataSetTableAdapters.AnalysisTableAdapter analysisTableAdapter;
        private System.Windows.Forms.Button grouped_btn;
        private System.Windows.Forms.Button groped_btn2;
    }
}