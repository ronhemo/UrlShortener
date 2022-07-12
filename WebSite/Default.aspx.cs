using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite
{
    public partial class Default : System.Web.UI.Page
    {
        WebService ws;

        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService();
            if (!IsPostBack)
            {
                string url = HttpContext.Current.Request.Url.AbsoluteUri;
                try
                {
                    if (ws.EnlargeUrl(url) == "couldnt find url")
                    {

                    }
                    else
                    {
                        url = ws.EnlargeUrl(url);
                        Response.Redirect(url);
                    }
                }
                catch
                {

                }

            }



        }

        protected void shrinkUrl_Click(object sender, EventArgs e)
        {
            if(RemoteFileExists(bigUrl.Text))
            {
                shrinkedUrl.Text = ws.ShrinkUrl(bigUrl.Text);
            }
            else
            {
                shrinkedUrl.Text = "url is not valid";
            }
        }

        protected void enlargeUrl_Click(object sender, EventArgs e)
        {
            enlargedUrl.Text = ws.EnlargeUrl(smallUrl.Text);
        }
        private bool RemoteFileExists(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method GET.
                request.Method = "GET";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }
    }
}