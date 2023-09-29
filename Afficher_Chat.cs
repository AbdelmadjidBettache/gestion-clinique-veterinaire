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
    public partial class Afficher_Chat : Form
    {
        public Afficher_Chat()
        {
            InitializeComponent();
            affiche_liste_chats();
        }

        public void affiche_liste_chats()
        {
            for (int i = 0; i < Program.clinique.Chats.Count; i++)
            {
                dgr_chats.Rows.Add(Program.clinique.Chats[i].Identifiant_Chat1, Program.clinique.Chats[i].Nom1, Program.clinique.Chats[i].Race1, Program.clinique.Chats[i].Id_proprietaire);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
