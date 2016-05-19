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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors_page_STATISTIC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back_btn4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hospitalDataSet = new Project_Radiology.HospitalDataSet();
            this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.AnalysisTableAdapter();
            this.tableAdapterManager = new Project_Radiology.HospitalDataSetTableAdapters.TableAdapterManager();
            this.analysisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn4
            // 
            this.back_btn4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn4.ForeColor = System.Drawing.Color.DimGray;
            this.back_btn4.Image = ((System.Drawing.Image)(resources.GetObject("back_btn4.Image")));
            this.back_btn4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn4.Location = new System.Drawing.Point(786, 60);
            this.back_btn4.Name = "back_btn4";
            this.back_btn4.Size = new System.Drawing.Size(85, 25);
            this.back_btn4.TabIndex = 2;
            this.back_btn4.Text = "Back";
            this.back_btn4.UseVisualStyleBackColor = true;
            this.back_btn4.Click += new System.EventHandler(this.back_btn4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "SSN";
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
            this.analysisDataGridView.AutoGenerateColumns = false;
            this.analysisDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.analysisDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analysisDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.analysisDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.analysisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.analysisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analysisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.analysisDataGridView.DataSource = this.analysisBindingSource;
            this.analysisDataGridView.GridColor = System.Drawing.Color.White;
            this.analysisDataGridView.Location = new System.Drawing.Point(346, 137);
            this.analysisDataGridView.Name = "analysisDataGridView";
            this.analysisDataGridView.Size = new System.Drawing.Size(261, 288);
            this.analysisDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type of analysis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type of analysis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Patient_SSN";
            this.dataGridViewTextBoxColumn6.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Doctors_page_STATISTIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.analysisDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctors_page_STATISTIC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctors_page_STATISTIC_FormClosing);
            this.Load += new System.EventHandler(this.Doctors_page_STATISTIC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource analysisBindingSource;
        private HospitalDataSetTableAdapters.AnalysisTableAdapter analysisTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView analysisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}