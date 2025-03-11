<?php

$servername = 'localhost';
$username = 'root';
$password = '';
$dbname = 'projetweb';

$conn = new mysqli($servername, $username, $password, $dbname);

// Vérification de la connexion
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Initialisation des variables
$email = $profession = "";
$emailErr = $professionErr = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Validation de l'email
    if (empty($_POST["email"])) {
        $emailErr = "Email requis";
    } else {
        $email = test_input($_POST["email"]);
    }

    // Validation de la profession
    if (empty($_POST["profession"])) {
        $professionErr = "Profession requise";
    } else {
        $profession = test_input($_POST["profession"]);
    }

    // Vérification des informations dans la base de données
    if (empty($emailErr) && empty($professionErr)) {
        $sql = "SELECT * FROM utilisateurs WHERE e_mail = '$email' AND profession = '$profession'";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) {
            // Redirection vers la page d'accueil si les informations sont correctes
            header("Location: ../Controleur/accueil.php");
            exit();
        } else {
            // Message d'erreur si les informations ne sont pas correctes
            $loginErr = "Email ou profession incorrecte";
        }
    }
}

// Fonction pour nettoyer les données
function test_input($data) {
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}

$conn->close();
?>

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Connexion</title>
    <link rel="stylesheet" href="../styles.css">
</head>
<body>
    <h2>Connexion</h2>
    <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">
        <label>Email:</label>
        <input type="text" name="email">
        <span class="error"><?php echo $emailErr; ?></span>
        <br><br>
        <label>Profession:</label>
        <input type="text" name="profession">
        <span class="error"><?php echo $professionErr; ?></span>
        <br><br>
        <input type="submit" name="submit" value="Se connecter">
        <br><br>
    </form>
    <!-- Formulaire d'inscription -->
    <form action="inscription.html" method="post">
        <input type="submit" value="S'inscrire">
    </form>
    <span class="error"><?php echo $loginErr; ?></span>
</body>
</html>
