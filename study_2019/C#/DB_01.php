<?php
$amount = $_GET["amount"];
$con = mysqli_connect('localhost','root','162897') or die(mysql_error());
mysqli_select_db($con,"dog_cat") or die("데이터베이스를 선택할 수 없습니다.");
$insert_query = "INSERT INTO rice_amount(amount) VALUES($amount)";
$update_query = "UPDATE rice_amount set amount=500 where amount=1";
$delete_query = "DELETE FROM rice_amount";
mysqli_query($con, $insert_query);
mysqli_query($con,$update_query);
mysqli_query($con, $delete_query);
mysqli_close($con);

?>