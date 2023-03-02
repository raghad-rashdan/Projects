using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Survey_Project4
{
    public partial class Add_Ques : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string[] readfromfile = File.ReadAllLines(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Lubna.txt");

            //if (readfromfile.Length > 0)
            //{
            //    TextBox1.Text = readfromfile[0];
            //    TextBox2.Text = readfromfile[1];
            //    TextBox3.Text = readfromfile[2];
            //    TextBox4.Text = readfromfile[3];
            //    TextBox5.Text = readfromfile[4];
            //    TextBox6.Text = readfromfile[5];
            //    TextBox7.Text = readfromfile[6];
            //    TextBox8.Text = readfromfile[7];
            //    TextBox9.Text = readfromfile[8];
            //    TextBox10.Text = readfromfile[9];
            //}

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] questions = new string[10];

            {
                //string[] edit = File.ReadAllLines(@"C:\Users\Orange\source\repos\Survey_Project4\Survey_Project4\Lubna.txt");
                //edit[0] = TextBox1.Text;
                //edit[1] = TextBox2.Text;
                //edit[2] = TextBox3.Text;
                //edit[3] = TextBox4.Text;
                //edit[4] = TextBox5.Text;
                //edit[5] = TextBox6.Text;
                //edit[6] = TextBox7.Text;
                //edit[7] = TextBox8.Text;
                //edit[8] = TextBox9.Text;
                //edit[9] = TextBox10.Text;


                questions[0] = TextBox1.Text;


                questions[0] = TextBox1.Text;
                questions[1] = TextBox2.Text;
                questions[2] = TextBox3.Text;
                questions[3] = TextBox4.Text;
                questions[4] = TextBox5.Text;
                questions[5] = TextBox6.Text;
                questions[6] = TextBox7.Text;
                questions[7] = TextBox8.Text;
                questions[8] = TextBox9.Text;
                questions[9] = TextBox10.Text;

                string path = "C:\\Users\\Orange\\source\\repos\\Survey_Project4\\Survey_Project4\\Lubna.txt";
                File.WriteAllLines(path, questions);
                Label11.Text = "The Questions Added";
                //TextBox1.Text = string.Empty;
                //TextBox2.Text = string.Empty;
                //TextBox3.Text = string.Empty;
                //TextBox4.Text = string.Empty;
                //TextBox5.Text = string.Empty;
                //TextBox6.Text = string.Empty;
                //TextBox7.Text = string.Empty;
                //TextBox8.Text = string.Empty;
                //TextBox9.Text = string.Empty;
                //TextBox10.Text = string.Empty;

                //using(StreamWriter sw=)
            }


        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.html");
        }

        protected void about_Click(object sender, EventArgs e)
        {
            Response.Redirect("Result_A.aspx");
        }
    }
}