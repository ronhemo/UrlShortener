using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite.App_Code;

namespace WebSite
{
    public partial class UrlUpdate : System.Web.UI.Page
    {
        WebService ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (Session["myUser"] != null)
            {
                if (!IsPostBack)
                {
                    string strId = "";
                    strId = Request.QueryString["id"];
                    if (strId != null)
                    {
                        MyUrl url = ws.GetUrl(strId);
                        id.Text = url.Id;
                        urlId.Text = url.UrlId;
                        bigUrl.Text = url.BigUrl;
                        smallUrl.Text = url.SmallUrl;
                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                        divHideAdd1.Visible = true;
                        divHideAdd2.Visible = true;
                    }
                    else
                    {
                        btnAdd.Visible = true;
                        divHideAdd1.Visible = false;
                        divHideAdd2.Visible = false;
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
            MyUrl url = new MyUrl { UrlId=urlId.Text, BigUrl=bigUrl.Text };
            if (ws.AddUrl(url) == 1) 
            {
                Response.Redirect("UrlMng.aspx");
            }
            else
            {
                errorMsg.Text = "id of url already exist";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string thisUrl = smallUrl.Text;
            string reversedThisUrl = "";
            for (int j = 0; j < thisUrl.Length; j++)
            {
                reversedThisUrl += thisUrl[thisUrl.Length - 1 - j];
            }
            int i = reversedThisUrl.IndexOf('/');
            thisUrl = thisUrl.Remove(thisUrl.Length - i, (thisUrl.Length - 1) - (thisUrl.Length - i - 1));
            MyUrl url = new MyUrl { Id=id.Text, UrlId = urlId.Text, BigUrl = bigUrl.Text, SmallUrl=thisUrl + urlId.Text };
            if(ws.UpdateUrl(url) == 1)
            {
                Response.Redirect("UrlMng.aspx");
            }
            else
            {
                errorMsg.Text = "url end is already used";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MyUrl url = ws.GetUrl(id.Text);
            if(ws.DeleteUrl(url) == 1)
            {
                Response.Redirect("UrlMng.aspx");
            }
            else
            {
                errorMsg.Text = "couldnt Delete url";
            }
        }
    }
}