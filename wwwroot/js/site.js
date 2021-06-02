// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//configurações de alternancia de login
$('.btn-paciente').click(function () {
    $(".btn-paciente").addClass("text-on");
    $(".btn-paciente").removeClass("text-off");
    $(".btn-medico").addClass("text-off");
    $(".btn-medico").removeClass("text-on");

    $("#log-medico").css("display", "none");
    $("#log-paciente").css("display", "block");
});
$('.btn-medico').click(function () {
    $(".btn-medico").addClass("text-on");
    $(".btn-medico").removeClass("text-off");
    $(".btn-paciente").addClass("text-off");
    $(".btn-paciente").removeClass("text-on");

    $('#log-paciente').css('display', 'none');
    $('#log-medico').css('display', 'block');
});

//configurações de alltenancia de opções de logon/logoff
$(".btn-login").click(function () {
    x = $("#email").val();
    $("#logoff-item").css("display", "none");
    $("#logon-item").css("display", "block");
    $("#username").html(x);
});