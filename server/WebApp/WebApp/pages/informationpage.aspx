<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="informationpage.aspx.cs" Inherits="WebApp.pages.informationpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2></h2>

<ul style="list-style-type:disc">
 <!DOCTYPE html>
<html>
<head>
<style>
    div {
    border: 2px solid #a1a1a1;
    padding: 10px 40px; 
    background: #dddddd;
    width: 700px;
    border-radius: 25px;
}
p {
    border-top-style: dotted;
    border-right-style: solid;
    border-bottom-style: dotted;
    border-left-style: solid;
}
     p {
    border: px solid red;
}
    h1 {
    text-align: center;
}

p.date {
    text-align: right;
}

p.main {
    text-align: justify;
}
    p {
    text-align: center;
    color: red;
    }
</style>
</head>
<body>
  
 <h1>Information page</h1>

<div class="mainstyle">
    </div>
    This medical application is designed to facilitate physicians in hospitals about the history of each patient.For example what tests the patient has done or if  he had  undergone a surgery . Also this application can be useful for the nurses because they can use it to know for example what action must administered to each patient. 
    
    <p>Home</p>

<p>About</p>    
<p>Availabe hospitsals</p>
<p>Availabe pharmacies</p>
<p>Links to </p>
<p>Emegerncy phones</p>
<p>This is some text in a paragraph.</p>
       
</body>
</html>  
  <br /> 
  
  
 
</asp:Content>
