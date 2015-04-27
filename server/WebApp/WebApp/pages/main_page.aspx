<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="main_page.aspx.cs" Inherits="WebApp.pages.main_page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- <div id="news" style="width: 550px; height: 400px; margin: 0 auto;">
            <ul class="slideshow">
               
                <li class="photo"><img src="../images/connection.jpg" width="600" height="400" title="Universal Database"/></li>
                <li class="photo"><img src="../images/medics.jpg" width="600" height="400" title="Doctors"/></li>
            </ul>
    </div> -->

    <script type="text/javascript" src="../js/jssor.js"></script>
    <script type="text/javascript" src="../js/jssor.slider.js"></script>
    <div class="main_panel" style="margin: 0 auto; width: 600px;">

        <div id="slider1_container" style="position: relative; top: 0px; left: 0px; width: 600px; height: 400px; overflow: hidden;">

            <!-- Loading Screen -->
            <div u="loading" style="position: absolute; top: 0px; left: 0px;">
                <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; background-color: #000000; top: 0px; left: 0px; width: 100%; height: 100%;">
                </div>
                <div style="position: absolute; display: block; background: url(../img/loading.gif) no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;">
                </div>
            </div>

            <!-- Slides Container -->
            <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 600px; height: 300px; overflow: hidden;">
                <div>
                    <img u="image" src="../images/landscape/02.jpg" /> 
                    <div u="caption"style="position:absolute; background-color:rgba(0,0,0,0.6); color:#fff;  bottom:  0 ; width:600px; height:50px;">
                        fuck
                    </div>
                </div>
                <div>
                    <img u="image" src="../images/landscape/03.jpg" />
                    
                    <div u="caption"style="position:absolute; background-color:rgba(0,0,0,0.6); color:#fff;  bottom:  0 ; width:600px; height:50px;">
                        my
                    </div>
                </div>
                <div>
             
                    <img u="image" src="../images/landscape/04.jpg" />
                     <div u="caption"style="position:absolute; background-color:rgba(0,0,0,0.6); color:#fff;  bottom:  0 ; width:600px; height:50px;">
                        life
                    </div>
                </div>
            </div>
        </div>
        <!--#region Bullet Navigator Skin Begin -->
        <!-- Help: http://www.jssor.com/development/slider-with-bullet-navigator-jquery.html -->
        <style>
            /* jssor slider bullet navigator skin 05 css */
            /*
            .jssorb05 div           (normal)
            .jssorb05 div:hover     (normal mouseover)
            .jssorb05 .av           (active)
            .jssorb05 .av:hover     (active mouseover)
            .jssorb05 .dn           (mousedown)
            */
            .jssorb05 {
                position: absolute;
            }

                .jssorb05 div, .jssorb05 div:hover, .jssorb05 .av { 
                    /* size of bullet elment */
                    width: 16px;
                    height: 16px;
                    background: url(../images/b05.png) no-repeat;
                    overflow: hidden;
                    cursor: pointer;
                }

                .jssorb05 div {
                    background-position: -7px -7px;
                }

                    .jssorb05 div:hover, .jssorb05 .av:hover {
                        background-position: -37px -7px;
                    }

                .jssorb05 .av {
                    background-position: -67px -7px;
                }

                .jssorb05 .dn, .jssorb05 .dn:hover {
                    background-position: -97px -7px;
                }
        </style>
        <!-- bullet navigator container -->
        <div u="navigator" class="jssorb05" style="bottom: 16px; right: 6px;">
            <!-- bullet navigator item prototype -->
            <div u="prototype"></div>
        </div>
        <!--#endregion Bullet Navigator Skin End -->

        <!--#region Arrow Navigator Skin Begin -->
        <!-- Help: http://www.jssor.com/development/slider-with-arrow-navigator-jquery.html -->
        <style>
            /* jssor slider arrow navigator skin 12 css */
            /*
            .jssora12l                  (normal)
            .jssora12r                  (normal)
            .jssora12l:hover            (normal mouseover)
            .jssora12r:hover            (normal mouseover)
            .jssora12l.jssora12ldn      (mousedown)
            .jssora12r.jssora12rdn      (mousedown)
            */
            .jssora12l, .jssora12r {
                display: block; 
                /* size of arrow element */
                width: 30px;
                height: 46px;
                cursor: pointer;
                background: url(../images/a12.png) no-repeat;
                overflow: hidden;
            }

            .jssora12l {
                background-position: -16px -37px;
            }

            .jssora12r {
                background-position: -75px -37px;
            }

            .jssora12l:hover {
                background-position: -136px -37px;
            }

            .jssora12r:hover {
                background-position: -195px -37px;
            }

            .jssora12l.jssora12ldn {
                background-position: -256px -37px;
            }

            .jssora12r.jssora12rdn {
                background-position: -315px -37px;
            }
        </style> 
    </div>

    <script src="/js/main_page.js">

    </script>
</asp:Content>
