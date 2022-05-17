
namespace Last_Cloudia
{
    partial class FormListPersonnages
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
            this.nomPersoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionPersoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collaborationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_cloudiaDataSet = new Last_Cloudia.last_cloudiaDataSet();
            this.personnageTableAdapter = new Last_Cloudia.last_cloudiaDataSetTableAdapters.personnageTableAdapter();
            this.button_addPerso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomPersoDataGridViewTextBoxColumn,
            this.descriptionPersoDataGridViewTextBoxColumn,
            this.collaborationDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomPersoDataGridViewTextBoxColumn
            // 
            this.nomPersoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nomPersoDataGridViewTextBoxColumn.DataPropertyName = "nomPerso";
            this.nomPersoDataGridViewTextBoxColumn.HeaderText = "Personnage";
            this.nomPersoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomPersoDataGridViewTextBoxColumn.Name = "nomPersoDataGridViewTextBoxColumn";
            this.nomPersoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPersoDataGridViewTextBoxColumn.Width = 6;
            // 
            // descriptionPersoDataGridViewTextBoxColumn
            // 
            this.descriptionPersoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.descriptionPersoDataGridViewTextBoxColumn.DataPropertyName = "DescriptionPerso";
            this.descriptionPersoDataGridViewTextBoxColumn.HeaderText = "Description du Personnage";
            this.descriptionPersoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionPersoDataGridViewTextBoxColumn.Name = "descriptionPersoDataGridViewTextBoxColumn";
            this.descriptionPersoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionPersoDataGridViewTextBoxColumn.Width = 6;
            // 
            // collaborationDataGridViewTextBoxColumn
            // 
            this.collaborationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.collaborationDataGridViewTextBoxColumn.DataPropertyName = "Collaboration ?";
            this.collaborationDataGridViewTextBoxColumn.HeaderText = "Collaboration ?";
            this.collaborationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collaborationDataGridViewTextBoxColumn.Name = "collaborationDataGridViewTextBoxColumn";
            this.collaborationDataGridViewTextBoxColumn.ReadOnly = true;
            this.collaborationDataGridViewTextBoxColumn.Width = 121;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 6;
            // 
            // personnageBindingSource
            // 
            this.personnageBindingSource.DataMember = "personnage";
            this.personnageBindingSource.DataSource = this.last_cloudiaDataSet;
            // 
            // last_cloudiaDataSet
            // 
            this.last_cloudiaDataSet.DataSetName = "last_cloudiaDataSet";
            this.last_cloudiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnageTableAdapter
            // 
            this.personnageTableAdapter.ClearBeforeFill = true;
            // 
            // button_addPerso
            // 
            this.button_addPerso.Location = new System.Drawing.Point(1173, 12);
            this.button_addPerso.Name = "button_addPerso";
            this.button_addPerso.Size = new System.Drawing.Size(187, 38);
            this.button_addPerso.TabIndex = 1;
            this.button_addPerso.Text = "Ajout de Personages";
            this.button_addPerso.UseVisualStyleBackColor = true;
            this.button_addPerso.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1173, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modification Personnages";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(1173, 131);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(187, 38);
            this.btn_details.TabIndex = 4;
            this.btn_details.Text = "Détails";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // FormListPersonnages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 569);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_addPerso);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListPersonnages";
            this.Text = "FormListPersonnages";
            this.Load += new System.EventHandler(this.FormListPersonnages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private last_cloudiaDataSet last_cloudiaDataSet;
        private System.Windows.Forms.BindingSource personnageBindingSource;
        private last_cloudiaDataSetTableAdapters.personnageTableAdapter personnageTableAdapter;
        private System.Windows.Forms.Button button_addPerso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPersoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionPersoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collaborationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_details;
    }
}