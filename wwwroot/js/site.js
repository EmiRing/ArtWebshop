var mouseX = 0;
var mouseY = 0;
$(document).ready(function () {
    $(".success-alert").hide();
    $(".addToBasket").click(function showAlert(event) {
        $(".success-alert").css({ 'left': event.pageX - 300, 'top': event.pageY + 20 }).fadeTo(2000, 500).slideUp(500, function () {
            $(".success-alert").slideUp(500);
        });
    });
});