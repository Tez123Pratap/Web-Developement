function show() {
  var op = document.getElementById("passhide").value;
  // debugger;
  if (op == "show") {
    document.getElementById("passhide").value = "hide";
    document.getElementById("pass").type = "text";
  } else {
    document.getElementById("passhide").value = "show";
    document.getElementById("pass").type = "password";
  }
}
function passValid() {
  var pas = document.getElementById("pass").value;
  l = pas.length;
  if (l == "" || l == null) {
    document.getElementById("res").innerHTML = "plz enter your passward";
    document.getElementById("res").style.color = "red";
  } else if (l <= 4) {
    document.getElementById("res").innerHTML = "your passward is too short";
    document.getElementById("res").style.color = "orange";
  } else if (l <= 6) {
    document.getElementById("res").innerHTML = "your passward is midium";
    document.getElementById("res").style.color = "blue";
  } else {
    document.getElementById("res").innerHTML = "your passward is strong";
    document.getElementById("res").style.color = "green";
  }
}
