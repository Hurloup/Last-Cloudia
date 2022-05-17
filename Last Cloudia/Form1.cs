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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPersonnage_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir la liste des personnages
            FormListPersonnages form2 = new FormListPersonnages();
            form2.Show();
        }

        private void button_listSkill_Click(object sender, EventArgs e)
        {
            //Permet d'ouvrir la liste des compétences
            FormListSkills form3 = new FormListSkills();
            form3.Show();
        }
    }
}
