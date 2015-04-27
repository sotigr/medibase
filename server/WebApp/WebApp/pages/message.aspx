<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="WebApp.pages.message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .overflow {
            max-height: 200px;
        }
    </style>
    <div class="main_panel" style="margin: 0 auto; width: 700px; padding-left: 20px; padding-right: 20px;">
        <table style="width: 100%; ">
            <tr>
                <td style="width: 10%">To:
                </td>
                <td>
                    <input id="msg_recipient" type="text" placeholder="user@host.com" />
                </td>
            </tr>
            <tr style="margin-top:3px;">
                <td>Subject:
                </td>
                <td>
                    <select id="msg_subject" style="width: 100%; height: 18px;">
                        <option value="">Select a subject...</option>
                        <option value="appointment">Appointment</option>
                        <option value="bill">Bill</option>
                        <option value="results">Results</option>
                        <option value="reminder">Reminder</option>
                    </select>
                </td>
            </tr>
        </table>
        <textarea id="msg_content" style="padding-top: 5px; min-width: 100%; min-height: 250px; max-height: 250px; overflow: hidden;"></textarea>
        <div style="text-align: right; margin-top:5px;">
            <input  type="button" id="send_message_btn" value="Send" style="height: 25px; " />
        </div>

    </div>
    <script>
        $('select').selectmenu().selectmenu("menuWidget")
            .addClass("overflow");
    </script>
    <script src="/js/message_controller.js"></script>
</asp:Content>
