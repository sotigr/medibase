// This is a function that allows the user to delete a
// message he has received from his message list.
// The message is consequently deleted from the 
// Database as well.
//
// Papaioannou S.


function deletemessage(id) {
    $.get('/operators/delete_msg.aspx?mid=' + id, function (data) {
        if (data == '1') {
            location.reload();
        }
        else {
            alert('Error while deleting message');
        }
    });
}

// With this XXXX the user has a view of his messages
// in a form of a list. The list shows the Sender, the
// Subject and the Date of each received message, along
// with a "Delete" icon/button, while when the user clicks
// on a message, its contents are displayed while the other
// messages show only their basic information as mentioned
// above.
//
// Papaioannou S.

$.get("/operators/msg_list_op.aspx", function (data) {
    var d = jQuery.parseJSON(data);
    var fianl = 0;
    var final = "";
    $.each(d, function (i, obj) {
        final += '<h3><span type="button" onclick="deletemessage(' + d[i]['MESSID'] + ');" title="Delete message" class="ui-icon ui-icon-trash"style="float:right;"></span>' + d[i]['SENDER'] + ' ' + d[i]['SUBJECT'] + ' ' + d[i]['DATEOFMESSAGE'] + '</h3>';
        final += ' <div>' + d[i]['MESSAGE'] + '</div>';
    });
    $('#m_list').html(final);
    $('#m_list').accordion();
});
