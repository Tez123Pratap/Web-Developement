function fun1() {
  var op;
  for (i = 1970; i < 2042; i++) op += "<option>" + i + "</option>";
  document.getElementById("ddyear").innerHTML = op;
}
function Remove() {
  var x = document.getElementById("remove");
  x.remove(x.selectedIndex);
}
function demo() {
  var dots = document.getElementById("dots");
  var moreText = document.getElementById("more");
  var btnText = document.getElementById("btn");
  if (dots.style.display === "none") {
    dots.style.display = "inline";
    btnText.value = "ReadMore";
    moreText.style.display = "none";
  } else {
    dots.style.display = "none";
    btnText.value = "ReadLess";
    moreText.style.display = "inline";
  }
}
