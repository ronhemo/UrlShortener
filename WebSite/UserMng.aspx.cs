using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class UserMng : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (Session["myUser"] != null)
            {
                userRepeater.DataSource = ws.GetListUser();
                userRepeater.DataBind();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}