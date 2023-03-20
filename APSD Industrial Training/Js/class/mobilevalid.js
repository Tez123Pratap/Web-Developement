function mobvalid() {
  var mobno = document.getElementById("txtm").value;
  if (
    (mobno[0] != 9 || mobno[0] != 8 || mobno[0] != 7 || mobno[0] != 6) &&
    mobno.length != 10
  ) {
    document.getElementById("sp").innerHTML =
      "not valid number please enetr a valid number";
  } else {
    document.getElementById("sp").innerHTML = "valid number";
  }
}
