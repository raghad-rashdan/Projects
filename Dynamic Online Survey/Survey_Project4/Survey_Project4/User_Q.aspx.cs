using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey_Project4
{
    public partial class User_ : System.Web.UI.Page
    {
       private int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Lubna.txt";


            string[] data = File.ReadAllLines(path);



            Label1.Text = data[0];


            Label2.Text = data[1];


            Label3.Text = data[2];

            Label4.Text = data[3];

            Label5.Text = data[4];

            Label6.Text = data[5];

            Label7.Text = data[6];

            Label8.Text = data[7];

            Label9.Text = data[8];

            Label10.Text = data[9];

            //Label1.Text = data[0];
            //Label2.Text = data[1];
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string ans1 = Request.Form["answer1"];
            string ans2 = Request.Form["answer2"];
            string ans3 = Request.Form["answer3"];
            string ans4 = Request.Form["answer4"];
            string ans5 = Request.Form["answer5"];
            string ans6 = Request.Form["answer6"];
            string ans7 = Request.Form["answer7"];
            string ans8 = Request.Form["answer8"];
            string ans9 = Request.Form["answer9"];
            string ans10 = Request.Form["answer10"];

            string allanswers = ans1 + ans2 + ans3 + ans4 + ans3 + ans5 + ans6 + ans7 + ans8 + ans9 + ans10;



            if (ans1 != null && ans2 != null && ans3 != null && ans4 != null && ans5 != null && ans6 != null && ans7 != null && ans8 != null && ans9 != null && ans10 != null)
            {

                //using (StreamWriter writee = File.AppendText("C:\\Users\\dell\\project-4\\project-4\\answer.txt"))
                //{

                //    writee.WriteLine(ans1);
                //    writee.WriteLine(ans2);
                //    writee.WriteLine(ans3);
                //    writee.WriteLine(ans4);
                //    writee.WriteLine(ans5);
                //    writee.WriteLine(ans6);
                //    writee.WriteLine(ans7);
                //    writee.WriteLine(ans8);
                //    writee.WriteLine(ans9);
                //    writee.WriteLine(ans10);




                //}

            }


            else
            {
                Label11.Text = "please enter all answer";
            }


            string username = Request.QueryString["username"];
            string empID = Request.QueryString["empID"];



            string z = username+" "+empID;
            string[] z1 = z.Split(' ');
            string localDate1 = DateTime.Now.Year.ToString();
            string localDate2 = DateTime.Now.Month.ToString();
            string localDate3 = DateTime.Now.Day.ToString();
            string localDate = localDate1 + "-" + localDate2 + "-" + localDate3;
            string path = z1[i] + localDate + ".txt";
            string path2 = localDate + ".txt";

            string p = @"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Login.txt";
            string page = @"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\" + path;
            using (StreamWriter writee = File.AppendText(p))
            {
                writee.WriteLine(z);
                
                //writee.WriteLine(ans1);
                //writee.WriteLine(ans2);
                //writee.WriteLine(ans3);
                //writee.WriteLine(ans4);
                //writee.WriteLine(ans5);
                //writee.WriteLine(ans6);
                //writee.WriteLine(ans7);
                //writee.WriteLine(ans8);
                //writee.WriteLine(ans9);
                //writee.WriteLine(ans10);




            }

            FileStream f1 = null;
            if (!File.Exists(page))
            {
                using (f1 = File.Create(page)) { };

               

            }


            


        }
    }
}