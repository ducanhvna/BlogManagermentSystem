using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModel
{
    public class BlogManagermentModel
    {
        // Standard URI format: mongodb://[dbuser:dbpassword@]host:port/dbname
        String uri = "mongodb://localhost:27017";
        private MongoClient client = null;
        private IMongoDatabase db = null;
        private BsonDocument[] seedData;
        private IMongoCollection<Category> CategoryCollection = null;
        private IMongoCollection<BlogGroup> GroupCollection = null;
        private IMongoCollection<BlogPost> PostCollection = null;

        private string DbName;
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inUri"></param>
        /// <param name="dbname"></param>
        public BlogManagermentModel(string inUri, string dbname)
        {
            DbName = dbname;
            client = new MongoClient(uri);
            db = client.GetDatabase(DbName);
            CategoryCollection = db.GetCollection<Category>("categories");
            GroupCollection = db.GetCollection<BlogGroup>("groups");
            PostCollection = db.GetCollection<BlogPost>("blogposts");
        }
        #endregion
        #region Category Area
        public ObservableCollection<Category> ListCategories { 
            get
            {
                try
                {
                    ObservableCollection<Category> result = new ObservableCollection<Category>();
                    foreach (var item in CategoryCollection.AsQueryable())
                    {
                        result.Add(item);
                    }
                    return result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public short CreateNewCategory(ref short errorCode)
        {
            Category newObject = new Category();
            InsertOne(newObject);
            return newObject._id.Pid;
        }

        private void InsertOne(Category newObject)
        {
            if (newObject == null)
            {
                return;
            }
            if (CategoryCollection == null)
            {
                return;
            }

            // Use InsertOneAsync for single BsonDocument insertion.
            //classCollection.InsertMany(school.ListClass);

            CategoryCollection.InsertOne(newObject);
        }
        #endregion


    }
}
