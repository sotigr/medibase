<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Contactpage.aspx.cs" Inherits="WebApp.pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>
<html>
<body>


<fieldset>
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
<input type="submit" value="Submit">
</fieldset>
</form>

</body>
</html>
</asp:Content>

 