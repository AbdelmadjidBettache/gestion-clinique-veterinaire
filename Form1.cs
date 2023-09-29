using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Chat frm2 = new Ajouter_Chat();
            frm2.Show();
            this.Hide();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afficher_Chat frm2 = new Afficher_Chat();
            frm2.Show();
            this.Hide();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reponse =
            MessageBox.Show("Voulez-vous quitter", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajouter_Chien frm2 = new Ajouter_Chien();
            frm2.Show();
            this.Hide();

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Chien frm2 = new Supprimer_Chien();
            frm2.Show();
            this.Hide();

        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Afficher_Chien frm2 = new Afficher_Chien();
            frm2.Show();
            this.Hide();

        }
    }
}
