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
    public partial class FormListPersonnages : Form
    {
        public FormListPersonnages()
        {
            InitializeComponent();
        }

        private void FormListPersonnages_Load(object sender, EventArgs e)
        {
            //Permet d'afficher les données demander correspondant à la table correspondante de la base de données
            this.personnageTableAdapter.Fill(this.last_cloudiaDataSet.personnage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir l'ajout de personnages
            FormAjoutPerso form3 = new FormAjoutPerso();
            form3.Show();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir l'ajout de personnages
            FormDetailPerso form4 = new FormDetailPerso();
            form4.Show();
        }
    }
}
