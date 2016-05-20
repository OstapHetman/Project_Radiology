namespace Project_Radiology
{
    partial class statis_adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statis_adm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.log_btn3z = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hospitalDataSet = new Project_Radiology.HospitalDataSet();
            this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.AnalysisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.log_btn3z.Location = new System.Drawing.Point(787, 59);
            this.log_btn3z.Name = "log_btn3z";
            this.log_btn3z.Size = new System.Drawing.Size(85, 25);
            this.log_btn3z.TabIndex = 3;
            this.log_btn3z.Text = "Back";
            this.log_btn3z.UseVisualStyleBackColor = true;
            this.log_btn3z.Click += new System.EventHandler(this.log_btn3z_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.analysisBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(189, 115);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelAngle = 20;
            series1.LabelForeColor = System.Drawing.Color.DimGray;
            series1.Legend = "Legend1";
            series1.MarkerSize = 17;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
            series1.Name = "Analysis";
            series1.XValueMember = "Type of analysis";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueMembers = "Date created";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(615, 323);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
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
            // statis_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.log_btn3z);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "statis_adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.statis_adm_FormClosing);
            this.Load += new System.EventHandler(this.statis_adm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button log_btn3z;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource analysisBindingSource;
        private HospitalDataSetTableAdapters.AnalysisTableAdapter analysisTableAdapter;
    }
}