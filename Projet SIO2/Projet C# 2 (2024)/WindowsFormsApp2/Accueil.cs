using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe.");
                return;
            }

            string statut = "";
            if (radioButtonutilisateur.Checked)
            {
                statut = "Utilisateur";
            }
            else if (radioButtonrtechnicien.Checked)
            {
                statut = "Technicien";
            }
            else if (radioButtonresponsable.Checked)
            {
                statut = "Responsable";
            }


            if (statut == "Utilisateur")
            {

                MessageBox.Show("Redirection vers la page de l'utilisateur.");
                tabControl1.SelectTab("Incident");

            }
            else if (statut == "Technicien")
            {

                MessageBox.Show("Redirection vers la page du technicien.");
                tabControl1.SelectTab("Technicien");

            }
            else if (statut == "Responsable")
            {

                MessageBox.Show("Redirection vers la page du responsable.");
                tabControl1.SelectTab("Responsable");

            }

        }

        private void buttonEnregsitrerincident_Click(object sender, EventArgs e)
        {

            int matricule = Convert.ToInt16(textBoxMatricule.Text);
            string nom = textBoxnom.Text;
            string probleme = textBoxProbleme.Text;
            string niveauIntervention = comboBoxNv.Text;
            // string niveauIntervention = comboBoxNv.SelectedItem.ToString();

            Intervention unIncident = new Intervention(Convert.ToString(DateTime.Now), probleme, niveauIntervention, "déclaré", nom, null, matricule);
            Bd.insertIntervention(unIncident);



        }

        private void Accueil_Load(object sender, EventArgs e)
        {


        }

        private void buttonafficherincident_Click(object sender, EventArgs e)
        {

            string matricule = textBoxMatricule.Text;
            string poste = textBoxnom.Text;
            string probleme = textBoxProbleme.Text;
            string niveauIntervention = comboBoxNv.Text;


            string information = $"{matricule}, {poste}, {probleme}, {niveauIntervention}";

            listBoxincident.Items.Add(information);

          

        }
    }
}
    
  

