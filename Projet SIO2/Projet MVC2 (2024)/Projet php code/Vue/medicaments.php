<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Liste des Médicaments</title>
    <link rel="stylesheet" href="../styles.css">
</head>
<body>
    <h1>Liste des Médicaments</h1>
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Nom</th>
                <th>Description</th>
                <th>Effets</th>
            </tr>
        </thead>
        <tbody>
            <button onclick="history.go(-1);">Retour</button>
            <?php
            include("../Bdconnect.php");

            $query = "SELECT * FROM medicaments";
            $result = $conn->query($query);

            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    echo "<tr>";
                    echo "<td>" . $row['Id_Medicaments'] . "</td>";
                    echo "<td>" . $row['nom'] . "</td>";
                    echo "<td>" . $row['description'] . "</td>";
                    echo "<td>";
                    echo "<form method='get' action='afficher_effets.php'>";
                    echo "<input type='hidden' name='medicament_id' value='" . $row['Id_Medicaments'] . "'>";
                    echo "<input type='hidden' name='type' value='therapeutique'>";
                    echo "<button type='submit'>Thérapeutique</button>";
                    echo "</form>";
                    echo "<form method='get' action='afficher_effets.php'>";
                    echo "<input type='hidden' name='medicament_id' value='" . $row['Id_Medicaments'] . "'>";
                    echo "<input type='hidden' name='type' value='secondaire'>";
                    echo "<button type='submit'>Secondaire</button>";
                    echo "</form>";
                    echo "</td>";
                    echo "</tr>";
                }
            } else {
                echo "<tr><td colspan='4'>Aucun médicament trouvé</td></tr>";
            }

            $conn->close();
            ?>
        </tbody>
    </table>
</body>
</html>

