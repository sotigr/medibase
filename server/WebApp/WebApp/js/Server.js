var Server = (function () {
    function Server() {
    }
    Server.prototype.login = function (username, password) {
        var parms = {
            var1: 'some string',
            var2: 'sdaga'
        };

        $.ajax({
            type: "POST",
            url: "../operators/loginreq.aspx",
            async: false,
            data: parms,
            traditional: true,
            dataType: "json",
            success: function (data) {
                alert(data);
            }
        });
    };
    return Server;
})();
