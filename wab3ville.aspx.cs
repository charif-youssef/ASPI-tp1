using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class wab3ville : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack==false)
            {
                ListItem s = new ListItem("selection", "0");
                ListItem y = new ListItem("beni mella", "1");
                ListItem x = new ListItem("casa", "2");
                DropDownList1.Items.Add(s);
                DropDownList1.Items.Add(y);
                DropDownList1.Items.Add(x);
            }
            else
            {
                
            }
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ville = DropDownList1.Items[DropDownList1.SelectedIndex].Text;
            if (DropDownList1.SelectedIndex==0)
            {
                affiche.Text = "choisie un ville ";
            }
            else
            {
                affiche.Text = ville;
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {

                affiche.Text = "la ville est " + DropDownList1.Items[DropDownList1.SelectedIndex].Text + " la ville index  " + DropDownList1.Items[DropDownList1.SelectedIndex].Value;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}