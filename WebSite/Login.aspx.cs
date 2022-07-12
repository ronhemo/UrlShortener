using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite.App_Code;

namespace WebSite
{
    public partial class Login : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            MyUser u = ws.Login(uEmail.Text, password.Text);
            if (u != null)
            {
                Session["myUser"] = u;
                Response.Redirect("Default.aspx");
            }
            else
            {
                //error
                errorMsg.Text = "email or password incorrect";
            }

        }
    }
}