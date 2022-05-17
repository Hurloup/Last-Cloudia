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
    public partial class FormListSkills : Form
    {
        public FormListSkills()
        {
            InitializeComponent();
        }

        private void FormListSkills_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'last_cloudiaDataSet1.competence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.competenceTableAdapter.Fill(this.last_cloudiaDataSet1.competence);

        }
    }
}
