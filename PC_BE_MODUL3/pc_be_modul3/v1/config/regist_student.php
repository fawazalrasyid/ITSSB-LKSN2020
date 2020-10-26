<?php

function register_user($p_name, $p_email, $p_password, $p_registeredNumber, $p_imagePath){
  global $conn;
     
  $nama = ($p_name);
  $email = ($p_email);
  $pass = ($p_password);
  $registNumber = ($p_registeredNumber);
  $imagePath = ($p_imagePath);
 
  $hash = password_hash($pass, PASSWORD_DEFAULT);
  $encrypted_pass = $hash;
     
  $query = "INSERT INTO student(name, email, password, registered_number, image_path) VALUES('$nama', '$email', '$encrypted_pass', '$registNumber', '$imagePath')";
  
  $user_new = mysqli_query($conn, $query);
  if( $user_new ) {
    $usr = "SELECT * FROM student WHERE email = '$email'";
    $result = mysqli_query($conn, $usr);
    $user = mysqli_fetch_assoc($result);
    return $user;
  }else{
      return NULL;
  }
}

function cek_username($p_email){
  global $conn;
  $query = "SELECT * FROM student WHERE email = '$p_email'";
  if( $result = mysqli_query($conn, $query) ) return mysqli_num_rows($result);
}

function escape($data){
  global $conn;
  return mysqli_real_escape_string($conn, $data);
}

function hashSSHA($password) {
  $salt = sha1(rand());
  $salt = substr($salt, 0, 10);
  $encrypted = base64_encode(sha1($password . $salt, true) . $salt);
  $hash = array("salt" => $salt, "encrypted" => $encrypted);
  return $hash;
}

?>