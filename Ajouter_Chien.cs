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
    public partial class Ajouter_Chien : Form
    {
        
        private List<Chien> listeChat;
        public Ajouter_Chien()
        {
            InitializeComponent();
        }

        internal List<Chien> ListeChat { get => listeChat; set => listeChat = value; }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text) && !string.IsNullOrEmpty(txt_nom.Text)
                && !string.IsNullOrEmpty(txt_race.Text)
                && !string.IsNullOrEmpty(txt_proprietaire.Text))
            {
                string code_propr = txt_proprietaire.Text;
                
                Chien chien = new Chien(txt_id.Text, txt_nom.Text, txt_race.Text, code_propr);
                Program.clinique.AjouterChien(chien);



            }
            else
                MessageBox.Show(" remplir tout les champs", " erreur");

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
