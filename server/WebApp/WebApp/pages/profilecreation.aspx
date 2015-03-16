<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="profilecreation.aspx.cs" Inherits="WebApp.pages.profilecreation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="main_panel" style="width:600px; margin:0 auto; margin-top:50px; ">
        <div style="text-align:center;">
            <h1>Profile creation</h1>
            <p>Please enter the following information.</p> 
        </div> 
        <table align="center">
            <tr>
                <td>Title:
                </td>
                <td>
                    <select>
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
                    <input type="text"/>
                </td>
            </tr>
            <tr>
                <td>Lastname:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Gender:
                </td>
                <td>
                    <input id="radio1" type="radio" name="sex" value="male">Male
					<input type="radio" name="sex" value="female">Female
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
                    <input type="text"  />
                </td>
            </tr>
            <tr>
                <td>Password:
                </td>
                <td>
                    <input type="password" />
                </td>
            </tr>
            <tr>
                <td>Re-enter Password:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Occupation *:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Address:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Zip Code:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Phone No.:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Mobile No.:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>City:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
            <tr>
                <td>Country:
                </td>
                <td>
                    <input type="text" />
                </td>
            </tr>
           
            <tr>
                <td   >
                    <input type="button" id="sub" value="Submit" style="height:30px;"  >
                    <input type="button" id="sub" value="Cancel" style="height:30px;" onclick="window.location.href = '../default.aspx';"  >
                </td>
            </tr>
        </table>


        <script>

            var $select = $("#day");
            for (i = 1; i <= 31; i++) {
                $select.append($('<option></option>').val(i).html(i))
            }

            var $select = $("#year");
            var d = new Date();
            for (i = d.getFullYear() ; i >= 1900 ; i--) {
                $select.append($('<option></option>').val(i).html(i))
            }
        </script>
</asp:Content>
