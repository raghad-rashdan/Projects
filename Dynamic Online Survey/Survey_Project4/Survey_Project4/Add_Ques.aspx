<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Ques.aspx.cs" Inherits="Survey_Project4.Add_Ques" %>

<meta name="viewport" content="width=device-width, initial-scale=1.0">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<style type="text/css">
.larg{
    width:70%;
   
     padding:0% 14%;
}
.main{
    display:flex;
    flex-direction:column;
    justify-content: space-around;
}
.one{width:100%; 
    
    background-color: #7167AE;
    height:100px;
    
    display: flex;
    flex-direction: column;
   }
    
   
.two{width:100%;background-color:#E6E6E6; }
.t{padding:3% 3%; width:100%;}
.b{width:10%;height:40px; font-size:large;margin-top:2%; margin-left:40%; color:#FADB7F; background-color:#7167AE; border-color:#7167AE;}
.navbar {
    background-color: #7167AE;
    height:120px;
    width: 100%;
   
}
.h{
   
    float:left;
    margin-top:40px;
    margin-left:35px;
    color:#FADB7F
}
.about {
    font-family: 'Times New Roman', Times, serif;
    
    font-weight: bold;
    color: #FADB7F;
    text-align: center;
    font-size: x-large;
    background-color: #7167AE;
    border: 1px solid #7167AE;
    float:right;
    margin-top:40px;
    margin-right:30px;
}
    @media only screen and (min-device-width: 481px) and (max-device-width: 768px) {
        .b {
            width: 20%;
        }
    }
    @media only screen and (min-device-width: 0) and (max-device-width: 480px) {
        .E {
            width: 20%;
            margin-left: 73%;
        }
      .one{height:150px;}
        .b {
            width: 40%;
            margin-left: 25%;
        }
      
    }
  
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="larg">
        <div class="main">
            <div class="navbar">
            <h1 class="h"> Survey question by admin </h1>
            <asp:Button ID="about" runat="server" Text="Result" CssClass="about" />
            <asp:Button ID="home" runat="server" Text="Exit" CssClass="about"  />

        </div>
            <%--<div class="one"> 
                  
                <button class="E">Exit</button>
                <h1  class="h" style=" margin-left:3%; color:#FADB7F; margin-top:-3%;"> survey question by admin </h1>
            </div>--%>
            <div class="two">
                <div class="t">
                <asp:Label ID="Label1" runat="server" Text="Question 1" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox1" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label2" runat="server" Text="Question 2" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox2" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label3" runat="server" Text="Question 3" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox3" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label4" runat="server" Text="Question 4" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox4" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label5" runat="server" Text="Question 5" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox5" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label6" runat="server" Text="Question 6" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox6" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label7" runat="server" Text="Question 7" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox7" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label8" runat="server" Text="Question 8" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox8" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label9" runat="server" Text="Question 9" Style="font-size:x-large"></asp:Label><br /><br />
                <asp:TextBox ID="TextBox9" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />

                    <asp:Label ID="Label10" runat="server" Text="Question 10" Style="font-size:x-large"></asp:Label><br /><br>
                <asp:TextBox ID="TextBox10" runat="server" style="width:90%;font-size:x-large;"></asp:TextBox> <br /><br /><br />
                    <asp:Label ID="su1" runat="server" Text=""></asp:Label>

                    <asp:Button ID="Button1" Class="b" runat="server" Text="Submit" OnClick="Button1_Click" />
                   
                    </div>
                
            </div>
          
        </div>
        </div>
    </form>
</body>
</html>