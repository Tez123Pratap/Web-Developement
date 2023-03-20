function isName() {
  var name = ["tez", "mitesh", "pallavi", "rashami", "ram"];
  //   for (index = 0; index < array.length; index++) {
  //     if () {
  //       document.write("yes");
  //       break;
  //     }
  //   }
  //   if (index == name.length) document.write("no");
  if (name.includes("ram")) {
    document.getElementById("res").innerHTML = "yes";
  } else {
    document.getElementById("res").innerHTML = "no";
  }
}
