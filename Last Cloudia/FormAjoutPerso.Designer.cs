
namespace Last_Cloudia
{
    partial class FormAjoutPerso
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
            this.personnageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastcloudiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_cloudiaDataSet = new Last_Cloudia.last_cloudiaDataSet();
            this.personnageTableAdapter = new Last_Cloudia.last_cloudiaDataSetTableAdapters.personnageTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nomPersoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastcloudiaDataSetBindingSource)).BeginInit();
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
            this.nomPersoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(377, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // personnageBindingSource
            // 
            this.personnageBindingSource.DataMember = "personnage";
            this.personnageBindingSource.DataSource = this.lastcloudiaDataSetBindingSource;
            // 
            // lastcloudiaDataSetBindingSource
            // 
            this.lastcloudiaDataSetBindingSource.DataSource = this.last_cloudiaDataSet;
            this.lastcloudiaDataSetBindingSource.Position = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des personnages déjà sauvegardés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom du Personnage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description du Personnage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Notes supplémentaires";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(581, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 93);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(581, 327);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 67);
            this.textBox3.TabIndex = 8;
            // 
            // nomPersoDataGridViewTextBoxColumn
            // 
            this.nomPersoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomPersoDataGridViewTextBoxColumn.DataPropertyName = "nomPerso";
            this.nomPersoDataGridViewTextBoxColumn.HeaderText = "nomPerso";
            this.nomPersoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomPersoDataGridViewTextBoxColumn.Name = "nomPersoDataGridViewTextBoxColumn";
            this.nomPersoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPersoDataGridViewTextBoxColumn.Width = 101;
            // 
            // FormAjoutPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAjoutPerso";
            this.Text = "FormAjoutPerso";
            this.Load += new System.EventHandler(this.FormAjoutPerso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastcloudiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lastcloudiaDataSetBindingSource;
        private last_cloudiaDataSet last_cloudiaDataSet;
        private System.Windows.Forms.BindingSource personnageBindingSource;
        private last_cloudiaDataSetTableAdapters.personnageTableAdapter personnageTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPersoDataGridViewTextBoxColumn;
    }
}