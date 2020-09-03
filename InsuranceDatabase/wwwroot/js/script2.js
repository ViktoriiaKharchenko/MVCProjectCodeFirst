$(document).ready(() => {
    $("#button1").click(() => {
        $("#line").css("margin-left", " 168px")
        $("#number").css("display", " block");
        $("#name").css("display", " none");
        $("#category").css("display", " none");
    });
    $("#button2").click(() => {
        $("#line").css("margin-left", " 324px");
        $("#name").css("display", " block");
        $("#number").css("display", " none");
        $("#category").css("display", " none");
    });
    $("#button3").click(() => {
        $("#line").css("margin-left", "475px");
        $("#category").css("display", " block");
        $("#number").css("display", " none");
        $("#name").css("display", " none");
    });
    $("#button4").click(() => {
        $("#line").css("margin-left", "324px");
        $("#category").css("display", " block");
        $("#number").css("display", " none");
        $("#name").css("display", " none");
    });

});