function table() {
  arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
  num = Number(document.getElementById("num").value);
  for (let index = 0; index < arr.length; index++) {
    document.getElementById("res").innerHTML += arr[index] * num + " ";
  }
}
