// A function that receives the information entered by the user
// in order to store the comments of that user. If a box is
// left blank, the user is prompted to fill it. 
// The data are stored in a variable and sent with a POST command
// through ajax to the operator responsible for dealing with the
// received data. If the messages is sent successfully, the user
// sees a "success" notification as is redirected to the main page.
//
// Karmiris D.

function ReceiveMessage() {
    var name = $('#cont_name').val();
    var email = $('#cont_email').val();
    var subject = $('#cont_subject').val();
    var content = $('#cont_msg').val();
    if (name == "" || email == "" || subject == "" || content == "") {
        alert("Warning: Fill in possible blank areas!");
        return;
    }
    else {
        var parms = {
            c_name: name,
            c_email: email,
            c_subject: subject,
            c_content: content
        };

        $.ajax({
            type: "POST",
            url: "/operators/contact_op.aspx",
            async: false,
            data: parms,
            traditional: true,
            dataType: "json",
            success: function (data) {
                if (data == "1") {
                    alert("Thank you for contacting us.");
                    window.location.href = '/default.aspx';
                }
                else {
                    alert("Error occured when trying to send the message! Please fill in all the boxes!");
                    return;
                }
            },
            error: function (data) {
                alert(data[0]);
                return;
            }
        });
    }
}

// The event when clicking the "Send" button
//
// Karmiris D.

$('#send_cont_msg_btn').on('click', function () {
    ReceiveMessage();
});