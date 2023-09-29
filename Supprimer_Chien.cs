using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final
{
    public partial class Supprimer_Chien : Form
    {
        private List<Chien> chienes;
        public Supprimer_Chien()
        {
            InitializeComponent();
        }

        internal List<Chien> Chienes { get => chienes; set => chienes = value; }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string idChien = txt_id.Text;
            Chien chienASupprimer = chienes.FirstOrDefault(p => p.Identifiant_Chien1 == idChien);

            if (chienASupprimer != null)
            {
                chienes.Remove(chienASupprimer);
                MessageBox.Show("Le chien a été supprimé avec succès.");
                txt_id.Text = "";
                txt_nom.Text = "";
                txt_race.Text = "";
                txt_proprietaire.Text = "";
                
            }
            else
            {
                MessageBox.Show("Impossible de trouver le chien avec l'ID spécifié.");
            }
        }

        private void btn_rechrche_Click(object sender, EventArgs e)
        {
            string idchien = txt_id.Text;
            Chien chienRecherche = chienes.FirstOrDefault(p => p.Identifiant_Chien1 == idchien);

            if (chienRecherche != null)
            {
                txt_id.Text = chienRecherche.Identifiant_Chien1;
                txt_nom.Text = chienRecherche.Nom1;
                txt_race.Text = chienRecherche.Race1;
                txt_proprietaire.Text = chienRecherche.Id_proprietaire;

                //ReadOnly = Validate;
                //Validate ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Programme n'existe pas! Entrer un ID valide.");
            }
        }

        private void Supprimer_Chien_Load(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nom_Click(object sender, EventArgs e)
        {

        }

        private void ibi_race_Click(object sender, EventArgs e)
        {

        }

        private void lbl_proprietaire_Click(object sender, EventArgs e)
        {

        }

        private void txt_proprietaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_race_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
