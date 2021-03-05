using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class WEB2aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
          //changecolor();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //    if (RadioButton1.Checked)
            //    {
            //        Panel1.BackColor = Color.Red;
            //    }
            //    if (RadioButton2.Checked)
            //    {
            //        Panel1.BackColor = Color.Blue;
            //    }
            //    if (RadioButton3.Checked)
            //    {
            //        Panel1.BackColor = Color.Green;
            //    }
            changecolor();
        }
        private void changecolor()
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Panel1.BackColor = Color.Red;
            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                Panel1.BackColor = Color.Blue;
            }
            if (RadioButtonList1.SelectedIndex == 2)
            {
                Panel1.BackColor = Color.Green;
            }
        }
    }
}