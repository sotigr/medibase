<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="contact_page.aspx.cs" Inherits="WebApp.pages.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="main_panel" style="width: 600px; margin: 20px auto;">
        <table>
            <tr>
                <td style="border-right: solid 1px rgba(0,0,0,0.2); padding-right: 5px; width: 60%;">

                    <h3 align="center">Contact Us:</h3>
                    <p>Send us your suggestions or problems and we will contact you as soon as possible.</p>
                    <table>
                        <tr>
                            <td>Name:</td>
                            <td>
                                <input type="text" id="cont_name" /></td>
                        </tr>
                        <tr>
                            <td>Email:</td>
                            <td>
                                <input type="text" id="cont_email" /></td>
                        </tr>
                        <tr>
                            <td>Subject:</td>
                            <td>
                                <input type="text" id="cont_subject" /></td>
                        </tr>
                    </table>
                    <div style="margin-top: 10px;">
                        Comments: 
                    </div>
                    <textarea id="cont_msg" style="padding-top: 5px; min-width: 100%; max-width: 100%; min-height: 250px; max-height: 250px; overflow: hidden;"></textarea>
                    <div style="text-align: right; padding-top: 5px;">
                        <input type="button" value="Back" style="height: 30px;" onclick="window.location.href = '../default.aspx';" />
                        <input type="button" id="send_cont_msg_btn" value="Send" style="height: 30px;" />
                    </div>
                </td>
                <td style="vertical-align: text-top; text-align: center;">
                    <h3>Or call us at:</h3>
                    <p>+30 210 1234567</p>
                </td>
            </tr>
        </table>
    </div>

    <script src="/js/contact.js">

    </script>

</asp:Content>

