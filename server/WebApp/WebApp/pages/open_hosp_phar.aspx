<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="open_hosp_phar.aspx.cs" Inherits="WebApp.pages.open_hosp_phar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        p1 {
            font-size: 14px;
        }

        p2 {
            font-size: 10px;
            color: red;
        }
    </style>

    <div class="main_panel" style="width: 600px; margin: 0 auto; margin-top: 50px;">
        <div style="text-align: center;">
            <h1>Medical Help Search</h1>
            <p1>Find open and overnight Hospitals and Pharmacies near you.</p1>
            <br />
            <br />
            <p2>(*WARNING* Selection redirects to an external link of the official Health or National Health site of the respective country.)</p2>
            <br />
            <br />
            <br />
            <br />
        </div>
        <table align="center">
            <tr>
                <td>Select your Country:
                </td>
                <td>
                    <select id="sel_country" onchange="this.options[this.selectedIndex].value && (window.location = this.options[this.selectedIndex].value);">
                        <option value="" selected>Select...</option>
                        <option value="http://www.nhs.uk/Service-Search">Australia</option>
                        <option value="http://germany.angloinfo.com/healthcare/health-system/medical-services/">Germany</option>
                        <option value="http://www.moh.gov.gr/articles/citizen">Greece</option>
                        <option value="http://www.nhs.uk/Service-Search">United Kingdom</option>
                        <option value="http://www.walgreens.com/storelocator/find.jsp?requestType=locator">United States</option>
                    </select>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>

</asp:Content>
