using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssignments
{
    public partial class assignment1q2loginpg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Cookies["d1"].Value = Txtname.Text;
            Response.Cookies["d2"].Value = Txtpswd.Text;

            Response.Redirect("Assignment1q2homepg.aspx");

        }
    }
}