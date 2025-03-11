using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Personnel
    {
        private int matricule;
        private string nom;
        private string prenom;
        private string dateembauche;

        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Dateembauche { get => dateembauche; set => dateembauche = value; }

        public Personnel(int matricule, string nom, string prenom, string date)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Dateembauche = date;
        }
    }
}
    



