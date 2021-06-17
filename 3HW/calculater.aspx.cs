using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3HW
{
    public partial class Calculater : System.Web.UI.Page
    {

        [SerializableAttribute]
        public class NumInfo
        {
            public int i_BoundCount;
            public int[] ia_List;
            public int i_Operater;
            public NumInfo()
            {
                ia_List = new int[2];
                i_BoundCount = 1;
                i_Operater = 0;
            }
        }

        public NumInfo o_Num = new NumInfo();
        public int i_Num = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["PreivousInfo"] != null)
            {
                o_Num = (NumInfo)ViewState["PreivousInfo"];
            }

            int i_Ind = (o_Num.i_BoundCount - 1);
            i_Num = (o_Num.ia_List)[i_Ind];

            Response.Write("i_Num:" + i_Num + "<br/>");
            lb_Result.Text = i_Num.ToString();
        }

        protected void bt_Add_Click(object sender, EventArgs e)
        {
            if (o_Num.i_BoundCount > 1)
            {
                cn_calc();
                o_Num.ia_List[1] = 0;
                o_Num.i_BoundCount--;
            }
            o_Num.i_Operater = 1;
            lb_Operate.Text = "+";
            o_Num.ia_List[1] = 0;
            o_Num.i_BoundCount++;
            ViewState["PreivousInfo"] = o_Num;
        }

        protected void bt_Miuns_Click(object sender, EventArgs e)
        {
            if (o_Num.i_BoundCount > 1)
            {
                cn_calc();
                o_Num.ia_List[1] = 0;
                o_Num.i_BoundCount--;
            }
            o_Num.i_Operater = 2;
            lb_Operate.Text = "-";
            o_Num.ia_List[1] = 0;
            o_Num.i_BoundCount++;
            ViewState["PreivousInfo"] = o_Num;
        }

        protected void bt_Product_Click(object sender, EventArgs e)
        {
            if (o_Num.i_BoundCount > 1)
            {
                cn_calc();
                o_Num.ia_List[1] = 0;
                o_Num.i_BoundCount--;
            }
            o_Num.i_Operater = 3;
            lb_Operate.Text = "*";
            o_Num.ia_List[1] = 0;
            o_Num.i_BoundCount++;
            ViewState["PreivousInfo"] = o_Num;
        }

        protected void bt_Divide_Click(object sender, EventArgs e)
        {
            if (o_Num.i_BoundCount > 1)
            {
                cn_calc();
                o_Num.ia_List[1] = 0;
                o_Num.i_BoundCount--;
            }
            o_Num.i_Operater = 4;
            lb_Operate.Text = "/";
            o_Num.ia_List[1] = 0;
            o_Num.i_BoundCount++;
            ViewState["PreivousInfo"] = o_Num;
        }

        protected void bt_Clear_Click(object sender, EventArgs e)
        {
            lb_Operate.Text = "";
            lb_Result.Text = "0";
            ViewState["PreivousInfo"] = o_Num = null;
        }

        protected void bt_Equals_Click(object sender, EventArgs e)
        {
            switch (o_Num.i_Operater)
            {
                case 1:
                    if (o_Num.i_BoundCount > 1)
                    {
                        o_Num.ia_List[0] += o_Num.ia_List[1];
                        o_Num.ia_List[1] = 0;
                        o_Num.i_BoundCount--;
                    }
                    break;
                case 2:
                    if (o_Num.i_BoundCount > 1)
                    {
                        o_Num.ia_List[0] -= o_Num.ia_List[1];
                        o_Num.ia_List[1] = 0;
                        o_Num.i_BoundCount--;
                    }
                    break;
                case 3:
                    if (o_Num.i_BoundCount > 1)
                    {
                        o_Num.ia_List[0] *= o_Num.ia_List[1];
                        o_Num.ia_List[1] = 0;
                        o_Num.i_BoundCount--;
                    }
                    break;
                case 4:
                    if (o_Num.i_BoundCount > 1)
                    {
                        o_Num.ia_List[0] /= o_Num.ia_List[1];
                        o_Num.ia_List[1] = 0;
                        o_Num.i_BoundCount--;
                    }
                    break;
                default:
                    break;
            }
            lb_Operate.Text = "";
            lb_Result.Text = (o_Num.ia_List[0]).ToString();
            ViewState["PreivousInfo"] = o_Num = null;
        }

        protected void bt_0_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) != 0)
            {
                lb_Result.Text += "0";
                i_Num = Convert.ToInt32(lb_Result.Text);
                mt_SetInfo();
            }
        }

        protected void bt_1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "1";
            }
            else
            {
                lb_Result.Text += "1";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "2";
            }
            else
            {
                lb_Result.Text += "2";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "3";
            }
            else
            {
                lb_Result.Text += "3";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "4";
            }
            else
            {
                lb_Result.Text += "4";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "5";
            }
            else
            {
                lb_Result.Text += "5";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "6";
            }
            else
            {
                lb_Result.Text += "6";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "7";
            }
            else
            {
                lb_Result.Text += "7";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        protected void bt_8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "8";
            }
            else
            {
                lb_Result.Text += "8";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }
        protected void bt_9_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_Result.Text) == 0)
            {
                lb_Result.Text = "9";
            }
            else
            {
                lb_Result.Text += "9";
            }
            i_Num = Convert.ToInt32(lb_Result.Text);
            mt_SetInfo();
        }

        private void mt_SetInfo()
        {
            int i_Ind = (o_Num.i_BoundCount - 1);
            o_Num.ia_List[i_Ind] = i_Num;
            Response.Write("Num.ia_List:" + o_Num.ia_List[i_Ind].ToString());
            ViewState["PreivousInfo"] = o_Num;
        }

        private void cn_calc()
        {
            if (o_Num.i_Operater == 1)
            {
                o_Num.ia_List[0] += o_Num.ia_List[1];
            }
            else if (o_Num.i_Operater == 2)
            {
                o_Num.ia_List[0] -= o_Num.ia_List[1];
            }
            else if (o_Num.i_Operater == 3)
            {
                o_Num.ia_List[0] *= o_Num.ia_List[1];
            }
            else
            {
                o_Num.ia_List[0] /= o_Num.ia_List[1];
            }
        }
    }
}