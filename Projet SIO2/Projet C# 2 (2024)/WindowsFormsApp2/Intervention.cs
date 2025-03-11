
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Intervention
    {
        private string datecreation;
        private string objet;
        private string niveauurgence;
        private string etat;
        private string idtechnicien;
        private string nom;
        private int matricule;

        public string Datecreation { get => datecreation; set => datecreation = value; }
        public string Objet { get => objet; set => objet = value; }
        public string Niveauurgence { get => niveauurgence; set => niveauurgence = value; }
        public string Etat { get => etat; set => etat = value; }

        public string IdTechnicien { get => idtechnicien; set => idtechnicien = value; }

        public string Nom { get => nom; set => nom = value; }

        public int Matricule { get => matricule; set => matricule = value; }

        public Intervention(string datecreation, string objet, string niveauurgence, string etat, string nom, string idtechnicien, int matricule)
        {
            this.Datecreation = datecreation;
            this.Objet = objet;
            this.IdTechnicien = idtechnicien;
            this.Nom = nom;
            this.Niveauurgence = niveauurgence;
            this.Matricule = matricule;
        }
    }
}
