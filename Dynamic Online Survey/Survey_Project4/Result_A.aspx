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
         <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/logo.png" CssClass="imglogo" style="width:100px; height:50px;"/>

<%--            <img  runat="server" ImageUrl="~/Images/logo.png" class="imglogo" style="width:100px; height:50px;" />--%>
        </div>
        <div class="login">
            <div class="link">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Add_Ques.aspx">AddQues</asp:HyperLink></div>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink></div>

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
                    Num
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    Emp Name
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    Emp NO
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    file
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    1
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row11">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row12">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row13">
                    <asp:HyperLink ID="HyperLink3" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    2
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row21">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row22">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row23">
                    <asp:HyperLink ID="HyperLink4" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    3
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row31">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row32">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row33">
                <asp:HyperLink ID="HyperLink5" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    4
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row41">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row42">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row43">
                    <asp:HyperLink ID="HyperLink6" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    5
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row51">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row52">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row53">
                    <asp:HyperLink ID="HyperLink7" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    6
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row61">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row62">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row63">
                    <asp:HyperLink ID="HyperLink8" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    7
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row71">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row72">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row73">
                    <asp:HyperLink ID="HyperLink9" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    8
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row81">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row82">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row83">
                    <asp:HyperLink ID="HyperLink10" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    9
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row91">

                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row92">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row93">
                    <asp:HyperLink ID="HyperLink11" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
                
                </asp:TableRow>

                <asp:TableRow>
                <asp:TableHeaderCell>
                    10
                </asp:TableHeaderCell>               
                <asp:TableHeaderCell ID="row101">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row102">
                    
                </asp:TableHeaderCell>
                <asp:TableHeaderCell ID="row103">
                    <asp:HyperLink ID="HyperLink12" runat="server"></asp:HyperLink>
                </asp:TableHeaderCell>
               
                </asp:TableRow>
            </asp:Table>
        </div>
    <br /><br />
    <%--button--%>
    <div class="btnclose">
        <asp:Button ID="Button1" runat="server" Text="log out" OnClick="Button1_Click" />
<%--                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink></div>--%>

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
