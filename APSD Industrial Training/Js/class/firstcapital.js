function capital() {
  var n = document.getElementById("name").value;
  t = n;
  var res = n[0].toUpperCase();
  for (var i = 1; i < n.length; i++) {
    if (n[i - 1] == " ") {
      l = n[i].toUpperCase();
      break;
    }
  }
  document.getElementById("sp").innerHTML =
    res + n.substr(1, n.indexOf(" ")) + l + n.substr(n.indexOf(" ") + 2);
  document.getElementById("wid").innerHTML = t.length;
}
