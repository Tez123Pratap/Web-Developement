function calculate() {
  length = Number(document.getElementById("length").value);
  width = Number(document.getElementById("width").value);
  radius = Number(document.getElementById("radius").value);
  document.getElementById("per").innerHTML =
    "Perimeter of rectangle= " +
    2 * (length * width) +
    "<br>" +
    "Perimeter of circle= " +
    2 * 3.14 * radius;
}
