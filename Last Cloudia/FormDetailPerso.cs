using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last_Cloudia
{
    public partial class FormDetailPerso : Form
    {
        public FormDetailPerso()
        {
            InitializeComponent();
        }

        private void FormDetailPerso_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'last_cloudiaDataSet2.v_personnagecomp'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.v_personnagecompTableAdapter.Fill(this.last_cloudiaDataSet2.v_personnagecomp);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_personnagecompTableAdapter.FillBy(this.last_cloudiaDataSet2.v_personnagecomp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void selectToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_personnagecompTableAdapter.select(this.last_cloudiaDataSet2.v_personnagecomp, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void testToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_personnagecompTableAdapter.Test(this.last_cloudiaDataSet2.v_personnagecomp, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_personnagecompTableAdapter.FillBy2(this.last_cloudiaDataSet2.v_personnagecomp, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
