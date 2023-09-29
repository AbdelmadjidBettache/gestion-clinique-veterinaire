using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    internal class Personne
    {
        private string _nom;
        private string _prenom;

        public Personne(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
    }
}
