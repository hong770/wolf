using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
//Lable1確認是否沒選運算
//Lable2紀錄數字
//Lable3記錄過程
//lable儲存輸入數字
//lable0儲存上一個輸入數字OR運算結果
//lable1確認數字重新輸入
//lable2儲存運算
//lable3是否使用過等於
//lable4是否使用過運算
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public float num;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1) {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1 )
            {
                lable.Text = "1";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "1";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "2";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "2";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "3";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "3";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "4";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "4";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "5";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "5";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "6";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "6";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "7";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "7";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "8";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "8";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "9";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "9";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            if (int.Parse(lable1.Text) == 1)
            {
                lable.Text = "0";
                lable1.Text = "0";
            }
            else
            {
                lable.Text = lable.Text + "0";
            }
            TextBox1.Text = lable.Text;
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable5.Text) == 0)
            {
                lable0.Text = lable.Text;
                lable.Text = ""; 
                Label3.Text = Label3.Text + lable0.Text + "+";
                lable5.Text = "1";
            }
            else
            {
                if (int.Parse(lable2.Text) == 1)
                {
                    Label3.Text = Label3.Text + lable.Text + "+";
                    num = float.Parse(lable0.Text) + float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 2)
                {
                    Label3.Text = Label3.Text + lable.Text + "-";
                    num = float.Parse(lable0.Text) - float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 3)
                {
                    Label3.Text = Label3.Text + lable.Text + "+";
                    num = float.Parse(lable0.Text) * float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 4)
                {
                    Label3.Text = Label3.Text + lable.Text + " +";
                    num = float.Parse(lable0.Text) / float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
            }
            TextBox1.Text = lable0.Text;
            
            lable2.Text = "1";
            lable1.Text = "1";
            lable3.Text = "0";
        }


        protected void Button12_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable5.Text) == 0)
            {
                lable0.Text = TextBox1.Text;
                lable.Text = "";
                Label3.Text = Label3.Text + lable0.Text + "-";
                lable5.Text = "1";
            }
            else
            {
                if (int.Parse(lable2.Text) == 1)
                {
                    Label3.Text = Label3.Text + lable.Text + "-";
                    num = float.Parse(lable0.Text) + float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 2)
                {
                    Label3.Text = Label3.Text + lable.Text + "-";
                    num = float.Parse(lable0.Text) - float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 3)
                {
                    Label3.Text = Label3.Text + lable.Text + "-";
                    num = float.Parse(lable0.Text) * float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 4)
                {
                    Label3.Text = Label3.Text + lable.Text + "-";
                    num = float.Parse(lable0.Text) / float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
            }
            TextBox1.Text = lable0.Text;

            lable2.Text = "2";
            lable1.Text = "1";
            lable3.Text = "0";
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable5.Text) == 0)
            {
                lable0.Text =TextBox1.Text;
                lable.Text = "";
                Label3.Text = Label3.Text + lable0.Text + "*";
                lable5.Text = "1";
            }
            else
            {
                if (int.Parse(lable2.Text) == 1)
                {
                    Label3.Text = Label3.Text + lable.Text + "*";
                    num = float.Parse(lable0.Text) + float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 2)
                {
                    Label3.Text = Label3.Text + lable.Text + "*";
                    num = float.Parse(lable0.Text) - float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 3)
                {
                    Label3.Text = Label3.Text + lable.Text + "*";
                    num = float.Parse(lable0.Text) * float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 4)
                {
                    Label3.Text = Label3.Text + lable.Text + "*";
                    num = float.Parse(lable0.Text) / float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
            }
            TextBox1.Text = lable0.Text;

            lable2.Text = "3";
            lable1.Text = "1";
            lable3.Text = "0";
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable5.Text) == 0)
            {
                lable0.Text = TextBox1.Text;
                lable.Text = "";
                Label3.Text = Label3.Text + lable0.Text + " /";
                lable5.Text = "1";
            }
            else
            {
                if (int.Parse(lable2.Text) == 1)
                {
                    Label3.Text = Label3.Text + lable.Text + "/";
                    num = float.Parse(lable0.Text) + float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 2)
                {
                    Label3.Text = Label3.Text + lable.Text + "/";
                    num = float.Parse(lable0.Text) - float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 3)
                {
                    Label3.Text = Label3.Text + lable.Text + "/";
                    num = float.Parse(lable0.Text) * float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
                if (int.Parse(lable2.Text) == 4)
                {
                    Label3.Text = Label3.Text + lable.Text + " /";
                    num = float.Parse(lable0.Text) / float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                }
            }
            TextBox1.Text = lable0.Text;

            lable2.Text = "4";
            lable1.Text = "1";
            lable3.Text = "0";
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            if (int.Parse(lable2.Text) == 1)
            {
                if (int.Parse(lable3.Text) == 0)
                {
                    Label3.Text = Label3.Text + lable.Text + "=";
                    num = float.Parse(lable.Text) + float.Parse(lable0.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text;
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                    lable3.Text = "1";
                }
                else {
                    Label3.Text = Label3.Text + "+" + lable.Text + "=";
                    num = float.Parse(lable.Text) + float.Parse(lable0.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text + "      ";
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                }
            }
            if (int.Parse(lable2.Text) == 2)
            {
                if (int.Parse(lable3.Text) == 0)
                {
                    Label3.Text = Label3.Text + lable.Text + "=";
                    num = float.Parse(lable0.Text) - float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text;
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                    lable3.Text = "1";
                }
                else
                {
                    Label3.Text = Label3.Text + "-" + lable.Text + "="; 
                    num = float.Parse(lable0.Text) - float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text + "      ";
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                }
            }
            if (int.Parse(lable2.Text) == 3)
            {
                if (int.Parse(lable3.Text) == 0)
                {
                    Label3.Text = Label3.Text + lable.Text + "=";
                    num = float.Parse(lable0.Text) * float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text;
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                    lable3.Text = "1";
                }
                else
                {
                    Label3.Text = Label3.Text + "*" + lable.Text + "="; 
                    num = float.Parse(lable0.Text) * float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text + "      ";
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                }
            }
            if (int.Parse(lable2.Text) == 4)
            {
                if (int.Parse(lable3.Text) == 0)
                {
                    Label3.Text = Label3.Text + lable.Text + "=";
                    num =  float.Parse(lable0.Text)/float.Parse(lable.Text) ;
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text;
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                    lable3.Text = "1";
                }
                else
                {
                    Label3.Text = Label3.Text + "/" + lable.Text + "="; 
                    num = float.Parse(lable0.Text) / float.Parse(lable.Text);
                    lable0.Text = num.ToString();
                    Label3.Text = Label3.Text + lable0.Text+"      ";
                    TextBox1.Text = lable0.Text;
                    lable1.Text = "1";
                }
            }
            lable5.Text = "0";

        }
        protected void Button18_Click(object sender, EventArgs e)
        {
            lable.Text = "";
            lable0.Text = "0";
            lable1.Text = "0";
            lable2.Text = "0";
            lable3.Text = "0";
            lable4.Text = "0";
            Label2.Text = "";
            Label3.Text = "";
            TextBox1.Text = "";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Label2.Text;
            lable.Text = Label2.Text;
            if (int.Parse(lable3.Text) == 1)
            {
                Label3.Text = Label3.Text + "<br>";
                lable0.Text = "0";
            }
            lable3.Text = "0";

        }
    }
}


