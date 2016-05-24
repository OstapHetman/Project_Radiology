namespace Project_Radiology
{
    partial class Analysis_Engineer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis_Engineer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back_btn12 = new System.Windows.Forms.Button();
            this.hospitalDataSet = new Project_Radiology.HospitalDataSet();
            this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.AnalysisTableAdapter();
            this.tableAdapterManager = new Project_Radiology.HospitalDataSetTableAdapters.TableAdapterManager();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.DiagnosisTableAdapter();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.PatientTableAdapter();
            this.analysisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fKTypeOfAnalysisAnalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_of_analysisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.Type_of_analysisTableAdapter();
            this.analysisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.analysisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTypeOfAnalysisAnalysisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTypeOfAnalysisAnalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTypeOfAnalysisAnalysisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn12
            // 
            this.back_btn12.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn12.ForeColor = System.Drawing.Color.DimGray;
            this.back_btn12.Image = ((System.Drawing.Image)(resources.GetObject("back_btn12.Image")));
            this.back_btn12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn12.Location = new System.Drawing.Point(788, 60);
            this.back_btn12.Name = "back_btn12";
            this.back_btn12.Size = new System.Drawing.Size(85, 25);
            this.back_btn12.TabIndex = 2;
            this.back_btn12.Text = "Back";
            this.back_btn12.UseVisualStyleBackColor = true;
            this.back_btn12.Click += new System.EventHandler(this.back_btn12_Click);
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
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "Diagnosis";
            this.diagnosisBindingSource.DataSource = this.hospitalDataSet;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // analysisBindingSource1
            // 
            this.analysisBindingSource1.DataMember = "Analysis";
            this.analysisBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(148, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(58, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "LaboratoryID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fKTypeOfAnalysisAnalysisBindingSource
            // 
            this.fKTypeOfAnalysisAnalysisBindingSource.DataMember = "FK_Type of analysis_Analysis";
            this.fKTypeOfAnalysisAnalysisBindingSource.DataSource = this.analysisBindingSource;
            // 
            // type_of_analysisTableAdapter
            // 
            this.type_of_analysisTableAdapter.ClearBeforeFill = true;
            // 
            // analysisDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            this.analysisDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.analysisDataGridView.AutoGenerateColumns = false;
            this.analysisDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.analysisDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analysisDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.analysisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.analysisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analysisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.analysisDataGridView.DataSource = this.analysisBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.analysisDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.analysisDataGridView.GridColor = System.Drawing.Color.DimGray;
            this.analysisDataGridView.Location = new System.Drawing.Point(139, 154);
            this.analysisDataGridView.Name = "analysisDataGridView";
            this.analysisDataGridView.Size = new System.Drawing.Size(652, 277);
            this.analysisDataGridView.TabIndex = 9;
            this.analysisDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.analysisDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_laboratory";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type of analysis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type of analysis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State of analysis";
            this.dataGridViewTextBoxColumn3.DataSource = this.analysisBindingSource2;
            this.dataGridViewTextBoxColumn3.DisplayMember = "State of analysis";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn3.HeaderText = "State of analysis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "State of analysis";
            // 
            // analysisBindingSource2
            // 
            this.analysisBindingSource2.DataMember = "Analysis";
            this.analysisBindingSource2.DataSource = this.hospitalDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date created";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date created";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn5.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Patient_SSN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Patient_SSN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // fKTypeOfAnalysisAnalysisBindingSource1
            // 
            this.fKTypeOfAnalysisAnalysisBindingSource1.DataMember = "FK_Type of analysis_Analysis";
            this.fKTypeOfAnalysisAnalysisBindingSource1.DataSource = this.analysisBindingSource1;
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.Image")));
            this.Save_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Save_btn.Location = new System.Drawing.Point(788, 437);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(85, 25);
            this.Save_btn.TabIndex = 10;
            this.Save_btn.Text = "Save changes";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Analysis_Engineer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.analysisDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back_btn12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Analysis_Engineer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Analysis_Engineer_FormClosing);
            this.Load += new System.EventHandler(this.Analysis_Engineer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTypeOfAnalysisAnalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTypeOfAnalysisAnalysisBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn12;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource analysisBindingSource;
        private HospitalDataSetTableAdapters.AnalysisTableAdapter analysisTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private HospitalDataSetTableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fKTypeOfAnalysisAnalysisBindingSource;
        private HospitalDataSetTableAdapters.Type_of_analysisTableAdapter type_of_analysisTableAdapter;
        private System.Windows.Forms.BindingSource analysisBindingSource1;
        private System.Windows.Forms.DataGridView analysisDataGridView;
        private System.Windows.Forms.BindingSource fKTypeOfAnalysisAnalysisBindingSource1;
        private System.Windows.Forms.BindingSource analysisBindingSource2;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}