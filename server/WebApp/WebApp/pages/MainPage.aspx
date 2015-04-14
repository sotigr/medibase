<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApp.pages.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="text-align:center;">
        <h1>Welcome to Medical Center</h1>
    </div>
<hr>
    
    <div style="width:100;">
        
        <button type="button" onclick="alert('Hello world!')">Button6</button>
        <button type="button" style="float:left;" onclick="alert('Hello world!')">Button1</button>
        <button type="button" style="float:left;" onclick="alert('Hello world!')">Button2</button>
        <button type="button" style="float:left;" onclick="alert('Hello world!')">Button3</button>
        <button type="button" style="float:left;" onclick="alert('Hello world!')">Button4</button>
        <button type="button" style="float:left;" onclick="alert('Hello world!')">Button5</button>

    </div>   
<div class="panel" style="width:20%; margin:0 auto; margin-top:5%;">   
</div>
        <div align="right"><body>
    <script language="javascript" type="text/javascript">
        var day_of_week = new Array('Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat');
        var month_of_year = new Array('January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December');


        var Calendar = new Date();

        var year = Calendar.getFullYear();     // Returns year
        var month = Calendar.getMonth();    // Returns month (0-11)
        var today = Calendar.getDate();    // Returns day (1-31)
        var weekday = Calendar.getDay();    // Returns day (1-31)

        var DAYS_OF_WEEK = 7;    // "constant" for number of days in a week
        var DAYS_OF_MONTH = 31;    // "constant" for number of days in a month
        var cal;    // Used for printing

        Calendar.setDate(1);    // Start the calendar day at '1'
        Calendar.setMonth(month);    // Start the calendar month at now


        /* VARIABLES FOR FORMATTING
        NOTE: You can format the 'BORDER', 'BGCOLOR', 'CELLPADDING', 'BORDERCOLOR'
              tags to customize your caledanr's look. */

        var TR_start = '<TR>';
        var TR_end = '</TR>';
        var highlight_start = '<TD WIDTH="30"><TABLE CELLSPACING=0 BORDER=1 BGCOLOR=DEDEFF BORDERCOLOR=CCCCCC><TR><TD WIDTH=20><B><CENTER>';
        var highlight_end = '</CENTER></TD></TR></TABLE></B>';
        var TD_start = '<TD WIDTH="30"><CENTER>';
        var TD_end = '</CENTER></TD>';

        /* BEGIN CODE FOR CALENDAR
        NOTE: You can format the 'BORDER', 'BGCOLOR', 'CELLPADDING', 'BORDERCOLOR'
        tags to customize your calendar's look.*/

        cal = '<TABLE BORDER=1 CELLSPACING=0 CELLPADDING=0 BORDERCOLOR=BBBBBB><TR><TD>';
        cal += '<TABLE BORDER=0 CELLSPACING=0 CELLPADDING=2>' + TR_start;
        cal += '<TD COLSPAN="' + DAYS_OF_WEEK + '" BGCOLOR="#EFEFEF"><CENTER><B>';
        cal += month_of_year[month] + '   ' + year + '</B>' + TD_end + TR_end;
        cal += TR_start;

        //   DO NOT EDIT BELOW THIS POINT  //

        // LOOPS FOR EACH DAY OF WEEK
        for (index = 0; index < DAYS_OF_WEEK; index++) {

            // BOLD TODAY'S DAY OF WEEK
            if (weekday == index)
                cal += TD_start + '<B>' + day_of_week[index] + '</B>' + TD_end;

                // PRINTS DAY
            else
                cal += TD_start + day_of_week[index] + TD_end;
        }

        cal += TD_end + TR_end;
        cal += TR_start;

        // FILL IN BLANK GAPS UNTIL TODAY'S DAY
        for (index = 0; index < Calendar.getDay() ; index++)
            cal += TD_start + '  ' + TD_end;

        // LOOPS FOR EACH DAY IN CALENDAR
        for (index = 0; index < DAYS_OF_MONTH; index++) {
            if (Calendar.getDate() > index) {
                // RETURNS THE NEXT DAY TO PRINT
                week_day = Calendar.getDay();

                // START NEW ROW FOR FIRST DAY OF WEEK
                if (week_day == 0)
                    cal += TR_start;

                if (week_day != DAYS_OF_WEEK) {

                    // SET VARIABLE INSIDE LOOP FOR INCREMENTING PURPOSES
                    var day = Calendar.getDate();

                    // HIGHLIGHT TODAY'S DATE
                    if (today == Calendar.getDate())
                        cal += highlight_start + day + highlight_end + TD_end;

                        // PRINTS DAY
                    else
                        cal += TD_start + day + TD_end;
                }

                // END ROW FOR LAST DAY OF WEEK
                if (week_day == DAYS_OF_WEEK)
                    cal += TR_end;
            }

            // INCREMENTS UNTIL END OF THE MONTH
            Calendar.setDate(Calendar.getDate() + 1);

        }// end for loop

        cal += '</TD></TR></TABLE></TABLE>';

        //  PRINT CALENDAR
        document.write(cal);

        //  End -->
</script>
</body>
</div>   
    <style>
        .main{
            position: absolute;
            top: 20%;
            margin-left: 25%;
            margin-right: 25%;
        }
              
        .links{
          position: absolute;
          top:20%;                   
       }            
    </style> 
    <div style="text-align:center;" class="main_panel" margin-left: 25%; >
        <center><font size='+2'>Information</font></center>
        This medical application is a web Application that will have to do with the medical background of a User. In details, the application will be accessible to everyone, but only limited features will be available, such as finding an overnight pharmacy or hospital. In order to access further features of the application the User will have to Sing Up and create a Profile. Upon signing up, a verification e-mail will be sent to the e-mail he/she provided.
        Depending on the User’s Occupation he will have access to some or all the features in the application. For example, a doctor (who has the highest level of accessibility) can receive and send e-mails, check a patient’s, or his own, medical background, contact and search for other personnel in a hospital, as well as receive newsletters from medical sites.
        Users will have a Live Chat feature that will allow them to immediate access to some questions they have or help they need, such as contacting for an emergency.
    </div>
<div align="left"; class="links"><p>Quick Links:
<br><a href=''>Something1</a>
<br><a href=''>Something2</a>
<br><a href=''>Something3</a>
<br><a href=''>Something4</a>
</div>

</html>
</asp:Content>
