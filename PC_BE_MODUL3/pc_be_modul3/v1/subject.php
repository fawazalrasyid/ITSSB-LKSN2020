<?php

include "config/koneksi.php";
include "config/regist_subject.php";

$method  = $_SERVER['REQUEST_METHOD'];

 if ($method == 'GET') {
    $sql = "SELECT * FROM subject";
    $query = mysqli_query($conn, $sql);
    while($data = mysqli_fetch_array($query)) {
        
        $item[] = array(
            'id' => $data["id"],
            'name' => $data["name"], 
            'level' => $data["level"],
            'semester' => $data["semester"],
            'major' => $data["major"],
            'description' => $data["description"],
            'createdAt' => $data["created_at"]
        );

    }
    
        $response = array(
            'status' => 200,
            'message' => 'Sukses menarik data subject',
            'data' => $item
        );


    echo json_encode($response);
        
} elseif ($method == 'POST') {

     if (isset($_POST['name']) && isset($_POST['major']) && isset($_POST['level']) && isset($_POST['semester']) && isset($_POST['description'])) {

        $p_name = $_POST['name'];
        $p_major =  $_POST['major'];
        $p_level = $_POST['level'];
        $p_semester =  $_POST['semester'];
        $p_description = $_POST['description'];
    
        if( cek_namesubject($p_name) == 0 ){

            $subject = register_subject($p_name, $p_major, $p_level, $p_semseter, $p_description);

            if ($subject) {
                
                $item = array(
                'id' => $subject["id"],
                'name' => $subject["name"], 
                'level' => $subject["level"],
                'semester' => $subject["semester"],
                'major' => $subject["major"],
                'description' => $subject["description"],
                'createdAt' => $subject["created_at"]
                );

                $response = array (
                    'status' => 200,
                    'message' => 'Sukses menambahkan data subject',
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
                'message' => 'Subject dengan nama ini telah ada'
            );
            echo json_encode($response);
        }

    }

} else {
        echo mysqli_affected_rows($link);
}

?>