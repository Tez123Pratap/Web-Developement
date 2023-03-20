function check1() {
  var email = document.getElementById("email").value;
  if (email == null || email == "") {
    document.getElementById("res").innerHTML = "plz fill your email...";
  } else if (email.lastIndexOf("@") < 0) {
    document.getElementById("res").innerHTML = "plz fill @";
  } else if (email.lastIndexOf(".com") < 0 && email.lastIndexOf(".yahoo") < 0) {
    document.getElementById("res").innerHTML = "plz extention";
  } else {
    document.getElementById("res").innerHTML = "Your Email is correct";
  }
}
