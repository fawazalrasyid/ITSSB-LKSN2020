<?php

function register_class($p_name, $p_major, $p_level, $p_semester, $p_description){
  global $conn;
     
  $nama = ($p_name);
  $major = ($p_major);
  $level = ($p_level);
  $semester = ($p_semester);
  $description = ($p_description);
     
  $query = "INSERT INTO class(name, level, semester, major, description) VALUES('$nama', '$level', '$semester', '$major', '$description')";
  
  $class_new = mysqli_query($conn, $query);
  if( $class_new ) {
    $clss = "SELECT * FROM class WHERE name = '$nama'";
    $result = mysqli_query($conn, $clss);
    $class = mysqli_fetch_assoc($result);
    return $class;
  }else{
      return NULL;
  }
}

function cek_nameclass($p_email){
  global $conn;
  $query = "SELECT * FROM class WHERE name = '$p_name'";
  if( $result = mysqli_query($conn, $query) ) return mysqli_num_rows($result);
}

?>