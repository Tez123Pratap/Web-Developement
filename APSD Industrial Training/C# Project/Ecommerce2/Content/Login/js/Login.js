$(document).ready(function () {
    $('#logInBtn').click(function () {
        var id = $('#userId').val();
        var pass = $('#userPass').val();
        alert(id + " " + pass);
    })
})