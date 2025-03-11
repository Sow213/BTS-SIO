<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nom = $_POST["nom"];
    $prenom = $_POST["prenom"];
    $email = $_POST["email"];
    
    // Enregistrez les données dans la base de données ou utilisez une autre méthode de stockage.
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Accueil</title>
    <link rel="stylesheet" href="../styles.css">
</head>
<body>
    <div class="container">
        <h1>Accueil</h1>
        <nav>
            <ul>
                <li><a href="../Vue/medicaments.php">Médicaments</a></li>
                <li><a href="../Modele/activites.php">Activités</a></li>
                <li><a href="../Modele/juridique.php">Mentions légales</a></li>
                <a href="../Vue/connexion.php">Déconnexion</a>
            </ul>
        </nav>
    </div>
</body>
</html>
