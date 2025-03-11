<?php
class MedicamentModel {
    private $base_url = "http://localhost/project/api/";

    public function getAllMedicaments() {
        $url = $this->base_url . "api.php";
        $medicaments = file_get_contents($url);
        return json_decode($medicaments, true);
    }
}
?>
