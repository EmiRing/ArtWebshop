﻿$(document).ready(function () {
    $(".success-alert").hide();
    $(".addToBasket").click(function showAlert() {
        $(".success-alert").fadeTo(2000, 500).slideUp(500, function () {
            $(".success-alert").slideUp(500);
        });
    });
});