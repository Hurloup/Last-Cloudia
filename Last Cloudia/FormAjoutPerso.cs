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
    public partial class FormAjoutPerso : Form
    {
        public FormAjoutPerso()
        {
            InitializeComponent();
        }

        private void FormAjoutPerso_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'last_cloudiaDataSet.personnage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.personnageTableAdapter.Fill(this.last_cloudiaDataSet.personnage);

        }
    }
}
