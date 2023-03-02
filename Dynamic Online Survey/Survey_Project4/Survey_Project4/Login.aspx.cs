using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Survey_Project4
{
    public partial class Login : System.Web.UI.Page
    {
        public bool exist_in_file = false;
        public bool exist_in_arr = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void login_Click(object sender, EventArgs e)
        //{
        //    string[] userN = { "Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Hala" };
        //    string[] userID = { "1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "2424" };
        //    for(int i = 0; i < userN.Length; i++)
        //    {
        //        if((User_input.Text == "Sara" && Id_input.Text == "1124")|| (User_input.Text == "Ahmad" && Id_input.Text == "1524")) {
        //            //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);
        //            mess.Text = "Welcome Admin";
        //            break;
        //        }
        //        else if (User_input.Text == userN[i]&& Id_input.Text == userID[i])
        //        {
        //            //    string[] user_info = File.ReadAllLines(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt");
        //            //    if (user_info.Length == 0)
        //            //    {
        //            //        using (StreamWriter new_user = File.AppendText(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt"))
        //            //        {
        //            //            new_user.WriteLine(User_input.Text + " " + Id_input.Text);
        //            //            mess.Text = ("Thanks For Your Time ");
        //            //            //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);
        //            //        }
        //            //    }
        //            //    else { 
        //            //    for(int j=0;j< user_info.Length; j++)
        //            //    {
        //            //        string[] user= user_info[i].Split(' ');
        //            //        if (user[0]== User_input.Text && user[1]== Id_input.Text)
        //            //        {
        //            //            mess.Text = "You Are Already Exist";
        //            //            //Response.Redirect("Login.aspx");
        //            //        }
        //            //        else
        //            //        {
        //            //            using(StreamWriter new_user = File.AppendText(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt"))
        //            //            {
        //            //                new_user.WriteLine(User_input.Text +" "+ Id_input.Text);
        //            //                mess.Text=("Thanks For Your Time ");
        //            //                //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);
        //            //            }
        //            //        }
        //            //    }
        //            //    }

        //            //    //mess.Text = "";

        //            //    break;

        //        }
        //        else if(User_input.Text ==String.Empty || Id_input.Text == String.Empty)
        //        {
        //            //Response.Redirect("Login.aspx");

        //            mess.Text = "Please Fill All Feilds";
        //        }
        //        else if(User_input.Text != userN[i] || Id_input.Text != userID[i])
        //        {

        //            mess.Text = "Wronge UserName Or ID";
        //            //Response.Redirect("Login.aspx");
        //        }
        //    }
        //}

        protected void home_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Login.aspx");
        }

        

        //protected void login_Click(object sender, EventArgs e)
        //{
        //    string[] userN = { "Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Eman" };
        //    string[] userID = { "1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "2724" };
        //    string[] user_info = File.ReadAllLines(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt");

        //    for (int u = 0; u < userN.Length; u++)
        //    {

        //        if (User_input.Text == userN[u] && Id_input.Text == userID[u])
        //        {

        //            exist_in_arr = true;
        //            break;
        //        }
        //        else exist_in_arr = false;
        //    }
        //    if (exist_in_arr == true)
        //    {
        //        /*-----------------------*/
        //        if (user_info.Length == 0)
        //        {
        //            using (StreamWriter new_user = File.AppendText(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt"))
        //            {
        //                new_user.WriteLine(User_input.Text + " " + Id_input.Text);
        //                mess.Text = ("Thanks For Your Time ");
        //                exist_in_file = true;
        //                //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);
        //            }
        //        }
        //        else
        //        {
        //            for (int i = 0; i <user_info.Length; i++)
        //            {
        //                string[] user = user_info[i].Split(' ');
        //                if (user[0] == User_input.Text && user[1] == Id_input.Text)
        //                {
        //                    //if user is an Admin
        //                    if ((User_input.Text == "Sara" && Id_input.Text == "1124") || (User_input.Text == "Ahmad" && Id_input.Text == "1524"))
        //                    {
        //                        mess.Text = "Welcome Admin";
        //                        //Response.redirect("Login.aspx");
        //                        exist_in_file = true;
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        mess.Text = "You Are Already Exist";
        //                        //Response.Redirect("Login.aspx");
        //                        exist_in_file = true;
        //                        break;
        //                    }

        //                    /*-----------------------*/
        //                }


        //            }
        //        }
        //    }

        //    else if(exist_in_arr == false)
        //    {
        //        for (int u = 0; u < userN.Length; u++)
        //        {
        //             if (User_input.Text == String.Empty || Id_input.Text == String.Empty)
        //            {
        //                //Response.Redirect("Login.aspx");

        //                mess.Text = "Please Fill All Feilds";

        //            }
        //            else if (User_input.Text != userN[u] || Id_input.Text != userID[u])
        //            {

        //                mess.Text = "Wronge UserName Or ID";
        //                exist_in_arr = false;
        //                //Response.Redirect("Login.aspx");
        //            }

        //            else exist_in_arr = false;
        //        }
        //    }
        //    else { exist_in_file = false; }
        //    if (exist_in_file == false)
        //    {
        //        using (StreamWriter new_user = File.AppendText(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt"))
        //        {
        //            new_user.WriteLine(User_input.Text + " " + Id_input.Text);
        //            mess.Text = ("Thanks For Your Time ");
        //            //Response.Redirect("?&username="+User_input.Text+"&empID="+Id_input.Text);
        //        }
        //    }
        //}
        /*---------------------------------*/
        protected void login_Click(object sender, EventArgs e)
        {
            string[] userN = { "Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Eman" };
            string[] userID = { "1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "1724" };
           
            for (int u = 0; u < userN.Length; u++)
            {
                //if user is an Admin
                if ((User_input.Text == "Sara" && Id_input.Text == "1124") || (User_input.Text == "Ahmad" && Id_input.Text == "1524"))
                {
                    mess.Text = "Welcome Admin";
                    //Response.redirect("Admin.aspx");
                    //exist_in_file = true;
                    break;
                }
                else if (User_input.Text == userN[u] && Id_input.Text == userID[u])
                {
                    mess.Text = "";
                    exist_in_arr = true;
                    break;
                }
               else if (User_input.Text == String.Empty || Id_input.Text == String.Empty)
                {
                    //Response.Redirect("Login.aspx");

                    mess.Text = "Please Fill All Feilds";
                    exist_in_arr = false;
                    break;

                }
                else if (User_input.Text != userN[u] || Id_input.Text != userID[u])
                {

                    mess.Text = "Wronge UserName Or ID";
                    exist_in_arr = false;
                    //Response.Redirect("Login.aspx");
                }

                else exist_in_arr = false;
            }
            if(exist_in_arr == true)
            {
                string[] user_info = File.ReadAllLines(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt");
                for (int i = 0; i < user_info.Length; i++)
                {
                    string[] user = user_info[i].Split(' ');
                    if (user[0] == User_input.Text && user[1] == Id_input.Text)
                    {
                        mess.Text = "You Are Already Fill The Survey";
                        exist_in_file = true;
                        break;


                        /*-----------------------*/
                    }
                    else exist_in_file = false;
                    //else
                    //{
                       
                       
                    //}


                }
                if (exist_in_file == false)
                {
                    string username = User_input.Text;
                    string empID = Id_input.Text;
                    mess.Text = "Thanks For Your Time ";
                    Response.Redirect("Survey_Project4\\User_Q.aspx.cs?username=" + User_input.Text + "&empID=" + Id_input.Text);
                }
            }
        }
    }
}