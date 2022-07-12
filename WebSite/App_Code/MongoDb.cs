using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code
{
    public interface DbAction
    {
        int Init();
        int AddNew();
        int Update();
        int Delete();
    }
    public class MongoDataBase
    {
        
        static string connectionString = Secret.MONGODBURI;
        static string dataBaseName = "tinyUrl";
        public static IMongoCollection<MyUrl> GetCollectionMyUrl()
        {
            string collectionName = "myurl";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(dataBaseName);
            return db.GetCollection<MyUrl>(collectionName);
        }
        public static IMongoCollection<MyUser> GetCollectionMyUser()
        {
            string collectionName = "myuser";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(dataBaseName);
            return db.GetCollection<MyUser>(collectionName);
        }
    }
}