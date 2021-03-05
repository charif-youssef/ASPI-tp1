using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class monweeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try {
                string nom = TextBox1.Text;
                int i = int.Parse(TextBox2.Text);
                int h = int.Parse(TextBox3.Text);

                Label4.Text = nom.Substring(i, h);
            }catch(Exception )
            {
                Label4.Text = "error";
            }
            
        }
    }
}