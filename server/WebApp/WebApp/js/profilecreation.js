var $select = $("#day");
for (i = 1; i <= 31; i++) {
    $select.append($('<option></option>').val(i).html(i))
}

var $select = $("#year");
var d = new Date();
for (i = d.getFullYear() ; i >= 1900 ; i--) {
    $select.append($('<option></option>').val(i).html(i))
}

$('#cp_submit').on('click', function () {
    var occupation = $('#cp_occupation').val();
    if (occupation == "")
    {
        alert("Warning!");
    }
});
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