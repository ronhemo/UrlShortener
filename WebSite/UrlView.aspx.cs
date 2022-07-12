using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite.App_Code;

namespace WebSite
{
    public partial class UrlView : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (Session["myUser"] != null)
            {
                string id = "";
                id = Request.QueryString["id"];
                if (id != null)
                {
                    MyUrl url = ws.GetUrl(id);
                    uId.Text = url.Id;
                    urldId.Text = url.UrlId;
                    bigUrl.Text = url.BigUrl;
                    smallUrl.Text = url.SmallUrl;
                }
                else
                {
                    tableView.Visible = false;
                    errorMsg.Text = "couldnt find url";
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}