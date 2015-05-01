var $select = $("#day");
for (i = 1; i <= 31; i++) {
    $select.append($('<option></option>').val(i).html(i))
}

var $select = $("#year");
var d = new Date();
for (i = d.getFullYear() ; i >= 1900 ; i--) {
    $select.append($('<option></option>').val(i).html(i))
}
$('#radio').buttonset(); 
$('#cp_title').selectmenu().selectmenu("menuWidget")
.addClass("overflow");
$('#day').selectmenu().selectmenu("menuWidget")
.addClass("overflow");
$('#month').selectmenu().selectmenu("menuWidget")
.addClass("overflow");
$('#year').selectmenu().selectmenu("menuWidget")
.addClass("overflow");
var radioval = "";
$("#cp_male").click(function () {
    radioval = "male";
});
$("#cp_female").click(function () {
    radioval = "female";
});
$('#cp_submit').on('click', function () {
    var title = $('#cp_title option:selected').text();
    var name = $('#cp_name').val();
    var surname = $('#cp_surname').val();
    var gender = radioval;
    var day = $('#day option:selected').text();
    var month = $('#month option:selected').text();
    var year = $('#year option:selected').text();
    var email = $('#cp_email').val();
    var pass = $('#cp_pass').val();
    var repass = $('#cp_repass').val();
    var occupation = $('#cp_occupation').val();
    var address = $('#cp_address').val();
    var zip = $('#cp_zip').val();
    var phone = $('#cp_phone').val();
    var mobile = $('#cp_mobile').val();
    var city = $('#cp_city').val();
    var country = $('#cp_country').val();

    if (title == "" || name == "" || surname == "" || gender == "" || email == ""
        || pass == "" || repass == "" || occupation == "" || address == ""
        || zip == "" || phone == "") {
        alert("Warning!");
        return;
    }
    else {
        if (d.getFullYear() - year >= 18) {
            if (validateEmail(email) && pass == repass) {
                var parms = {
                    s_title: title,
                    s_name: name,
                    s_surname: surname,
                    s_gender: gender,
                    s_day: day,
                    s_month: month,
                    s_year: year,
                    s_email: email,
                    s_pass: pass,
                    s_repass: repass,
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
                    url: "/operators/create_acc.aspx",
                    async: false,
                    data: parms,
                    traditional: true,
                    dataType: "json",
                    success: function (data) {
                        if (data == "1") {
                            window.location.href = '/default.aspx';
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