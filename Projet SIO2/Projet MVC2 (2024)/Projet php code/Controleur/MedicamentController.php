<?php
require_once('../Modele/MedicamentModel.php');

class MedicamentController {
    public function afficherMedicaments() {
        $medicamentModel = new MedicamentModel();
        $medicaments = $medicamentModel->getAllMedicaments();
        require('../Vue/medicaments.php');
    }
}
?>
