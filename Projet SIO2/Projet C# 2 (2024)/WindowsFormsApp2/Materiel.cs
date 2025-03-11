using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Materiel
    {
        private string nom;
        private string description;
        private string stock;
        private int prix; 
        private string fournisseur;
        private string dateajout;
        private string datedernieremaj;
        private int matricule;

        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public string Stock { get => stock; set => stock = value; }
        public int Prix { get => prix; set => prix = value; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }
        public string Dateajout { get => dateajout; set => dateajout = value; }
        public string Datedernieremaj { get => datedernieremaj; set => datedernieremaj = value; }
        public int Matricule { get => matricule; set => matricule = value; }

        public Materiel(string nom, string description, string stock, int prix, string fournisseur, string dateajout, string datedernieremaj,int matricule)
        {
            this.Nom = nom;
            this.Description = description;
            this.Stock = stock;
            this.Prix = prix;
            this.Fournisseur = fournisseur;
            this.Dateajout = dateajout;
            this.datedernieremaj = datedernieremaj;
            this.matricule = matricule;
        }
    }
}