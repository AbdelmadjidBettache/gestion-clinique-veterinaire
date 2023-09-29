using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final
{
    internal class Clinique// classe qui englobe tous les listes
    {
        private List<Animal> animals;
        private List<Chat> chats;
        private List<Chien> chiens;
        private List<Proprietaire> propries;

        public Clinique()//constructeur
        {
            animals = new List<Animal>();
            chats = new List<Chat>();
            chiens = new List<Chien>();
            propries = new List<Proprietaire>();
        }
        //getter and setter
        internal List<Animal> Animals { get => animals; set => animals = value; }
        internal List<Chat> Chats { get => chats; set => chats = value; }
        internal List<Chien> Chiens { get => chiens; set => chiens = value; }
        internal List<Proprietaire> Propries { get => propries; set => propries = value; }

        //methode pour ajouter un chat dans la liste 
        public void AjouterChat(Chat chat)
        {
            int index = RechercherChat(chat.Identifiant_Chat1);
            if (index == -1)
            {
                chats.Add(chat);
                MessageBox.Show(" Un chat est ajoute");
            }
            else
                MessageBox.Show(" chat existe deja");
        }

        //methode pour la recherche d'un chat dans la liste es chats
        public int RechercherChat(string code)
        {
            int index = -1;
            int i = 0;
            Boolean trouve = false;
            while (i < chats.Count && !trouve)
            {
                if (chats[i].Identifiant_Chat1.ToUpper().Equals(code))
                    index = i;
                trouve = true;

            }
            return index;
        }

        //methode pour ajouter un chien 
        public void AjouterChien(Chien chien)
        {
            int index = RechercherChat(chien.Identifiant_Chien1);
            if (index == -1)
            {
                chiens.Add(chien);
                MessageBox.Show(" Un chien est ajoute");
            }
            else
                MessageBox.Show(" chien existe deja");
        }

        //methode pour la recherche d'un chiendans la liste es chiens
        public int RechercherChien(string code)
        {
            int index = -1;
            int i = 0;
            Boolean trouve = false;
            while (i < chats.Count && !trouve)
            {
                if (chiens[i].Identifiant_Chien1.ToUpper().Equals(code))
                    index = i;
                trouve = true;

            }
            return index;
        }





    }
}
