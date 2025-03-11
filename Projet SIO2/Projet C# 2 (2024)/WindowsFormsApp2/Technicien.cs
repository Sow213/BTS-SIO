using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Technicien
    {
        private int idtechnicien;
        private string competences;
        private string niveauintervention;
        private string formation;
        private int matricule;

        public int Idtechnicien { get => idtechnicien; set => idtechnicien = value; }
        public string Competences { get => competences; set => competences = value; }
        public string Niveauintervention { get => niveauintervention; set => niveauintervention = value; }
        public string Formation { get => formation; set => formation = value; }
        public int Matricule { get => matricule; set => matricule = value; }
        public Technicien(int idtechnicien, string competences, string niveauintervention, string formation, int matricule)
        {
            this.Idtechnicien = idtechnicien;
            this.Competences = competences;
            this.Niveauintervention = niveauintervention;
            this.Formation = formation;
            this.Matricule = matricule;
        }
    }

}


