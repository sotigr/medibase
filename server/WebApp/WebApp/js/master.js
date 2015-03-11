var loginopen = false;

function genclick()
{
    if (loginopen)
    {
        hidelogin();
    } 
}
function showlogin()
{ 
    $('#login_box').animate({marginTop: "0px", opacity:1}, 600, function(){
        $('#username_box').focus();
        loginopen = true;
    });
}
function hidelogin()
{
    $('#login_box').animate({marginTop: "-140px", opacity:0 }, 600, function(){
        $('body').focus();
        $('#password_box').val("");
        loginopen = false;
    });
}
$("#loginbtn").on("click", function () {
    var parms = {
        uname:  $('#username_box').val(),
        password: $('#password_box').val()
    };
    $.ajax({
        type: "POST",
        url: "../operators/loginreq.aspx",
        async: false,
        data: parms,
        traditional: true,
        dataType: "json",
        success: function (data) {
            if (data != "0")
            {
                hidelogin();
            }
        }
    });
});