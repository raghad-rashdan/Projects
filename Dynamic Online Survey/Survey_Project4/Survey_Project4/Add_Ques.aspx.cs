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
            su1.Text =string.Empty;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] questions = new string[10];

            {
                questions[0] = TextBox1.Text;


                questions[0] = TextBox1.Text; questions[1] = TextBox2.Text; questions[2] = TextBox3.Text;
                questions[3] = TextBox4.Text; questions[4] = TextBox5.Text; questions[5] = TextBox6.Text;
                questions[6] = TextBox7.Text; questions[7] = TextBox8.Text; questions[8] = TextBox9.Text;
                questions[9] = TextBox10.Text;

                string path = "C:\\Users\\Orange\\source\\repos\\Survey_Project4\\Survey_Project4\\Lubna.txt";
                File.WriteAllLines(path, questions);
                su1.Text ="kjhg";
                TextBox1.Text=string.Empty;

            }


        }
    }
}