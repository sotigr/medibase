
var loginopen = false;
var menuopen = false;
$(window).load(function () {
    if (usertitle == 'Dr') {
        $('#message_menu_item').css('display', 'block');
    }
    if (loggedin) {
        $('#loginpanel').css('display', 'none');
        $('#logoutpanel').css('display', 'block');
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
    hidemenu();
}
function hidemenu() {
    $('#master_mainmenu').animate({ opacity: 0, marginRight: "-300px" }, 600, function () {
        $('#master_mainmenu').css("display", "none");
        menuopen = false;
    });
}
function showmenu() {
    if (menuopen) {
        hidemenu();
    }
    else {
        $('#master_mainmenu').css("opacity", "0");
        $('#master_mainmenu').css("display", "block");
        $('#master_mainmenu').animate({ opacity: 1, marginRight: "0px" }, 600);
        menuopen = true;
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
    $('#username_box').animate({ "border-color": "#B295D8", "color": "#000" }, 300);
});
$('#password_box').on('focus', function () {
    ResetLogin();
    $('#password_box').animate({ "border-color": "#B295D8", "color": "#000" }, 300);
});
$('#username_box').keyup(function (e) {
    var code = e.which; // recommended to use e.which, it's normalized across browsers
    if (code == 13) $('#password_box').focus();

});
$('#password_box').keyup(function (e) {
    var code = e.which; // recommended to use e.which, it's normalized across browsers
    if (code == 13) dologin();

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
function dologin() {
    if (!($('#username_box').val() == "")) {
        /* if (!(validateEmail($('#username_box').val()))) {
             ShowLoginErr("Email is not valid");
             $('#username_box').animate({ "border-color": "#ff0000", "color": "#f00" }, 600);
             return;
         }*/
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
                    window.location.href = '/default.aspx';

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
}
$("#loginbtn").on("click", function () {
    dologin();
});
//Shows erron on login box
function ShowLoginErr(text) {
    $('#logerrdiv').html("UserName or Password is not valid.");
    $('#logerrdiv').css('display', 'block');
    $('#logerrdiv').animate({ opacity: 1 }, 300, function () { return; });
}
//Hides the error label on the login box
function HideLoginErr() {
    $('#logerrdiv').animate({ opacity: 0 }, 300, function () {
        $('#logerrdiv').css('display', 'none');
    });
}
//Will reset the colors of the login box
function ResetLogin() {
    HideLoginErr();
    $('#username_box').animate({ "border-color": "#ccc", "color": "#000" }, 300);
    $('#password_box').animate({ "border-color": "#ccc", "color": "#000" }, 300);
}
