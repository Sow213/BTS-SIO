<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Activites</title>
    <link rel="stylesheet" href="../styles.css">
</head>
<button onclick="history.go(-1);">Retour</button>
<?php
session_start(); // Démarrez la session

// Vérifier si l'utilisateur est connecté
if (!isset($_SESSION['id_utilisateur'])) {
    // Rediriger l'utilisateur vers la page de connexion s'il n'est pas connecté
    header("Location: connexion.php");
    exit();
}

// Récupérer l'ID de l'utilisateur à partir de la session
$id_utilisateur = $_SESSION['id_utilisateur'];

// Connexion à la base de données
$servername = 'localhost';
$username = 'root';
$password = '';
$dbname = 'projetweb';

$conn = new mysqli($servername, $username, $password, $dbname);

// Vérifier la connexion
if ($conn->connect_error) {
    die("Erreur de connexion à la base de données : " . $conn->connect_error);
}

// Récupérer les activités depuis la base de données
$requete = "SELECT * FROM activites";
$resultat = $conn->query($requete);

// Afficher les activités
if ($resultat->num_rows > 0) {
    while ($row = $resultat->fetch_assoc()) {
        echo "<div>";
        echo "<h2>" . $row['nom'] . "</h2>";
        echo "<p>Date : " . $row['datee'] . "</p>";
        echo "<p>Lieu : " . $row['lieu'] . "</p>";
        echo "<form action='inscription.php' method='post'>";
        echo "<input type='hidden' name='id_activite' value='" . $row['Id_Activites'] . "'>";
        echo "<input type='hidden' name='id_utilisateur' value='" . $id_utilisateur . "'>";
        echo "<input type='submit' name='inscription' value='Sinscrire'>";
        echo "</form>";
        echo "</div>";
    }
} else {
    echo "Aucune activité disponible.";
}

// Fermer la connexion à la base de données
$conn->close();
?>
