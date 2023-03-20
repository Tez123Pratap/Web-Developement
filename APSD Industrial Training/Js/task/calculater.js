function calculate() {
  num1 = Number(document.getElementById("first").value);
  num2 = Number(document.getElementById("second").value);
  opt = document.getElementById("op").value;
  switch (opt) {
    case "+":
      document.getElementById("res").value = num1 + num2;
      break;
    case "-":
      document.getElementById("res").value = num1 - num2;
      break;
    case "*":
      document.getElementById("res").value = num1 * num2;
      break;
    case "/":
      document.getElementById("res").value = num1 / num2;
      break;

    default:
      alert("please choose valid operation");
      break;
  }
}
