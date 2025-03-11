<?php
// Assurez-vous que vous avez déjà ouvert une connexion à la base de données ici

$servername = 'localhost';
$username = 'root';
$password = '';
$dbname = 'projetweb';

$conn = new mysqli($servername, $username, $password, $dbname);

// Vérifier la connexion
if ($conn->connect_error) {
    die("Erreur de connexion à la base de données : " . $conn->connect_error);
}

if(isset($_POST['inscription'])) {
    $id_activite = $_POST['id_activite'];
    $id_utilisateur = $_POST['id_utilisateur'];

    // Insertion de l'inscription dans la table `inscription`
    $requete_inscription = "INSERT INTO inscription (Id_Utilisateurs, Id_Activites) VALUES ('$id_utilisateur', '$id_activite')";

    if ($conn->query($requete_inscription) === TRUE) {
        echo "Vous êtes inscrit à l'activité avec succès.";
    } else {
        echo "Erreur lors de l'inscription à l'activité : " . $conn->error;
    }
}

// Fermez la connexion à la base de données ici si nécessaire
$conn->close();
?>
