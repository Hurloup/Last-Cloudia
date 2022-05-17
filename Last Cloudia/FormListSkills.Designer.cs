
namespace Last_Cloudia
{
    partial class FormListSkills
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.last_cloudiaDataSet1 = new Last_Cloudia.last_cloudiaDataSet1();
            this.competenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competenceTableAdapter = new Last_Cloudia.last_cloudiaDataSet1TableAdapters.competenceTableAdapter();
            this.nomCompetenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCompetenceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.skillCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.competenceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 589);
            this.dataGridView1.TabIndex = 0;
            // 
            // last_cloudiaDataSet1
            // 
            this.last_cloudiaDataSet1.DataSetName = "last_cloudiaDataSet1";
            this.last_cloudiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competenceBindingSource
            // 
            this.competenceBindingSource.DataMember = "competence";
            this.competenceBindingSource.DataSource = this.last_cloudiaDataSet1;
            // 
            // competenceTableAdapter
            // 
            this.competenceTableAdapter.ClearBeforeFill = true;
            // 
            // nomCompetenceDataGridViewTextBoxColumn
            // 
            this.nomCompetenceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nomCompetenceDataGridViewTextBoxColumn.DataPropertyName = "nomCompetence";
            this.nomCompetenceDataGridViewTextBoxColumn.HeaderText = "nomCompetence";
            this.nomCompetenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCompetenceDataGridViewTextBoxColumn.Name = "nomCompetenceDataGridViewTextBoxColumn";
            this.nomCompetenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCompetenceDataGridViewTextBoxColumn.Width = 6;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 6;
            // 
            // skillCostDataGridViewTextBoxColumn
            // 
            this.skillCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.skillCostDataGridViewTextBoxColumn.DataPropertyName = "Skill Cost";
            this.skillCostDataGridViewTextBoxColumn.HeaderText = "Skill Cost";
            this.skillCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skillCostDataGridViewTextBoxColumn.Name = "skillCostDataGridViewTextBoxColumn";
            this.skillCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.skillCostDataGridViewTextBoxColumn.Width = 6;
            // 
            // FormListSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 625);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListSkills";
            this.Text = "FormListSkill";
            this.Load += new System.EventHandler(this.FormListSkills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private last_cloudiaDataSet1 last_cloudiaDataSet1;
        private System.Windows.Forms.BindingSource competenceBindingSource;
        private last_cloudiaDataSet1TableAdapters.competenceTableAdapter competenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompetenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillCostDataGridViewTextBoxColumn;
    }
}