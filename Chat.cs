using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    internal class Chat : Animal // classe chat qui herite de la classe animal
    {
        private string Identifiant_Chat;

       

        //constructeur
        public Chat(string identifiant, string nom, string race, string id_proprietaire)
            : base(nom, race, id_proprietaire)
        {
            this.Identifiant_Chat = identifiant;
        }

        //getter and setter
        public string Identifiant_Chat1 { get => Identifiant_Chat; set => Identifiant_Chat = value; }
    }
}
