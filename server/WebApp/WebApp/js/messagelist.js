


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
