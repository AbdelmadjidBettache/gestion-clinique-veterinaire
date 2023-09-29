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
    public partial class Ajouter_Chat : Form
    {
        private List<Chat> listeChat;
        private Proprietaire proprietaire;
        public Ajouter_Chat()
        {
            InitializeComponent();
            
        }

        internal List<Chat> ListeChat { get => listeChat; set => listeChat = value; }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text) && !string.IsNullOrEmpty(txt_nom.Text)
                && !string.IsNullOrEmpty(txt_race.Text) 
                && !string.IsNullOrEmpty(txt_proprietaire.Text) )
            {
                //string code_propr = txt_proprietaire.Text;
                //Proprietaire proprietaire = ObtenirProprietaireParIdentifiant(identifiantProprietaire); 
                Chat chat= new Chat(txt_id.Text,txt_nom.Text,txt_race.Text, txt_proprietaire.Text);
                 Program.clinique.AjouterChat(chat);

                

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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_nom.Text = string.Empty;
            txt_race.Text = string.Empty;
            txt_proprietaire.Text = "";
        }
    }
}
