// Variables that contain the information of the user
// as they are wirtten in the Database.
//
// Karmiris D.

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

// When the "Edit" button is clicked, all the "display" variables become hidden,
// and are replaced by the editable textboxes, while the buttons change as well
// to "Apply" and "Cancel".
//
// Karmiris D.

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

// After clicking the "Apply" button the new data are stored in the variables
// that appeared after the "Edit" button was pressed. If all of fields are 
// not null or blank the data are stored in a variable and are sent to the 
// Database with a POST command via ajax.
//
// Karmiris D.

$('#cp_apply').on('click', function () {
    $('#cp_edit').css('display', 'block');
    $('#cp_apply').css('display', 'none');
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

    var title = $('#cp_title option:selected').text();
    var name = $('#cp_name').val();
    var surname = $('#cp_surname').val();
    var gender = radioval;
    var day = $('#day option:selected').text();
    var month = $('#month option:selected').text();
    var year = $('#year option:selected').text();
    var email = $('#cp_email').val();
    var occupation = $('#cp_occupation').val();
    var address = $('#cp_address').val();
    var zip = $('#cp_zip').val();
    var phone = $('#cp_phone').val();
    var mobile = $('#cp_mobile').val();
    var city = $('#cp_city').val();
    var country = $('#cp_country').val();

    if (title == "" || name == "" || surname == "" || gender == "" || email == ""
        || occupation == "" || address == ""
        || zip == "" || phone == "") {
        alert("Warning!");
        return;
    }
    else {
        if (d.getFullYear() - year >= 18) {
            if (validateEmail(email)) {
                var parms = {
                    s_title: title,
                    s_name: name,
                    s_surname: surname,
                    s_gender: gender,
                    s_day: day,
                    s_month: month,
                    s_year: year,
                    s_email: email,
                    s_occ: occupation,
                    s_addr: address,
                    s_zip: zip,
                    s_phone: phone,
                    s_mobile: mobile,
                    s_city: city,
                    s_country: country
                };

                $.ajax({
                    type: "POST",
                    url: "../operators/edit_acc.aspx",
                    async: false,
                    data: parms,
                    traditional: true,
                    dataType: "json",
                    success: function (data) {
                        if (data == "1") {
                            location.reload();
                        }
                        else {
                            alert(" Error!");
                            return;
                        }
                    },
                    error: function (data) {
                        alert("Connection Error!");
                        return;
                    }
                });
            }
            else {
                alert("Warning!");
                return;
            }
        }
        else {
            alert("Warning!");
            return;
        }
    }
});