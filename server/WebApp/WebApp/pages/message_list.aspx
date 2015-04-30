<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="message_list.aspx.cs" Inherits="WebApp.pages.message_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="main_panel" style="width: 600px; margin: 0 auto;">
        <input type="button" id="backbtn" style="float: left;" value="Back" onclick="window.location.href = '/default.aspx';" />
        <div style="margin: 0 auto; text-align: center; font-weight: bold; font-size: 16px; padding: 10px;">
            All Messges
        </div>
        <div>
            <div id="m_list" style="height: 400px; box-sizing: content-box; overflow: auto;"></div>
        </div>
    </div>
    <script src="/js/messagelist.js"></script>
</asp:Content>
