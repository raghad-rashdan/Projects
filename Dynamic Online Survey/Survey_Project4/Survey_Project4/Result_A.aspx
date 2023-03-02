<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result_A.aspx.cs" Inherits="Survey_Project4.Result_A" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="Result_CSS.css" rel="stylesheet" />
</head>
 
<body>
    <form id="form1" runat="server">
     
    <!-- header -->
    <div class="header">
        <div class="logo">
            <img src="logo.jpeg" class="imglogo" style="width:100px; height:50px;" />
        </div>
        <div class="login">
            <div class="link">
            <a href="" target="_blank">AddQues</a></div>
            <a href="" target="_blank">login</a></div>
        </div>
    </div>
<br />
<%--cont--%>
<div class="con">
<div class="detials">
    <h2> welcome <asp:Label ID="Label1" runat="server" Text=""></asp:Label> </h2>
    
    <p>here  you can find employees no and the date when they clicked on submit button .</p>
</div><br />
<%--table--%>
    <div>
            <asp:Table ID="Table1" CssClass="table table-striped" runat="server">
                <asp:TableRow>
                <asp:TableHeaderCell>
                    sequence number
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    employee no.
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    employee email
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    file
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    1
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    2
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    3
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    4
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    5
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    6
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    7
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    8
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    9
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>

                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    10
                </asp:TableHeaderCell>               
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    
                </asp:TableHeaderCell>
               
                </asp:TableRow>
            </asp:Table>
        </div>
    <br /><br />
    <%--button--%>
    <div class="btnclose">
        <asp:Button ID="Button1" runat="server" Text="log out"  />
    </div>
</div>
<br /> <br />
<!-- footer -->
<div class="footer">
    <p>  All rights reserved to Orange @ 2022</p>
</div>

    </form>
</body>
</html>
