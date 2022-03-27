using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<h1>" + Literal1.Text + "</h1>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<h1>" + TextBox1.Text + "</h1>";
        }
    }
}