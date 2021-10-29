using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            Response.Write("Name of emp with ID = 2" + "::::::" +  company[2]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Employee Names changed ");
            company[2] = "2nd employee name changed ";
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Name of emp with ID = 2" + "::::::" + company[2]);

        }
    }
}