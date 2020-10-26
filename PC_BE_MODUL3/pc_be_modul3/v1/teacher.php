<?php

include "config/koneksi.php";
include "config/regist_teacher.php";

$method  = $_SERVER['REQUEST_METHOD'];

 if ($method == 'GET') {
    $sql = "SELECT * FROM teacher";
    $query = mysqli_query($conn, $sql);
    while($data = mysqli_fetch_array($query)) {
        
        $item[] = array(
            'id' => $data["id"],
            'name' => $data["name"], 
            'email' => $data["email"],
            'password' => $data["password"],
            'registeredNumber' => $data["registered_number"],
            'imagePath' => $data["image_path"], 
            'status' => $data["status"], 
            'createdAt' => $data["created_at"]
        );

    }
    
        $response = array(
            'status' => 200,
            'message' => 'Sukses menarik data guru',
            'data' => $item
        );


    echo json_encode($response);
        
} elseif ($method == 'POST') {

     if (isset($_POST['name']) && isset($_POST['email']) && isset($_POST['password']) && isset($_POST['registeredNumber']) && isset($_POST['imagePath'])) {

        $p_name = $_POST['name'];
        $p_email =  $_POST['email'];
        $p_password = $_POST['password'];
        $p_registeredNumber =  $_POST['registeredNumber'];
        $p_imagePath = $_POST['imagePath'];
    
        if( cek_username($p_email) == 0 ){

            $user = register_user($p_name, $p_email, $p_password, $p_registeredNumber, $p_imagePath);

            if ($user) {
                
                $item = array(
                'id' => $user["id"],
                'name' => $user["name"], 
                'email' => $user["email"],
                'password' => $user["password"],
                'registeredNumber' => $user["registered_number"],
                'imagePath' => $user["image_path"], 
                'status' => $user["status"], 
                'createdAt' => $user["created_at"]
                );

                $response = array (
                    'status' => 200,
                    'message' => 'Sukses menambahkan data siswa',
                    'data' => $item
                );

                echo json_encode($response);
                
            } else {
                $item = array();

                $response = array (
                    'status' => 401,
                    'message' => 'Terjadi kesalahan saat melakukan registrasi',
                    'data' => $item
                );
                echo json_encode($response);
            }

        } else {
            $response = array (
                'status' => 401,
                'message' => 'User telah ada'
            );
            echo json_encode($response);
        }

    }

} else {
        echo mysqli_affected_rows($link);
}

?>