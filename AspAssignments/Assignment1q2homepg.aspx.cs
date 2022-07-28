using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssignments
{
    public partial class Assignment1q2homepg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
               
                Label3.Text = ("welcome " + Request.Cookies["d1"].Value.ToString());
                Label4.Text = Request.Cookies["d2"].Value.ToString();
            }
            else
            {
                Response.Redirect("Assignment1q2loginpg.aspx");
            }
        }

        protected void Btnsubmit2_Click1(object sender, EventArgs e)
        {
            Label3.Text = ("welcome " + Request.Cookies["d1"].Value.ToString());
            Label4.Text = Request.Cookies["d2"].Value.ToString();

        }

        protected void Btnlast_Click(object sender, EventArgs e)
        {
            Response.Redirect("Assignment1q2loginpg.aspx");
        }
    }

   

   
}