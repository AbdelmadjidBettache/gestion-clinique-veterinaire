using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    internal class Proprietaire : Personne //classe proprietaire qui herite de perssonne
    {
        private string Identifiant;
        private List<Animal> Animaux;

        //constructeur
        public Proprietaire(string identifiant, string nom, string prenom) : base(nom, prenom)
        {
            Identifiant1 = identifiant;
            Nom = nom;
            Prenom = prenom;
            Animaux1 = new List<Animal>();
        }

        //getter and setter
        public string Identifiant1 { get => Identifiant; set => Identifiant = value; }

        internal List<Animal> Animaux1 { get => Animaux; set => Animaux = value; }
    }
}
