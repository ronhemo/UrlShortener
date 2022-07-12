using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class UrlMng : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (Session["myUser"] != null)
            {
                ws = new WebService();
                urlRepeater.DataSource = ws.GetListUrl();
                urlRepeater.DataBind();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }
    }
}