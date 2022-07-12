using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Collections.Generic;

namespace WebSite.App_Code
{
    public class MyUser : DbAction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        static IMongoCollection<MyUser> collection = MongoDataBase.GetCollectionMyUser();

        public MyUser()
        {

        }
        public MyUser(string id)
        {
            this.Id = id;
            Init();
        }
        public MyUser(string fName, string lName, string email, string pass)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Email = email;
            this.Pass = pass;
        }
        public int Init()
        {
            var result = collection.Find(s => s.Id == this.Id).ToList();
            if (result.Count > 0)
            {
                MyUser u = result[0];
                this.FirstName = u.FirstName;
                this.LastName = u.LastName;
                this.Email = u.Email;
                this.Pass = u.Pass;
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int AddNew()
        {
            var result = collection.Find(s => s.Email == this.Email).ToList();
            if (result.Count > 0)
            {
                return -1;
            }
            else
            {
                collection.InsertOne(this);
                return 1;
            }
        }

        public int Update()
        {
            var result = collection.ReplaceOne(s => s.Id == this.Id, this);
            if(result.ModifiedCount == 1)
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
            var result = collection.DeleteOne(s => s.Id == this.Id);
            if(result.DeletedCount == 1) 
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static MyUser Login(string email, string pass)
        {
            var result = collection.Find(s => s.Pass == pass && s.Email == email).ToList();
            if(result.Count > 0)
            {
                return result[0];
            }
            return null;
        }
        public static List<MyUser> GetListUser()
        {
            var result = collection.Find(_ => true).ToList();
            return result;
        }




    }
}