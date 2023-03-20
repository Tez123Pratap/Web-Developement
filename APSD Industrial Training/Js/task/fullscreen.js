var elem = document.documentElement;
function openfull() {
  //   if (elem.requestFullscreen) {
  //     elem.requestFullscreen();
  //   } else if (elem.webkitExitFullscreen) {
  //     elem.webkitExitFullscreen();
  //   } else if (elem.msRequestFullscreen) {
  //     elem.msRequestFullscreen();
  //   }
  elem.requestFullscreen();
}
function closefull() {
  document.exitFullscreen();
}
