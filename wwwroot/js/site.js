var mouseX = 0;
var mouseY = 0;
$(document).ready(function () {
    $(".success-alert").hide();
    $(".addToBasket").click(function showAlert(e) {
        $(".success-alert").css({ 'left': e.pageX - 300, 'top': e.pageY + 20 }).fadeTo(2000, 500).slideUp(500, function () {
            $(".success-alert").slideUp(500);
        });
    });
});