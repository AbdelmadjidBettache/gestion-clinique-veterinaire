using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    internal class Animal
    {
        private string Nom;
        private string Race;
        private string id_proprietaire;
        private Proprietaire Proprietaire;

        //constructeur
        public Animal(string nom, string race, string id_proprietaire)
        {
            Nom = nom;
            Race = race;
            id_proprietaire = id_proprietaire;
        }

        //getter and setter
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Race1 { get => Race; set => Race = value; }
        public string Id_proprietaire { get => id_proprietaire; set => id_proprietaire = value; }
        internal Proprietaire Proprietaire1 { get => Proprietaire; set => Proprietaire = value; }
    }
}
