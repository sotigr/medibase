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