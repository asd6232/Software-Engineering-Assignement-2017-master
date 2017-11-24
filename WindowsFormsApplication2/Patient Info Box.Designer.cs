namespace WindowsFormsApplication2
{
    partial class Patient_Info_Box
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
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientInfoQueriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_Info_Queries = new WindowsFormsApplication2.Patient_Info_Queries();
            this.patientsIllnessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsMedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientsTableAdapter = new WindowsFormsApplication2.Patient_Info_QueriesTableAdapters.PatientsTableAdapter();
            this.patientsIllnessesTableAdapter = new WindowsFormsApplication2.Patient_Info_QueriesTableAdapters.PatientsIllnessesTableAdapter();
            this.patientsMedsTableAdapter = new WindowsFormsApplication2.Patient_Info_QueriesTableAdapters.PatientsMedsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoQueriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_Info_Queries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsIllnessesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsMedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientInfoQueriesBindingSource;
            // 
            // patientInfoQueriesBindingSource
            // 
            this.patientInfoQueriesBindingSource.DataSource = this.patient_Info_Queries;
            this.patientInfoQueriesBindingSource.Position = 0;
            // 
            // patient_Info_Queries
            // 
            this.patient_Info_Queries.DataSetName = "Patient_Info_Queries";
            this.patient_Info_Queries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsIllnessesBindingSource
            // 
            this.patientsIllnessesBindingSource.DataMember = "PatientsIllnesses";
            this.patientsIllnessesBindingSource.DataSource = this.patientInfoQueriesBindingSource;
            // 
            // patientsMedsBindingSource
            // 
            this.patientsMedsBindingSource.DataMember = "PatientsMeds";
            this.patientsMedsBindingSource.DataSource = this.patientInfoQueriesBindingSource;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(495, 324);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(139, 49);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.patientInfoQueriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 244);
            this.dataGridView1.TabIndex = 25;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsIllnessesTableAdapter
            // 
            this.patientsIllnessesTableAdapter.ClearBeforeFill = true;
            // 
            // patientsMedsTableAdapter
            // 
            this.patientsMedsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Patient Information";
            // 
            // Patient_Info_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patient_Info_Box";
            this.Text = "Patient_Info_Box";
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoQueriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_Info_Queries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsIllnessesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsMedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientInfoQueriesBindingSource;
        private Patient_Info_Queries patient_Info_Queries;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Patient_Info_QueriesTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsIllnessesBindingSource;
        private Patient_Info_QueriesTableAdapters.PatientsIllnessesTableAdapter patientsIllnessesTableAdapter;
        private System.Windows.Forms.BindingSource patientsMedsBindingSource;
        private Patient_Info_QueriesTableAdapters.PatientsMedsTableAdapter patientsMedsTableAdapter;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}