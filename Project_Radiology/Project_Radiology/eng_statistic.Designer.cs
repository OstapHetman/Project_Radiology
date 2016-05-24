namespace Project_Radiology
{
    partial class eng_statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eng_statistic));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 123D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.log_btn3z = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hospitalDataSet = new Project_Radiology.HospitalDataSet();
            this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.AnalysisTableAdapter();
            this.tableAdapterManager = new Project_Radiology.HospitalDataSetTableAdapters.TableAdapterManager();
            this.analysisDataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analysisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // log_btn3z
            // 
            this.log_btn3z.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_btn3z.ForeColor = System.Drawing.Color.DimGray;
            this.log_btn3z.Image = ((System.Drawing.Image)(resources.GetObject("log_btn3z.Image")));
            this.log_btn3z.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log_btn3z.Location = new System.Drawing.Point(786, 61);
            this.log_btn3z.Name = "log_btn3z";
            this.log_btn3z.Size = new System.Drawing.Size(85, 25);
            this.log_btn3z.TabIndex = 4;
            this.log_btn3z.Text = "Back";
            this.log_btn3z.UseVisualStyleBackColor = true;
            this.log_btn3z.Click += new System.EventHandler(this.log_btn3z_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "LaboratoryID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(147, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AnalysisTableAdapter = this.analysisTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiagnosisTableAdapter = null;
            this.tableAdapterManager.DOCTORS_1TableAdapter = null;
            this.tableAdapterManager.Engineer_1TableAdapter = null;
            this.tableAdapterManager.HospitalTableAdapter = null;
            this.tableAdapterManager.LaboratoryTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.Type_of_analysisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_Radiology.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // analysisDataGridView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Raleway Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analysisDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.analysisDataGridView.AutoGenerateColumns = false;
            this.analysisDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.analysisDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analysisDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.analysisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.analysisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analysisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.analysisDataGridView.DataSource = this.analysisBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.analysisDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.analysisDataGridView.Location = new System.Drawing.Point(60, 110);
            this.analysisDataGridView.Name = "analysisDataGridView";
            this.analysisDataGridView.Size = new System.Drawing.Size(272, 332);
            this.analysisDataGridView.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.analysisBindingSource1;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(338, 110);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Font = new System.Drawing.Font("Raleway Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series2.Name = "Analysis";
            series2.Points.Add(dataPoint2);
            series2.XValueMember = "Type of analysis";
            series2.YValueMembers = "ID";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(533, 352);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title2.Name = "Statistic";
            this.chart1.Titles.Add(title2);
            // 
            // analysisBindingSource1
            // 
            this.analysisBindingSource1.DataMember = "Analysis";
            this.analysisBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LaboratoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type of analysis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type of analysis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // eng_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.analysisDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.log_btn3z);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eng_statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.eng_statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_btn3z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource analysisBindingSource;
        private HospitalDataSetTableAdapters.AnalysisTableAdapter analysisTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView analysisDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource analysisBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}