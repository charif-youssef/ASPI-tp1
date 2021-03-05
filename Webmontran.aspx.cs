using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Webmontran : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack==false)
            {
                ListItem x = new ListItem("Euros", "0,7436");
                ListItem y = new ListItem("Yen Japonais ","81,0");
                ListItem z = new ListItem("Dollars Canadien", "0,9996");
                DropDownList1.Items.Add(x);
                DropDownList1.Items.Add(y);
                DropDownList1.Items.Add(z);

            }
            Image1.Visible =false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montantUs = Decimal.Parse(TextBox1.Text);
                ListItem element = DropDownList1.Items[DropDownList1.SelectedIndex];

                decimal nouveauMontant = montantUs * Decimal.Parse(element.Value);
                Label3.Text = montantUs.ToString() + " DollarsU.S = ";

                Label3.Text += nouveauMontant.ToString() + " " + element.Text;
               TextBox1.BackColor = Color.White;
                //Label3.Text = nouveauMontant.ToString() + " " + element.Text;
            }
            catch (Exception ex)
            {
                Label3.Text = "error";
                TextBox1.BackColor = Color.Red;
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex==0)
            {
                Image1.ImageUrl = "image/page1.png";
                Image1.Visible = true;
            }

            if (DropDownList1.SelectedIndex == 1)
            {
                Image1.ImageUrl = "image/PAGE2.png";
                Image1.Visible = true;
            }

            if (DropDownList1.SelectedIndex == 2)
            {
                Image1.ImageUrl = "image/page3.png";
                Image1.Visible = true;
            }
        }
    }
}