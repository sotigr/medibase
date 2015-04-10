<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="profilecreation.aspx.cs" Inherits="WebApp.pages.profilecreation" %>

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

        select {
            padding: 10px;
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
                    <select id="cp_title">
                        <option value="" selected>Select...</option>
                        <option value="mr">Mr</option>
                        <option value="miss">Miss</option>
                        <option value="mrs">Mrs</option>
                        <option value="dr">Dr</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>First name:
                </td>
                <td>
                    <input type="text" id="cp_name" />
                </td>
            </tr>
            <tr>
                <td>Lastname:
                </td>
                <td>
                    <input type="text" id="cp_surname" />
                </td>
            </tr>
            <tr>
                <td>Gender:
                </td>
                <td>

                    <div id="radio">
                        <input type="radio" name="radio" id="cp_male"><label for="cp_male">Male</label>
                        <input type="radio" name="radio" id="cp_female"><label for="cp_female">Female</label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>Age:
                </td>
                <td>
                    <select id="day"></select>

                    <select id="month">
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

                    <select id="year"></select>
                </td>
            </tr>
            <tr>
                <td>E-mail:
                </td>
                <td>
                    <input type="text" id="cp_email" />
                </td>
            </tr>
            <tr>
                <td>Password:
                </td>
                <td>
                    <input type="password" id="cp_pass" />
                </td>
            </tr>
            <tr>
                <td>Re-enter Password:
                </td>
                <td>
                    <input type="password" id="cp_repass" />
                </td>
            </tr>
            <tr>
                <td>Occupation:
                </td>
                <td>
                    <input type="text" id="cp_occupation" />
                </td>
            </tr>
            <tr>
                <td>Address:
                </td>
                <td>
                    <input type="text" id="cp_address" />
                </td>
            </tr>
            <tr>
                <td>Zip Code:
                </td>
                <td>
                    <input type="text" id="cp_zip" />
                </td>
            </tr>
            <tr>
                <td>Phone No.:
                </td>
                <td>
                    <input type="text" id="cp_phone" />
                </td>
            </tr>
            <tr>
                <td>Mobile No.:
                </td>
                <td>
                    <input type="text" id="cp_mobile" />
                </td>
            </tr>
            <tr>
                <td>City:
                </td>
                <td>
                    <input type="text" id="cp_city" />
                </td>
            </tr>
            <tr>
                <td>Country:
                </td>
                <td>
                    <input type="text" id="cp_country" />
                </td>
            </tr>

            <tr>
                <td>
                    <input type="button" id="cp_submit" value="Create" style="height: 30px;">
                    <input type="button" id="cp_cancel" value="Cancel" style="height: 30px;" onclick="window.location.href = '../default.aspx';">
                </td>
            </tr>
        </table>


        <script src="../js/profilecreation.js">

        </script>
</asp:Content>
