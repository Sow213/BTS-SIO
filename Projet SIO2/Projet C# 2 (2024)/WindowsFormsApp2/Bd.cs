using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    internal class Bd
    {

        static string connStr = "Server=127.0.0.1; Database=gsb; Uid=root;Password=;SslMode=none";
        static MySqlConnection conn=new MySqlConnection(connStr);
        static void insertTechnicien(Technicien untechnicien)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO tabTechnicien VALUES (@id, @Competence, @Niveauintervention, @Formation)";
            cmd.Parameters.AddWithValue("@id", untechnicien.Idtechnicien);
            cmd.Parameters.AddWithValue("@Competences", untechnicien.Competences);
            cmd.Parameters.AddWithValue("@Niveauintervention", untechnicien.Niveauintervention);
            cmd.Parameters.AddWithValue("@Formation", untechnicien.Formation);
            cmd.Parameters.AddWithValue("@Matricule", untechnicien.Matricule);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        static void insertPersonnel(Personnel unPersonnel)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO tabPersonnel VALUES (@Matricule, @nom, @prenom, @Dateembauche)";
            cmd.Parameters.AddWithValue("@Matricule", unPersonnel.Matricule);
            cmd.Parameters.AddWithValue("@nom", unPersonnel.Nom);
            cmd.Parameters.AddWithValue("@prenom", unPersonnel.Prenom);
            cmd.Parameters.AddWithValue("@Date_d_embauche", unPersonnel.Dateembauche);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        static void insertMateriel(Materiel unMateriel)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO tabMateriel VALUES (@nom, @description, @stock, @prix, @fournisseur, @dateajout, @datedernieremaj)";
            cmd.Parameters.AddWithValue("@Nom", unMateriel.Nom);
            cmd.Parameters.AddWithValue("@Description", unMateriel.Description);
            cmd.Parameters.AddWithValue("@Stock", unMateriel.Stock);
            cmd.Parameters.AddWithValue("@Prix", unMateriel.Prix);
            cmd.Parameters.AddWithValue("@Fournisseur", unMateriel.Fournisseur);
            cmd.Parameters.AddWithValue("@Date_Ajout", unMateriel.Dateajout);
            cmd.Parameters.AddWithValue("@Date_derniere_maj", unMateriel.Datedernieremaj);
            cmd.Parameters.AddWithValue("@Matricule", unMateriel.Matricule);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void insertIntervention(Intervention uneIntervention)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO intervention VALUES (@datecreation, @objet, @niveauurgence, @etat, @idtechnicien, @nom, @matricule)";
            cmd.Parameters.AddWithValue("@Datecreation", uneIntervention.Datecreation);
            cmd.Parameters.AddWithValue("@Objet", uneIntervention.Objet);
            cmd.Parameters.AddWithValue("@Niveauurgence", uneIntervention.Niveauurgence);
            cmd.Parameters.AddWithValue("@Etat", uneIntervention.Etat);
            cmd.Parameters.AddWithValue("@Idtechnicien", uneIntervention.IdTechnicien);
            cmd.Parameters.AddWithValue("@Nom", uneIntervention.Nom);
            cmd.Parameters.AddWithValue("@Matricule", uneIntervention.Matricule);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static List<Materiel> getlesMateriels()
        {
            List<Materiel> lesMateriels = new List<Materiel>();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM materiel";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lesMateriels.Add(new Materiel(Convert.ToString(reader["Nom"]), Convert.ToString(reader["Description"]), Convert.ToString(reader["Stock"]), Convert.ToInt16(reader["Prix"]), Convert.ToString(reader["Fournisseur"]), Convert.ToString(reader["Dateajout"]), Convert.ToString(reader["Datedernieremaj"]), Convert.ToInt16(reader["Matricule"])));
            }


            return lesMateriels;
        }

        static List<Technicien> getlesTechnicien()
        {
            List<Technicien> lesTechnicien = new List<Technicien>();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM technicien";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lesTechnicien.Add(new Technicien(Convert.ToInt16(reader["Idtechnicien"]), Convert.ToString(reader["Competences"]), Convert.ToString(reader["Niveauintervation"]), Convert.ToString(reader["Formation"]), Convert.ToInt16(reader["Matricule"])));
            }


            return lesTechnicien;
        }


        static List<Personnel> getlesPersonnel()
        {
            List<Personnel> lesPersonnel = new List<Personnel>();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM personnel";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lesPersonnel.Add(new Personnel(Convert.ToInt16(reader["Matricule"]), Convert.ToString(reader["Prenom"]), Convert.ToString(reader["Dateembauche"]), Convert.ToString(reader["Nom"])));
            }


            return lesPersonnel;
        }

        static List<Intervention> getlesintervation()
        {
            List<Intervention> lesintervation = new List<Intervention>();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM intervation";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lesintervation.Add(new Intervention(Convert.ToString(reader["Datedecreation"]), Convert.ToString(reader["Objet"]), Convert.ToString(reader["Niveauurgence"]), Convert.ToString(reader["Etat"]), Convert.ToString(reader["Idtechnicien"]), Convert.ToString(reader["Nom"]), Convert.ToInt16(reader["Matricule"])));
            }


            return lesintervation;
        }


    }
}
