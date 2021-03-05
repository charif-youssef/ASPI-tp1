using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebApplication1
{
    public partial class Webcolor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "image/color.png";
            if (this.IsPostBack==false)
            {
                Label1.Visible = false;
                Label2.Visible = false;
                RadioButtonList1.Visible = false;
                RadioButtonList2.Visible = false;

            }
            
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
            Label1.Visible = true;
            Label2.Visible = true;
            if (e.X < 50)
            {
                if (e.Y < 50)
                {
                    Label1.Text = "Couleur de la zone : Rouge";
                    Label1.BackColor = Color.Red;
                }
                else
                {
                    Label1.Text = "Couleur de la zone : Vert";
                    Label1.BackColor = Color.Green;
                }
            }
            else
            {
                if (e.Y < 50)
                {
                   
                    Label1.Text = "Couleur de la zone : Blue";
                    Label1.BackColor = Color.Blue;
                }
                else
                {
                    Label1.Text = "Couleur de la zone : Gris";
                    Label1.BackColor = Color.Gray;
                }
            }
            Label2.Text = "Les cordonnées X= " + e.X + ", Y=" + e.Y;



        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked==true)
            {
                RadioButtonList1.Visible = true;
            }
            else
            {
                RadioButtonList1.Visible = false;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked==true)
            {
                RadioButtonList2.Visible =true;
            }
            else
            {
                RadioButtonList2.Visible = false;
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex==0)
            {
                Panel1.BackColor = Color.Red;
            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                Panel1.BackColor = Color.GreenYellow;
            }
            if (RadioButtonList1.SelectedIndex == 2)
            {
                Panel1.BackColor = Color.Gray;
            }
            if (RadioButtonList1.SelectedIndex == 3)
            {
                Panel1.BackColor = Color.Blue;
            }

        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedIndex==0)
            {
               Panel1.Width= Unit.Pixel(100);
                Panel1.Height= Unit.Pixel(100);

            }
            if (RadioButtonList2.SelectedIndex==1)
            {
                Panel1.Width = Unit.Pixel(50);
                Panel1.Height = Unit.Pixel(50);
            }
        }
    }
}
