namespace Project_Radiology
{
    partial class Patient_Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Diagnosis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back_btn2 = new System.Windows.Forms.Button();
            this.hospitalDataSet = new Project_Radiology.HospitalDataSet();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTableAdapter = new Project_Radiology.HospitalDataSetTableAdapters.DiagnosisTableAdapter();
            this.tableAdapterManager = new Project_Radiology.HospitalDataSetTableAdapters.TableAdapterManager();
            this.diagnosisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn2
            // 
            this.back_btn2.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn2.ForeColor = System.Drawing.Color.DimGray;
            this.back_btn2.Image = ((System.Drawing.Image)(resources.GetObject("back_btn2.Image")));
            this.back_btn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back_btn2.Location = new System.Drawing.Point(786, 59);
            this.back_btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_btn2.Name = "back_btn2";
            this.back_btn2.Size = new System.Drawing.Size(85, 25);
            this.back_btn2.TabIndex = 3;
            this.back_btn2.Text = "Back";
            this.back_btn2.UseVisualStyleBackColor = true;
            this.back_btn2.Click += new System.EventHandler(this.back_btn2_Click);
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AnalysisTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiagnosisTableAdapter = this.diagnosisTableAdapter;
            this.tableAdapterManager.DOCTORS_1TableAdapter = null;
            this.tableAdapterManager.Engineer_1TableAdapter = null;
            this.tableAdapterManager.HospitalTableAdapter = null;
            this.tableAdapterManager.LaboratoryTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.Type_of_analysisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_Radiology.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // diagnosisDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosisDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.diagnosisDataGridView.AutoGenerateColumns = false;
            this.diagnosisDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.diagnosisDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosisDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosisDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.diagnosisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.diagnosisDataGridView.DataSource = this.diagnosisBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.diagnosisDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.diagnosisDataGridView.Location = new System.Drawing.Point(255, 123);
            this.diagnosisDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diagnosisDataGridView.Name = "diagnosisDataGridView";
            this.diagnosisDataGridView.Size = new System.Drawing.Size(462, 220);
            this.diagnosisDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Analysis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Diagnosis";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 100000000;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnalysisID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Patient_SSN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.Image")));
            this.Save_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Save_btn.Location = new System.Drawing.Point(786, 438);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(85, 25);
            this.Save_btn.TabIndex = 27;
            this.Save_btn.Text = "Save changes";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(100, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Raleway Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // Patient_Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.diagnosisDataGridView);
            this.Controls.Add(this.back_btn2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient_Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient diagnosis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Patient_Diagnosis_FormClosing);
            this.Load += new System.EventHandler(this.Patient_Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn2;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private HospitalDataSetTableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView diagnosisDataGridView;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}