using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite.App_Code;

namespace WebSite
{
    public partial class UserView : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (Session["myUser"] != null)
            {
                string userId = "";
                userId = Request.QueryString["userid"];
                if (userId != null)
                {
                    MyUser u = ws.GetUser(userId);
                    uId.Text = u.Id;
                    fName.Text = u.FirstName;
                    lName.Text = u.LastName;
                    uEmail.Text = u.Email;
                    password.Text = u.Pass;
                }
                else
                {
                    tableView.Visible = false;
                    errorMsg.Text = "couldnt find user";
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }
    }
}