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
                <th>ID Médicament</th>
                <th>Effet</th>
                <th>Description</th>
                <th>Type</th>
            </tr>
        </thead>
        <tbody>

            
            <?php
            include("../Bdconnect.php");

            if (isset($_GET['medicament_id']) && isset($_GET['type'])) {
                $medicament_id = $_GET['medicament_id'];
                $type = $_GET['type'];

                
                $query = "SELECT * FROM effets_therapeutiques WHERE id_medicament = $medicament_id AND type = '$type'";
                $result = $conn->query($query);

                if ($result->num_rows > 0) {
                    while ($row = $result->fetch_assoc()) {
                        echo "<tr>";
                        echo "<td>" . $row['id'] . "</td>";
                        echo "<td>" . $row['id_medicament'] . "</td>";
                        echo "<td>" . $row['effet'] . "</td>";
                        echo "<td>" . $row['description'] . "</td>";
                        echo "<td>" . $row['type'] . "</td>";
                        echo "</tr>";
                    }
                } else {
                    echo "<tr><td colspan='5'>Aucun effet trouvé pour ce médicament.</td></tr>";
                }
            } else {
                echo "<tr><td colspan='5'>Erreur: Paramètres manquants dans l'URL.</td></tr>";
            }

            $conn->close();
            ?>
        </tbody>
    </table>
</body>
</html>
