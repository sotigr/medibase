<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="edit_acc.aspx.cs" Inherits="WebApp.pages.edit_acc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            font-size: 12px;
        }

        .overflow {
            max-height: 300px;
        }
    </style>


    <div class="main_panel" style="width: 600px; margin: 0 auto; margin-top: 50px;">
        <div style="text-align: center;">
            <h1>Account creation</h1>
            <p>Please enter the following information.</p>
        </div>
        <table align="center">
            <tr>
                <td>Title:
                </td>
                <td>
                    <div id="val_title"></div>
                    <select id="cp_title" value="" style="display: none;">
                        <option value="mr">Mr</option>
                        <option value="miss">Miss</option>
                        <option value="mrs">Mrs</option>
                        <option value="dr">Dr</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>First Name:
                </td>
                <td>
                    <div id="val_name"></div>
                    <input type="text" id="cp_name" value="name" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Last Name:
                </td>
                <td>
                    <div id="val_surname"></div>
                    <input type="label" id="cp_surname" value="val_surname" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Gender:
                </td>
                <td>

                    <div id="val_gender"></div>
                    <div id="radio" value="gender" style="display: none;">
                        <input type="radio" name="radio" id="cp_male"><label for="cp_male">Male</label>
                        <input type="radio" name="radio" id="cp_female"><label for="cp_female">Female</label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>Age:
                </td>
                <td>

                    <div id="val_date" style="display: none;"></div>
                    <select id="day" value="" style="display: none;"></select>

                    <select id="month" style="display: none;">
                        <option value="january" selected>January</option>
                        <option value="february">February</option>
                        <option value="march">March</option>
                        <option value="april">April</option>
                        <option value="may">May</option>
                        <option value="june">June</option>
                        <option value="july">July</option>
                        <option value="august">August</option>
                        <option value="september">September</option>
                        <option value="october">October</option>
                        <option value="november">November</option>
                        <option value="december">December</option>
                    </select>

                    <select id="year" value="" style="display: none;"></select>
                </td>
            </tr>
            <tr>
                <td>E-mail:
                </td>
                <td>
                    <div id="val_email"></div>
                    <input type="text" id="cp_email" value="email" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Password:
                </td>
                <td>
                    <div id="val_pass"></div>
                    <input type="password" id="cp_pass" value="password" style="display: none;" />
                </td>
            </tr>
            <tr id="repass_tr" style="display: none;">
                <td>Re-enter Password:
                </td>
                <td>
                    <input type="password" id="cp_repass" value="password" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Occupation:
                </td>
                <td>
                    <div id="val_occupation"></div>
                    <input type="text" id="cp_occupation" value="occupation" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Address:
                </td>
                <td>
                    <div id="val_address"></div>
                    <input type="text" id="cp_address" value="address" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Zip Code:
                </td>
                <td>
                    <div id="val_zip"></div>
                    <input type="text" id="cp_zip" value="zipcode" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Phone No.:
                </td>
                <td>
                    <div id="val_phone"></div>
                    <input type="text" id="cp_phone" value="phone" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Mobile No.:
                </td>
                <td>
                    <div id="val_mobile"></div>
                    <input type="text" id="cp_mobile" value="mobile" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>City:
                </td>
                <td>
                    <div id="val_city"></div>
                    <input type="text" id="cp_city" value="city" style="display: none;" />
                </td>
            </tr>
            <tr>
                <td>Country:
                </td>
                <td>
                    <div id="val_country"></div>
                    <input type="text" id="cp_country" value="country" style="display: none;" />
                </td>
            </tr>

            <tr>
                <td>
                    <input type="button" id="cp_edit" value="Edit" style="height: 30px;">
                    <input type="button" id="cp_apply" value="Apply" style="display: none; height: 30px;">
                    <input type="button" id="cp_cancel" value="Cancel" style="height: 30px;" onclick="location.reload();">
                </td>
            </tr>
        </table>
        <asp:PlaceHolder runat="server" ID="pl1"></asp:PlaceHolder>

        <script src="/js/edit_acc.js">

        </script>
</asp:Content>
