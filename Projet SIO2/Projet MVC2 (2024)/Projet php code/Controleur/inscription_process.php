<?php
session_start(); // Démarrez la session

try {
    // Connexion à la base de données
    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "projetweb";

    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    // Récupérer les données du formulaire
    $nom = $_POST["nom"];
    $prenom = $_POST["prenom"];
    $profession = $_POST["profession"];
    $email = $_POST["email"];

    // Insérer les données dans la base de données
    $sql = "INSERT INTO utilisateurs (nom, prenom, profession, e_mail) VALUES (:nom, :prenom, :profession, :email)";
    $stmt = $conn->prepare($sql);

    // Liaison des paramètres
    $stmt->bindParam(':nom', $nom);
    $stmt->bindParam(':prenom', $prenom);
    $stmt->bindParam(':profession', $profession);
    $stmt->bindParam(':email', $email);

    if ($stmt->execute()) {
        // Récupérer l'ID de l'utilisateur nouvellement inscrit
        $id_utilisateur = $conn->lastInsertId();

        // Stocker l'ID de l'utilisateur dans la session
        $_SESSION['id_utilisateur'] = $id_utilisateur;

        // Redirection vers accueil.php après inscription réussie
        header("Location: accueil.php");
        exit(); // Assure que le script s'arrête après la redirection
    } else {
        echo "Erreur : " . $sql . "<br>" . $conn->error;
    }
} catch(PDOException $e) {
    echo "La connexion à la base de données a échoué : " . $e->getMessage();
}
?>
