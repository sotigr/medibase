// A function that receives the information entered by the user
// in order to store the message the doctor sends to another user.
// If a box is blank or a subject is not selected, the user is prompted
// to complete it. The data are stored in a variable and sent with a 
// POST command through ajax to the operator responsible for dealing 
// with the received data. If the messages is sent successfully, the user
// sees a "success" notification as is redirected to the main page.
//
// Karmiris D.

function SendMessage() {
    var recipient = $('#msg_recipient').val();
    var subject = $('#msg_subject option:selected').text();
    var content = $('#msg_content').val();
    if (recipient == "" || subject == "" || content == "") {
        alert("Warning msg insufficient");
        return;
    }
    else {
        var parms = {
            m_recipient: recipient,
            m_subject: subject,
            m_content: content
        };

        $.ajax({
            type: "POST",
            url: "/operators/message_op.aspx",
            async: false,
            data: parms,
            traditional: true,
            dataType: "json",
            success: function (data) {
                if (data == "1") {
                    alert("Message sent Successfully");
                    window.location.href = '/default.aspx';
                }
                else {
                    alert(" Error sending message!");
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
$('#send_message_btn').on('click', function () {
    SendMessage();
});