using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code
{
    public class MyUrl : DbAction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string UrlId { get; set; }
        public string SmallUrl { get; set; }
        public string BigUrl { get; set; }

        static IMongoCollection<MyUrl> collection = MongoDataBase.GetCollectionMyUrl();
        public MyUrl()
        {

        }
        public MyUrl(string id)
        {
            this.Id = id;
            Init();
        }
        public int Init()
        {
            var result = collection.Find(s => s.Id == this.Id).ToList();
            if(result.Count == 1)
            {
                MyUrl url = result[0];
                this.UrlId = url.UrlId;
                this.SmallUrl = url.SmallUrl;
                this.BigUrl = url.BigUrl;
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int AddNew()
        {
            var list = collection.Find(s => s.UrlId == this.UrlId).ToList();
            if (list.Count != 0)
            {
                return -1;
            }
            else
            {
                string thisUrl = HttpContext.Current.Request.Url.AbsoluteUri;
                string smallUrl = thisUrl + "/" + this.UrlId;
                var url = new MyUrl { UrlId = this.UrlId, SmallUrl = smallUrl, BigUrl = this.BigUrl };
                collection.InsertOne(url);
                return 1;
            }
        }

        public int Update()
        {
            string id = this.UrlId;
            var list = collection.Find(s => s.UrlId == id).ToList();
            if (list.Count != 0)
            {
                return -1;
            }
            var result = collection.ReplaceOne(s => s.Id == this.Id, this);
            if (result.ModifiedCount == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int Delete()
        {
            var result = collection.DeleteOne(s => s.UrlId == this.UrlId);
            if (result.DeletedCount == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static string ShrinkUrl(string bigUrl)
        {
            string thisUrl = HttpContext.Current.Request.Url.AbsoluteUri;
            //random generater
            var guid = Guid.NewGuid();

            string id = guid.ToString().Substring(0, 8);
            var list = collection.Find(s => s.UrlId == id).ToList();
            while (list.Count != 0)
            {
                id = System.Web.Security.Membership.GeneratePassword(11, 0);
            }
            string smallUrl = thisUrl + "/" + id;
            var url = new MyUrl { UrlId = id, SmallUrl = smallUrl, BigUrl = bigUrl};
            collection.InsertOne(url);
            return smallUrl;

        }
        public static string EnlargeUrl(string smallUrl)
        {
            var result = collection.Find(s => s.SmallUrl == smallUrl).ToList();
            if(result.Count > 0)
            {
                return result[0].BigUrl;
            }
            else
            {
                return "couldnt find url";
            }
        }
        public static List<MyUrl> GetListUrl()
        {
            var result = collection.Find(_ => true).ToList();
            return result;
        }

    }
}