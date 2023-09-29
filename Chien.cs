using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    internal class Chien : Animal //classe chien qui herite de la classe animal
    {
        private string Identifiant_Chien;
        //constructeur
        public Chien(string identifiant, string nom, string race, string id_proprietaire) : base(nom, race, id_proprietaire)
        {
            this.Identifiant_Chien1 = identifiant;
        }

        //getter and setter
        public string Identifiant_Chien1 { get => Identifiant_Chien; set => Identifiant_Chien = value; }
    }
}
