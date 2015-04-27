<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="information_page.aspx.cs" Inherits="WebApp.pages.information_page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_panel" id="tab_list" style="width: 600px; margin: 0 auto; margin-top: 50px;">
        <ul>
            <li><a href="#about_tab">About Us</a></li>
            <li><a href="#info_tab">Application Information</a></li>
            <li><a href="#admin_tab">Admins</a></li>
        </ul>
        <div id="about_tab">
            <h3></h3>
            <h3>The Team</h3>
            <p>- Karmiris Dimitrios:</p>
            <p>Project Manager</p>
            <p>Programmer</p>
            <p>Web Page Developer</p>
            <p>Tester</p>
            <p>- Papaioannou Sotirios:</p>
            <p>Senior Programmer</p>
            <p>Web Page Developer</p>
            <p>Tester</p>
            <p>- Mytilinaios Artemios:</p>
            <p>Databaser</p>
            <p>Web Page Developer</p>
            <p>- Iessai Michael:</p>
            <p>Web Page Developer</p>
        </div>
        <div id="info_tab">
            <h3>The Application</h3>
            <p>This Application was created primarly to assist medical personnel in finding information about a potential or existing patient faster and more accurately, as well as communicate with personnel of the collaborating hospitals and notify patients through messages.</p>
            <p>As a secondary role, it can help any given individual keep track of his health record and medical background.</p>
            <br />
            <h3>The Idea</h3>
            <p>Since people tend to forget or omit parts of their medical background that might be crucial for their treatment or examination, and doctors are always trying to find a faster way of communication between them as well as have a more detailed medical background of their patients, we thought that a unified, universal medical database would be a great idea to start covering these needs.</p>
        </div>
        <div id="admin_tab">
            <h3>Administrators</h3>
            <p>- Papaioannou Sotirios</p>
            <p>- Karmiris Dimitrios</p>
        </div>
    </div>

    <script src="/js/information_page.js">

    </script>
</asp:Content>
