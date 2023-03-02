<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Q.aspx.cs" Inherits="Survey_Project4.User_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>project 4</title>
    <style>
    body{
        /* display: flex;
        justify-content: center; */
       /* margin-left:20% ;*/
    }
    #container{
        margin-left:17%;
    }
    /*  header */    
.header{
display:flex ;
flex-direction: row;
justify-content: space-between;
background-color: #7167AE;
width: 100%;
color: #FADB7F;
    }
    .logo{
        
         width: 151px;
    height: 70px;
    float: left;
    margin-left: 35px;
    
            
    }
    .login{
font-weight:bold;
width: 8%;
 font-size:20px;
padding-left: 5%;
padding-top: 25px;
display:flex ;
flex-direction: row;
justify-content: space-between;
    }
    .link{
        width: 40%;
display: inline-block;
    }
    a{
        text-decoration: none;
        color: #FADB7F;
        width:10%;
        font-family:'Times New Roman';

    }
    /* footer */
    .footer{
        
        background-color: #7167AE;
        color: #FADB7F;
        font-size:20px;
     text-align:center;
        height:60px;
         padding-top: 1px;
    }
    #quastion-main {
        background-color: #F2F2F2;
        width: 80%;
        height: 100%;
        display: flex;
        margin-top: 80px;
    margin-bottom: 80px;
       
       
        }
    form{
       /* display: flex;
    justify-content: space-evenly;*/
    
    }
    td{
        display: flex;
    justify-content: space-around;
    font-size: 20px;
    padding-top: 50px;
    padding-right: 130px;
}
    th{
       
       font-size: 25px;
       text-align:left;
       padding-left:80px;
       padding-top:50px;
}
    
    h1{
        font-size: 50px;
    padding-left: 50px;
    }
   #submit{
    
     border: 1px solid #7167AE;
     background: #7167AE;
     color: #FADB7F;
     padding: 10px 20px;
     font-size: 20px;
    cursor:pointer;
    transition: transform .3s;
        position: relative;
    overflow: hidden;
    border-radius: 15px;
    
   }
   #submit:hover{
    
    transform: scale(1.2);
   }
  
   #div-button{
    background-color: #F2F2F2;
    display: flex;
    justify-content: center;
    width: 80%;
    padding-top: 40px;
    padding-bottom: 30px;
}
   .button{
           padding-bottom: 40px;
           padding-left: 120px;
   }
    </style>
</head>
<body>
    <!-- header -->
    <div class="header">
        <div class="logo">
            <asp:Image class="logo" ID="Image1" runat="server"  ImageUrl="~/Images/logo.png"/>
        </div>
        <div class="login">
            <div class="link">   
          
            <a href="" target="_blank">Logout</a>

            </div>

        </div>
    </div>
    <div id="container">
    <div id="quastion-main">
      <form runat="server">

          <h1>Feedback Survey</h1>
        <table id="table-qua">
            <tr id="q1">
                <th>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
            <td>


                    
                <label>  <input type="radio"name="answer1" value="Exellent" required="required"/> Exellent<span></span></label>

                <label>  <input type="radio"name="answer1" value="V.Good" required="required"/> V.good<span></span></label>
                <label> <input type="radio"name="answer1"value="Good" required="required"/> Good<span></span></label>
                <label> <input type="radio"name="answer1"value="Poor" required="required"/> Poor<span></span></label>
                    

            </td>
            </tr>
            <tr id="q2">
                <th>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
            <td>
                    <label> <input type="radio" name="answer2" value="Exellent" required="required"/> Excellent <span></span></label>
                <label>  <input type="radio"name="answer2" value="V.Good" required="required"/> V.good<span></span></label>
                <label> <input type="radio"name="answer2" value="Good" required="required"/> Good<span></span></label>
                <label> <input type="radio"name="answer2" value="Poor" required="required"/> Poor<span></span></label>             
            </td>
            </tr>
            <tr id="q3">
                <th>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer3" value="Exellent" required="required"/> Excellent <span></span></label>
                    <label>  <input type="radio"name="answer3" value="V.Good" required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer3"value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer3" value="Poor"  required="required"/> Poor<span></span></label>        
            </td>
            </tr>
            <tr id="q4">
                <th>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer4" value="Exellent" required="required" /> Excellent <span></span></label>
                    <label> <input type="radio"name="answer4" value="V.Good" required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer4" value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer4" value="Poor" required="required"/> Poor<span></span></label>      
            </td>
            </tr>
            <tr id="q5">
                <th>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                <label> <input type="radio" name="answer5" value="Exellent" required="required"/> Excellent <span></span></label>
                <label>  <input type="radio"name="answer5" value="V.Good" required="required"/> V.good<span></span></label>
                <label> <input type="radio"name="answer5" value="Good" required="required"/> Good<span></span></label>
                <label> <input type="radio"name="answer5" value="Poor" required="required"/> Poor<span></span></label>
            </td>
            </tr>
            <tr id="q6">
                <th>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer6"value="Exellent" required="required"/> Excellent <span></span></label>
                    <label> <input type="radio"name="answer6"value="V.Good" required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer6" value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer6"value="Poor" required="required"/> Poor<span></span></label>             
            </td>
            </tr>
            <tr id="q7">
                <th>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer7" value="Exellent" required="required"/> Excellent <span></span></label>
                    <label>  <input type="radio"name="answer7" value="V.Good" required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer7" value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer7"value="Poor" required="required"/> Poor<span></span></label>             
            </td>
            </tr>
            <tr id="q8">
                <th>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer8" value="Exellent" required="required"/> Excellent <span></span></label>
                    <label>  <input type="radio"name="answer8" value="V.Good" required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer8" value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer8" value="Poor" required="required"/> Poor<span></span></label>             
            </td>
            </tr>
            <tr id="q9">
                <th>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer9" value="Exellent" required="required" /> Excellent <span></span></label>
                    <label>  <input type="radio"name="answer9" value="V.Good" required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer9" value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer9" value="Poor" required="required"/> Poor<span></span></label>             
            </td>
            </tr>
            <tr id="q10">
                <th>
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                </th>
            </tr>
            <tr id="">
                <td>
                    <label> <input type="radio" name="answer10"  value="Exellent" required="required"/> Excellent <span></span></label>
                    <label>  <input type="radio"name="answer10"value="V.Good    " required="required"/> V.good<span></span></label>
                    <label> <input type="radio"name="answer10"value="Good" required="required"/> Good<span></span></label>
                    <label> <input type="radio"name="answer10"value="Poor" required="required"/> Poor<span></span></label>            

                   

                


            </td>
            </tr>
            <tr>
                <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                <td class="button">
                     <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="Button" />

                </td>
            </tr>
          
                
            
        </table>



      </form>

      
    </div>
        
   <%-- <div id="div-button" >
        <button  id="submit"  type="submit" runat="server">submit </button>
       </div>--%>
        </div>

    <!-- footer -->
    <div class="footer">
    <p>  All rights reserved to Orange @ 2022</p>
</div>

</body>
    
</html>
