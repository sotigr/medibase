
var loginopen = false;
 
$(window).load(function () {
    if (loggedin) {
        $('#loginpanel').css('display', 'none');
        $('#logoutpanel').css('display', 'block');
        $('#welcome_cont').html('<span>Welcome ' + username + ' </span><a class="topbtn" id="logoutbtn" href="#" onclick="dologout();">Logout</a>');
    }
    else {
        $('#loginpanel').css('display', 'block');
        $('#logoutpanel').css('display', 'none');
    }
});
function validateEmail(email) {
    var re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}
function genclick() {
    if (loginopen) {
        hidelogin();
    }
}
function showlogin() {
    $('#login_box').css("display", "block");
    $('#login_box').animate({ marginTop: "0px", opacity: 1 }, 600, function () {
        $('#username_box').focus();
        loginopen = true;
    });
    ResetLogin();
}
function hidelogin() {
    $('#login_box').animate({ marginTop: "-140px", opacity: 0 }, 600, function () {
        $('body').focus();
        $('#password_box').val("");
        $('#login_box').css("display", "none");
        loginopen = false;
    });
}
$('#username_box').on('focus', function () {
    ResetLogin();
    $('#username_box').animate({ "border-color": "#1288ff", "color": "#000" }, 300);
});
$('#password_box').on('focus', function () {
    ResetLogin(); 
    $('#password_box').animate({ "border-color": "#1288ff", "color": "#000" }, 300);
});
$('#username_box').off('focus', function () {
    ResetLogin();
    $('#username_box').animate({ "border-color": "#ccc", "color": "#000" }, 300);
});
$('#password_box').off('focus', function () {
    ResetLogin();
    $('#password_box').animate({ "border-color": "#ccc", "color": "#000" }, 300);
});
function dologout() {
    var parms = {
        com: 'logout'
    };
    $.ajax({
        type: "POST",
        url: "../operators/loginreq.aspx",
        async: false,
        data: parms,
        traditional: true,
        dataType: "json",
        success: function (data) {
            window.location.href = '/default.aspx';
        },
        error: function (data) {
        }
    });
}

$("#loginbtn").on("click", function () {
    if (!($('#username_box').val() == "" )) {
        if (!(validateEmail($('#username_box').val()))) {
            ShowLoginErr("Email is not valid");
            $('#username_box').animate({ "border-color": "#ff0000", "color": "#f00" }, 600);
            return;
        }
        var parms = {
            uname: $('#username_box').val(),
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
                if (data == "1") {
                    $('#loginpanel').css('display', 'none');
                    $('#logoutpanel').css('display', 'block');
                    $('#welcome_cont').html('<span>Welcome ' + username + ' </span><a class="topbtn" id="logoutbtn" onclick="dologout();" href="#">Logout</a>');

                    loggedin = true;
                    $('#logerrdiv').css('display', 'none');
                    hidelogin();
                    setTimeout(function () { location.reload(); }, 600);

                    return;
                }
                ShowLoginErr("Login Failed");
            },
            error: function (data) {
                ShowLoginErr("Connection Error");
            }
        });
    }
    else {
        ShowLoginErr("UserName or Password is invalid");
        $('#username_box').animate({ "border-color": "#ff0000", "color": "#f00" }, 600);
        $('#password_box').animate({ "border-color": "#ff0000", "color": "#f00" }, 600);
    }
});
function ShowLoginErr(text) {
    $('#logerrdiv').html("UserName or Password is not valid.");
    $('#logerrdiv').css('display', 'block');
    $('#logerrdiv').animate({ opacity: 1 }, 300, function () { return; });
}
function HideLoginErr() {
    $('#logerrdiv').animate({ opacity: 0 }, 300, function () {
        $('#logerrdiv').css('display', 'none');
    });
}
function ResetLogin() {
    HideLoginErr();
    $('#username_box').animate({ "border-color": "#ccc", "color": "#000" }, 300);
    $('#password_box').animate({ "border-color": "#ccc", "color": "#000" }, 300);
}