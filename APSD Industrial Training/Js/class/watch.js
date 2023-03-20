function watchFun() {
  const date = new Date();
  document.getElementById("res").innerHTML = date.toLocaleTimeString();
  document.getElementById("sp").innerHTML = date.toLocaleDateString();
  //   document.getElementsByTagName("body").style.background = red;
}
const myintervel = setInterval(watchFun, 1000);
function start() {
  myintervel = setInterval(watchFun, 1000);
}
function stop() {
  clearInterval(myintervel);
}
