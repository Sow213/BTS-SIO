<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Afficher les Effets</title>
    <link rel="stylesheet" href="../styles.css">
</head>
<body>
    <h1>Effets du Médicament</h1>
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Effet</th>
                <th>Description</th>
                <th>Type</th>
            </tr>
        </thead>
        <tbody>
            <?php
            include("../Bdconnect.php");

            // Vérifier si les paramètres sont présents dans l'URL
            if (isset($_GET['medicament_id']) && isset($_GET['type'])) {
                $medicament_id = $_GET['medicament_id'];
                $type = $_GET['type'];

                // Sélectionner la bonne table en fonction du type d'effet
                $table = ($type === 'therapeutique') ? 'effets_therapeutiques' : 'effets_secondaires';

                $query = "SELECT * FROM $table WHERE id_medicament = $medicament_id";
                $result = $conn->query($query);

                // Afficher les résultats dans un tableau
                if ($result->num_rows > 0) {
                    while ($row = $result->fetch_assoc()) {
                        echo "<tr>";
                        echo "<td>" . $row['id'] . "</td>";
                        echo "<td>" . $row['effet'] . "</td>";
                        echo "<td>" . $row['description'] . "</td>";
                        echo "<td>" . $row['type'] . "</td>";
                        echo "</tr>";
                    }
                } else {
                    echo "<tr><td colspan='4'>Aucun effet trouvé pour ce médicament.</td></tr>";
                }
            } else {
                echo "<tr><td colspan='4'>Erreur: Paramètres manquants dans l'URL.</td></tr>";
            }

            $conn->close();
            ?>
        </tbody>
    </table>
    <br>
</body>
</html>











    <!-- Bouton de retour à la page précédente -->
    <button onclick="history.go(-1);">Retour</button>
</body>
</html>
