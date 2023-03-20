var i = 0;
var arr = ["tez", "Mitesh", "pallavi", "Rashmi"];
function slide() {
  document.getElementById("slider").innerHTML = arr[i];
  i++;
  if (i == arr.length) i = 0;
  window.setTimeout("slide()", 1000);
}
