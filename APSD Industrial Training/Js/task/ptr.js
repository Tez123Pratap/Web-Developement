function ptr() {
  p = document.getElementById("num");
  // document.write("<p style='color:blue'>1 2 3 4 5</p>");
  // document.write("<p style='color:red'>1 2 3 4 5</p>");
  // document.write("<p style='color:green'>1 2 3 4 5</p>");
  // document.write("<p style='color:yellow'>1 2 3 4 5</p>");
  // document.write("<p style='color:pink'>1 2 3 4 5</p>");

  for (i = 1; i <= 5; i++) {
    for (j = 1; j <= 5; j++) {
      // p.innerHTML += j + " ";
      document.write(j + " ");
    }
  }
  document.write("<br>");
  p.style.color = "blue";
}
