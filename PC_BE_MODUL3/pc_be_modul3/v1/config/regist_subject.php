<?php

function register_subject($p_name, $p_major, $p_level, $p_semester, $p_description){
  global $conn;
     
  $nama = ($p_name);
  $major = ($p_major);
  $level = ($p_level);
  $semester = ($p_semester);
  $description = ($p_description);
     
  $query = "INSERT INTO subject(name, level, semester, major, description) VALUES('$nama', '$level', '$semester', '$major', '$description')";
  
  $subject_new = mysqli_query($conn, $query);
  if( $subject_new ) {
    $subj = "SELECT * FROM subject WHERE name = '$nama'";
    $result = mysqli_query($conn, $subj);
    $subject = mysqli_fetch_assoc($result);
    return $subject;
  }else{
      return NULL;
  }
}

function cek_namesubject($p_email){
  global $conn;
  $query = "SELECT * FROM subject WHERE name = '$p_name'";
  if( $result = mysqli_query($conn, $query) ) return mysqli_num_rows($result);
}

?>