$('#val_title').html(title);
$('#val_name').html(name);
$('#val_surname').html(surname);
$('#val_gender').html(gender);
$('#val_email').html(email);
$('#val_occupation').html(profession);
$('#val_address').html(address1);
$('#val_zip').html(zip);
$('#val_phone').html(phone);
$('#val_mobile').html(celphone);
$('#val_city').html(town);
$('#val_country').html(country);
var $select = $("#day");
for (i = 1; i <= 31; i++) {
    $select.append($('<option></option>').val(i).html(i))
}

var $select = $("#year");
var d = new Date();
for (i = d.getFullYear() ; i >= 1900 ; i--) {
    $select.append($('<option></option>').val(i).html(i))
}

var radioval = "";
$("#cp_male").click(function () {
    radioval = "male";
});
$("#cp_female").click(function () {
    radioval = "female";
});

$('#cp_edit').on('click', function () {
    $('#cp_apply').css('display', 'block');
    $('#cp_edit').css('display', 'none');
    $('#radio').buttonset();
    $('#radio').buttonset();
    $('#cp_title').selectmenu().selectmenu("menuWidget")
    .addClass("overflow");
    $('#day').selectmenu().selectmenu("menuWidget")
    .addClass("overflow");
    $('#month').selectmenu().selectmenu("menuWidget")
    .addClass("overflow");
    $('#year').selectmenu().selectmenu("menuWidget")
    .addClass("overflow");

    $('#val_title').css('display', 'none');
    $('#val_name').css('display', 'none'); $('#cp_name').css('display', 'block');
    $('#val_surname').css('display', 'none'); $('#cp_surname').css('display', 'block');
    $('#val_gender').css('display', 'none'); $('#radio').css('display', 'block');
    $('#val_email').css('display', 'none'); $('#cp_email').css('display', 'block');
    $('#val_occupation').css('display', 'none'); $('#cp_occupation').css('display', 'block');
    $('#val_address').css('display', 'none'); $('#cp_address').css('display', 'block');
    $('#val_zip').css('display', 'none'); $('#cp_zip').css('display', 'block');
    $('#val_phone').css('display', 'none'); $('#cp_phone').css('display', 'block');
    $('#val_mobile').css('display', 'none'); $('#cp_mobile').css('display', 'block');
    $('#val_city').css('display', 'none'); $('#cp_city').css('display', 'block');
    $('#val_country').css('display', 'none'); $('#cp_country').css('display', 'block');

    $('#cp_name').val(name);
    $('#cp_surname').val(surname);
    $('#radio').val(gender);
    $('#cp_email').val(email);
    $('#cp_occupation').val(profession);
    $('#cp_address').val(address1);
    $('#cp_zip').val(zip);
    $('#cp_phone').val(phone);
    $('#cp_mobile').val(celphone);
    $('#cp_city').val(town);
    $('#cp_country').val(country);
});

