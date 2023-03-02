//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.IO;
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
    public partial class Result_A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string adminN = Request.QueryString["adminN"];
            Label1.Text= adminN;
            string[] readsum = File.ReadAllLines(@"C:\Users\dell\project4\Survey_Project4\Survey_Project4\Login.txt");

            if (readsum.Length == 1)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];//name
                row12.Text = usersum1[1];//ID
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2]+".txt";
                HyperLink3.NavigateUrl = p;
            }

            else if (readsum.Length == 2)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;



                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;
            }
            else if (readsum.Length == 3)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;

                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;

                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;
            }
            else if (readsum.Length == 4)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;


                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;


                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;


                string[] usersum4 = readsum[3].Split(' ');
                row41.Text = usersum4[0];
                row42.Text = usersum4[1];
                HyperLink link4 = new HyperLink();
                HyperLink6.Text = usersum4[0];
                string p4 = usersum4[0] + usersum4[2] + ".txt";
                HyperLink6.NavigateUrl = p4;
            }
            else if (readsum.Length == 5)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;


                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;


                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;


                string[] usersum4 = readsum[3].Split(' ');
                row41.Text = usersum4[0];
                row42.Text = usersum4[1];
                HyperLink link4 = new HyperLink();
                HyperLink6.Text = usersum4[0];
                string p4 = usersum4[0] + usersum4[2] + ".txt";
                HyperLink6.NavigateUrl = p4;

                string[] usersum5 = readsum[4].Split(' ');
                row51.Text = usersum5[0];
                row52.Text = usersum5[1];
                HyperLink link5 = new HyperLink();
                HyperLink7.Text = usersum5[0];
                string p5 = usersum5[0] + usersum5[2] + ".txt";
                HyperLink7.NavigateUrl = p5;
            }
            else if (readsum.Length == 6)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;


                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;


                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;


                string[] usersum4 = readsum[3].Split(' ');
                row41.Text = usersum4[0];
                row42.Text = usersum4[1];
                HyperLink link4 = new HyperLink();
                HyperLink6.Text = usersum4[0];
                string p4 = usersum4[0] + usersum4[2] + ".txt";
                HyperLink6.NavigateUrl = p4;

                string[] usersum5 = readsum[4].Split(' ');
                row51.Text = usersum5[0];
                row52.Text = usersum5[1];
                HyperLink link5 = new HyperLink();
                HyperLink7.Text = usersum5[0];
                string p5 = usersum5[0] + usersum5[2] + ".txt";
                HyperLink7.NavigateUrl = p5;

                string[] usersum6 = readsum[5].Split(' ');
                row61.Text = usersum6[0];
                row62.Text = usersum6[1];
                HyperLink link6 = new HyperLink();
                HyperLink8.Text = usersum6[0];
                string p6 = usersum6[0] + usersum6[2] + ".txt";
                HyperLink8.NavigateUrl = p6;

              
            }

            else if (readsum.Length == 7)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;


                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;


                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;


                string[] usersum4 = readsum[3].Split(' ');
                row41.Text = usersum4[0];
                row42.Text = usersum4[1];
                HyperLink link4 = new HyperLink();
                HyperLink6.Text = usersum4[0];
                string p4 = usersum4[0] + usersum4[2] + ".txt";
                HyperLink6.NavigateUrl = p4;

                string[] usersum5 = readsum[4].Split(' ');
                row51.Text = usersum5[0];
                row52.Text = usersum5[1];
                HyperLink link5 = new HyperLink();
                HyperLink7.Text = usersum5[0];
                string p5 = usersum5[0] + usersum5[2] + ".txt";
                HyperLink7.NavigateUrl = p5;

                string[] usersum6 = readsum[5].Split(' ');
                row61.Text = usersum6[0];
                row62.Text = usersum6[1];
                HyperLink link6 = new HyperLink();
                HyperLink8.Text = usersum6[0];
                string p6 = usersum6[0] + usersum6[2] + ".txt";
                HyperLink8.NavigateUrl = p6;


                string[] usersum7 = readsum[6].Split(' ');
                row71.Text = usersum7[0];
                row72.Text = usersum7[1];
                HyperLink link7 = new HyperLink();
                HyperLink9.Text = usersum7[0];
                string p7 = usersum7[0] + usersum7[2] + ".txt";
                HyperLink8.NavigateUrl = p7;

                
            }
            else if (readsum.Length ==8)
            {
                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;


                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;


                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;


                string[] usersum4 = readsum[3].Split(' ');
                row41.Text = usersum4[0];
                row42.Text = usersum4[1];
                HyperLink link4 = new HyperLink();
                HyperLink6.Text = usersum4[0];
                string p4 = usersum4[0] + usersum4[2] + ".txt";
                HyperLink6.NavigateUrl = p4;

                string[] usersum5 = readsum[4].Split(' ');
                row51.Text = usersum5[0];
                row52.Text = usersum5[1];
                HyperLink link5 = new HyperLink();
                HyperLink7.Text = usersum5[0];
                string p5 = usersum5[0] + usersum5[2] + ".txt";
                HyperLink7.NavigateUrl = p5;

                string[] usersum6 = readsum[5].Split(' ');
                row61.Text = usersum6[0];
                row62.Text = usersum6[1];
                HyperLink link6 = new HyperLink();
                HyperLink8.Text = usersum6[0];
                string p6 = usersum6[0] + usersum6[2] + ".txt";
                HyperLink8.NavigateUrl = p6;


                string[] usersum7 = readsum[6].Split(' ');
                row71.Text = usersum7[0];
                row72.Text = usersum7[1];
                HyperLink link7 = new HyperLink();
                HyperLink9.Text = usersum7[0];
                string p7 = usersum7[0] + usersum7[2] + ".txt";
                HyperLink8.NavigateUrl = p7;

                string[] usersum8 = readsum[7].Split(' ');
                row81.Text = usersum8[0];
                row82.Text = usersum8[1];
                HyperLink link8 = new HyperLink();
                HyperLink10.Text = usersum8[0];
                string p8 = usersum8[0] + usersum8[2] + ".txt";
                HyperLink8.NavigateUrl = p8;

                
            }
            else if (readsum.Length == 9)
            {

                string[] usersum1 = readsum[0].Split(' ');
                row11.Text = usersum1[0];
                row12.Text = usersum1[1];
                HyperLink link1 = new HyperLink();
                HyperLink3.Text = usersum1[0];
                string p = usersum1[0] + usersum1[2] + ".txt";
                HyperLink3.NavigateUrl = p;


                string[] usersum2 = readsum[1].Split(' ');
                row21.Text = usersum2[0];
                row22.Text = usersum2[1];
                HyperLink link2 = new HyperLink();
                HyperLink4.Text = usersum2[0];
                string p2 = usersum2[0] + usersum2[2] + ".txt";
                HyperLink4.NavigateUrl = p2;


                string[] usersum3 = readsum[2].Split(' ');
                row31.Text = usersum3[0];
                row32.Text = usersum3[1];
                HyperLink link3 = new HyperLink();
                HyperLink5.Text = usersum3[0];
                string p3 = usersum3[0] + usersum3[2] + ".txt";
                HyperLink5.NavigateUrl = p3;


                string[] usersum4 = readsum[3].Split(' ');
                row41.Text = usersum4[0];
                row42.Text = usersum4[1];
                HyperLink link4 = new HyperLink();
                HyperLink6.Text = usersum4[0];
                string p4 = usersum4[0] + usersum4[2] + ".txt";
                HyperLink6.NavigateUrl = p4;

                string[] usersum5 = readsum[4].Split(' ');
                row51.Text = usersum5[0];
                row52.Text = usersum5[1];
                HyperLink link5 = new HyperLink();
                HyperLink7.Text = usersum5[0];
                string p5 = usersum5[0] + usersum5[2] + ".txt";
                HyperLink7.NavigateUrl = p5;

                string[] usersum6 = readsum[5].Split(' ');
                row61.Text = usersum6[0];
                row62.Text = usersum6[1];
                HyperLink link6 = new HyperLink();
                HyperLink8.Text = usersum6[0];
                string p6 = usersum6[0] + usersum6[2] + ".txt";
                HyperLink8.NavigateUrl = p6;


                string[] usersum7 = readsum[6].Split(' ');
                row71.Text = usersum7[0];
                row72.Text = usersum7[1];
                HyperLink link7 = new HyperLink();
                HyperLink9.Text = usersum7[0];
                string p7 = usersum7[0] + usersum7[2] + ".txt";
                HyperLink8.NavigateUrl = p7;

                string[] usersum8 = readsum[7].Split(' ');
                row81.Text = usersum8[0];
                row82.Text = usersum8[1];
                HyperLink link8 = new HyperLink();
                HyperLink10.Text = usersum8[0];
                string p8 = usersum8[0] + usersum8[2] + ".txt";
                HyperLink8.NavigateUrl = p8;


                string[] usersum9 = readsum[8].Split(' ');
                row91.Text = usersum9[0];
                row92.Text = usersum9[1];
                HyperLink link9 = new HyperLink();
                HyperLink11.Text = usersum9[0];
                string p9 = usersum9[0] + usersum9[2] + ".txt";
                HyperLink11.NavigateUrl = p9;

                string[] usersum10 = readsum[9].Split(' ');
                row101.Text = usersum10[0];
                row102.Text = usersum10[1];
                HyperLink link10 = new HyperLink();
                HyperLink12.Text = usersum10[0];
                string p10 = usersum10[0] + usersum10[2] + ".txt";
                HyperLink12.NavigateUrl = p10;
            }

            //row13.Text= usersum1[0]+".txt";

            //string[] usersum2 = readsum[1].Split(' ');
            //row21.Text = usersum2[0];
            //row22.Text = usersum2[1];

            //string[] usersum3 = readsum[2].Split(' ');
            //row31.Text = usersum3[0];
            //row32.Text = usersum3[1];

            //string[] usersum4 = readsum[3].Split(' ');
            //row41.Text = usersum4[0];
            //row42.Text = usersum4[1];

            //string[] usersum5 = readsum[4].Split(' ');
            //row51.Text = usersum5[0];
            //row52.Text = usersum5[1];

            //string[] usersum6 = readsum[5].Split(' ');
            //row61.Text = usersum6[0];
            //row62.Text = usersum6[1];

            //string[] usersum7 = readsum[6].Split(' ');
            //row71.Text = usersum7[0];
            //row72.Text = usersum7[1];

            //string[] usersum8 = readsum[7].Split(' ');
            //row81.Text = usersum8[0];
            //row82.Text = usersum8[1];

            //string[] usersum9 = readsum[8].Split(' ');
            //row91.Text = usersum9[0];
            //row92.Text = usersum9[1];

            //string[] usersum10 = readsum[9].Split(' ');
            //row101.Text = usersum10[0];
            //row102.Text = usersum10[1];


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}