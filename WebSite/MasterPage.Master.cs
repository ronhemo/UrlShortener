using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if(Session["myUser"] != null)
            {
                adminPage.Visible = true;
                loginPage.Visible = false;
            }
            else
            {
                adminPage.Visible = false;
                loginPage.Visible = true;
            }
        }
    }
}