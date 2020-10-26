<?php

$host     = 'localhost';
$user     = 'root';
$password = '';
$db       = 'pc_be_modul3';

$conn = mysqli_connect($host, $user, $password, $db);
    if(!$conn) {
        die ("Koneksi gagal");
    }
?>