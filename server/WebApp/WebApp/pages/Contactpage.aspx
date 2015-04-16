<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Contactpage.aspx.cs" Inherits="WebApp.pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

<div class="main_panel" style="width:600px; margin:0 auto;">
<legend>Email Us:</legend>
<legend>Get in touch with us by email.</legend>
Name:<br>
<input type="text" name="Name" value="">
<br>
Phone:<br>
<input type="text" name="Phone" value="">
<br>
Email:<br>
<input type="text" name="Email" value=""
<br>
Address:<br>
<input type="text" name="Adress" value=""
<br>
Comments:<br>
<input type="text" name="Comments" value=""
<br><br>
<input type="button" value="Submit">
</div> 
     
</asp:Content>

 