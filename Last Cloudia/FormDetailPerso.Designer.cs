
namespace Last_Cloudia
{
    partial class FormDetailPerso
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
            this.nomCompetenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpersonnagecompBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_cloudiaDataSet2 = new Last_Cloudia.last_cloudiaDataSet2();
            this.v_personnagecompTableAdapter = new Last_Cloudia.last_cloudiaDataSet2TableAdapters.v_personnagecompTableAdapter();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpersonnagecompBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet2)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCompetenceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vpersonnagecompBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(302, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomCompetenceDataGridViewTextBoxColumn
            // 
            this.nomCompetenceDataGridViewTextBoxColumn.DataPropertyName = "nomCompetence";
            this.nomCompetenceDataGridViewTextBoxColumn.HeaderText = "Competence";
            this.nomCompetenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCompetenceDataGridViewTextBoxColumn.Name = "nomCompetenceDataGridViewTextBoxColumn";
            this.nomCompetenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCompetenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // vpersonnagecompBindingSource
            // 
            this.vpersonnagecompBindingSource.DataMember = "v_personnagecomp";
            this.vpersonnagecompBindingSource.DataSource = this.last_cloudiaDataSet2;
            // 
            // last_cloudiaDataSet2
            // 
            this.last_cloudiaDataSet2.DataSetName = "last_cloudiaDataSet2";
            this.last_cloudiaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_personnagecompTableAdapter
            // 
            this.v_personnagecompTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(800, 31);
            this.fillBy2ToolStrip.TabIndex = 1;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(85, 28);
            this.param1ToolStripLabel.Text = "Personnage";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.param1ToolStripTextBox.CausesValidation = false;
            this.param1ToolStripTextBox.Items.AddRange(new object[] {
            "Ice General Zekus",
            "Kyle the Swordsman",
            "Lilebette of the Blaze",
            "Magic Beast Rei",
            "Mysterious Girl Theria"});
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(250, 31);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(51, 28);
            this.fillBy2ToolStripButton.Text = "Filtrer";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // FormDetailPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDetailPerso";
            this.Text = "Details ";
            this.Load += new System.EventHandler(this.FormDetailPerso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpersonnagecompBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_cloudiaDataSet2)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private last_cloudiaDataSet2 last_cloudiaDataSet2;
        private System.Windows.Forms.BindingSource vpersonnagecompBindingSource;
        private last_cloudiaDataSet2TableAdapters.v_personnagecompTableAdapter v_personnagecompTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompetenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.ToolStripComboBox param1ToolStripTextBox;
    }
}