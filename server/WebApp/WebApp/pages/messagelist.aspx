<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="messagelist.aspx.cs" Inherits="WebApp.pages.messagelist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_panel" style="background-color: #4C2D74; width: 600px; margin: 0 auto; margin-top: 100px;">
        <table align="center">
            <tr>
                <td>Messages:
                </td>
                <td>Order by:
                </td>
                <td>
                    <select id="order">
                        <option value="orddate" selected>Date</option>
                        <option value="ordsender">Sender</option>
                        <option value="ordsubject">Subject</option>
                    </select>
                </td>
            </tr>
            <table style="background-color: #fff; width: 90%;">
                <tr>
                    <td>
                        <input type="button" id="expand" value=">" style="font-size:22px; color: #000; width: 30px; height: 30px; border-radius: 100%; border: 1px solid #080000; background-color: #F9F9F9; height: 30px;">
                    </td>
                    <td align="left">Message1
                    </td>
                    <td align="right">
                        <input type="button" id="delete" value="X" style="width: 30px; height: 30px; border-radius: 100%; background-color: #D02121; height: 30px;">
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="button" id="expand" value=">" style="font-size:22px; color: #000; width: 30px; height: 30px; border-radius: 100%; border: 1px solid #080000; background-color: #F9F9F9; height: 30px;">
                    </td>
                    <td align="left">Message2
                    </td>
                    <td align="right">
                        <input type="button" id="delete" value="X" style="width: 30px; height: 30px; border-radius: 100%; background-color: #D02121; height: 30px;">
                    </td>
                </tr>
            </table>
        </table>
    </div>
</asp:Content>
