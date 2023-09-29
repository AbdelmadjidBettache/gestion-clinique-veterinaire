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
    public partial class Afficher_Chien : Form
    {
        private List<Chien> chienes;
        private int indexActuel;
        public Afficher_Chien()
        {
            InitializeComponent();
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
                MessageBox.Show("Chien n'existe pas! Entrer un ID valide.");
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }


        //btn_afficher(j'ai oublie de renomer le button)
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (chienes.Count > 0 && indexActuel >= 0 && indexActuel < chienes.Count)
            {
                Chien chientActuel = chienes[indexActuel];
                txt_id.Text = chientActuel.Identifiant_Chien1;
                txt_nom.Text = chientActuel.Nom1;
                txt_race.Text = chientActuel.Race1;
                txt_proprietaire.Text = chientActuel.Id_proprietaire;
                
            }
            else
            {
                MessageBox.Show("Chien n'existe pas! Entrer un ID valide.");
            }

        }
    }
}
