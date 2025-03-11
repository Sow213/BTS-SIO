<?php
include("Bdconnect.php");

$request_method = $_SERVER["REQUEST_METHOD"];

switch ($request_method) {
    case 'GET':
        if (!empty($_GET["id"])) {
            $id = intval($_GET["id"]);
            getMedicament($id);
        } else {
            getMedicaments();
        }
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}

function getMedicaments() {
    global $conn;

    $query = "SELECT * FROM medicaments";
    $response = array();
    $result = $conn->query($query);

    while ($row = $result->fetch_assoc()) {
        $response[] = $row;
    }

    header('Content-Type: application/json');
    echo json_encode($response, JSON_PRETTY_PRINT);
}

function getMedicament($id) {
    global $conn;

    $query = "SELECT * FROM medicaments WHERE Id_Medicaments =" . $id;
    $result = $conn->query($query);
    $response = array();

    while ($row = $result->fetch_assoc()) {
        $response[] = $row;
    }

    header('Content-Type: application/json');
    echo json_encode($response, JSON_PRETTY_PRINT);
}
?>
