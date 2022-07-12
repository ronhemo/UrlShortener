using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//code
using WebSite.App_Code;

namespace WebSite
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        #region MyUser
        [WebMethod]
        public int AddUser(MyUser u)
        {
            return u.AddNew();
        }
        [WebMethod]
        public MyUser GetUser(string id)
        {
            MyUser u = new MyUser(id);
            return u;
        }
        [WebMethod]
        public int UpdateUser(MyUser u)
        {
            return u.Update();
        }
        [WebMethod]
        public int DeleteUser(MyUser u)
        {
            return u.Delete(); ;
        }
        [WebMethod]
        public MyUser Login(string email, string pass)
        {
            return MyUser.Login(email, pass);
        }
        public List<MyUser> GetListUser()
        {
            return MyUser.GetListUser();
        }
        #endregion
        #region MyUrl
        [WebMethod]
        public int AddUrl(MyUrl u)
        {
            return u.AddNew();
        }
        [WebMethod]
        public int UpdateUrl(MyUrl u)
        {
            return u.Update();
        }
        [WebMethod]
        public int DeleteUrl(MyUrl u)
        {
            return u.Delete();
        }
        [WebMethod]
        public string ShrinkUrl(string bigUrl)
        {
            return MyUrl.ShrinkUrl(bigUrl);
        }
        [WebMethod]
        public string EnlargeUrl(string smallUrl)
        {
            return MyUrl.EnlargeUrl(smallUrl);
        }
        [WebMethod]
        public MyUrl GetUrl(string id)
        {
            
            return new MyUrl(id);
        }
        [WebMethod]
        public List<MyUrl> GetListUrl()
        {
            return MyUrl.GetListUrl();
        }
        #endregion

    }
}
