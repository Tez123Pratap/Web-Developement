function oddEven() {
  //   debugger;
  n = Number(document.getElementById("txt").value);
  alert(n);
  for (i = 0; i <= n; i++) {
    if (i % 2 == 0) {
      document.getElementById("even").innerHTML += i + " ";
      document.getElementById("even").style.color = "red";
    } else {
      document.getElementById("odd").innerHTML += i + " ";
      document.getElementById("odd").style.color = "green";
    }
  }
}
