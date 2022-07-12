using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite.App_Code;

namespace WebSite
{
    public partial class UserUpdate : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (Session["myUser"] != null)
            {
                if (!IsPostBack)
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
                        userIdDiv.Visible = true;
                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                    }
                    else
                    {
                        userIdDiv.Visible = false;
                        btnAdd.Visible = true;
                    }
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            MyUser u = new MyUser(fName.Text, lName.Text, uEmail.Text, password.Text);
            if (ws.AddUser(u) == 1)
            {
                Response.Redirect("UserMng.aspx");
            }
            else
            {
                //err
                errorMsg.Text = "couldnt add user";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MyUser u = new MyUser { Id=uId.Text, FirstName= fName.Text,LastName= lName.Text,Email = uEmail.Text,Pass= password.Text };
            if(ws.UpdateUser(u) == 1)
            {
                Response.Redirect("UserMng.aspx");
            }
            else
            {
                //err
                errorMsg.Text = "couldnt update user";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MyUser u = ws.GetUser(uId.Text);
            if(ws.DeleteUser(u) == 1)
            {
                Response.Redirect("userMng.aspx");
            }
            else
            {
                //err
                errorMsg.Text = "couldnt Delete user";
            }
        }
    }
}