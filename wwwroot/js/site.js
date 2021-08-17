$(document).ready(function () {
    $(".success-alert").hide();
    $(".addToBasket").click(function showAlert() {
        $(".success-alert").fadeTo(2000, 500).slideUp(500, function () {
            $(".success-alert").slideUp(500);
        });
    });
});


$('#selectCriteria').change(function (event) {
    var selectedCriteria = $('#selectCriteria').children("option:selected").val();
    sessionStorage.setItem("itemCriteria", selectedCriteria);
});

$('select').find('option[value=' + sessionStorage.getItem('itemCriteria') + ']').attr('selected', 'selected');

$('#selectAscDesc').change(function (event) {
    var selectedAscDesc = $('#selectAscDesc').children("option:selected").val();
    sessionStorage.setItem("itemAscDesc", selectedAscDesc);
});

$('select').find('option[value=' + sessionStorage.getItem('itemAscDesc') + ']').attr('selected', 'selected');