var c = 0,
  t,
  startconton = 0;
function timeCount() {
  document.getElementById("txt").value = c;
  c = c + 1;
  t = setTimeout(function () {
    timeCount();
  }, 500);
}
function start() {
  startconton = 1;
  timeCount();
}
function stop() {
  clearTimeout(t);
  startconton = 0;
}
