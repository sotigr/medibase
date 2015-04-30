<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="main_page.aspx.cs" Inherits="WebApp.pages.main_page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="text-align: center; color: #000;">
        <h1>Welcome to Medipli!
        </h1>
        <p style="font-style: italic;">The Universal Medical Application and Database!</p>

    </div>
    <script type="text/javascript" src="../js/jssor.js"></script>
    <script type="text/javascript" src="../js/jssor.slider.js"></script>
    <div class="main_panel" style="margin: 0 auto; width: 600px;">

        <div id="slider1_container" style="position: relative; top: 0px; left: 0px; right: 0; margin: 0 auto; width: 800px; height: 600px; overflow: hidden;">

            <!-- Loading Screen -->
            <div u="loading" style="position: absolute; top: 0px; left: 0px;">
                <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000000; top: 0px; left: 0px; width: 100%; height: 100%;">
                </div>
                <div style="position: absolute; display: block; background: url(../img/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
                </div>
            </div>

            <!-- Slides Container -->
            <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 800px; height: 600px; overflow: hidden;">
                <div>
                    <img u="image" src="../images/connection.jpg" />
                    <div u="caption" style="position: absolute; background-color: rgba(255, 255, 255, 0.6); color: #000; bottom: 0; width: 800px;">
                        <h3>Global Connection</h3>
                        <p>Cooperate and share knowledge with hospitals from all around the world!</p>
                    </div>
                </div>
                <div>
                    <img u="image" src="../images/doctor_examination2.jpg" />
                    <div u="caption" style="position: absolute; background-color: rgba(255, 255, 255, 0.6); color: #000; bottom: 0; width: 800px;">
                        <h3>Professional Health Search</h3>
                        <p>Getting help and finding patients' health background made easy!</p>
                    </div>
                </div>
                <div>
                    <img u="image" src="../images/man_computer.jpg" />
                    <div u="caption" style="position: absolute; background-color: rgba(255, 255, 255, 0.6); color: #000; bottom: 0; width: 800px;">
                        <h3>Personal Health Background</h3>
                        <p>Keep track of all your past personal health records!</p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="/js/main_page.js">

    </script>
</asp:Content>
