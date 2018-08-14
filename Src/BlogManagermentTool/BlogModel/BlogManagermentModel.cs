using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
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
                        item.ListGroupObject = GetListGroupByListId(item.Groups);
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

        #region Group Area
        public ObservableCollection<BlogGroup> GetListGroupByListId(ObservableCollection<ObjectId> listid)
        {
            if(listid == null)
            {
                return null;
            }
            ObservableCollection<BlogGroup> result = new ObservableCollection<BlogGroup>();
            foreach (var item in GroupCollection.Find(c => listid.Contains(c._id)).ToList())
            {
                result.Add(item);
            }
            return result;
        }
        public ObservableCollection<BlogGroup> ListBlogGroup
        {
            get
            {
                try
                {
                    ObservableCollection<BlogGroup> result = new ObservableCollection<BlogGroup>();
                    foreach (var item in GroupCollection.AsQueryable())
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

        public short CreateNewBlogGroup(ObjectId categoryId,ref short errorCode)
        {
            BlogGroup newObject = new BlogGroup();
            var category = CategoryCollection.Find(c => c._id == categoryId).FirstOrDefault();
            if (category != null)
            {
                InsertOne(newObject);
                if(category.Groups == null)
                {
                    category.Groups = new ObservableCollection<ObjectId>();
                }
                category.Groups.Add(newObject._id);
                // build the query to update
                var updateDef = Builders<Category>.Update.Set(o => o.Groups, category.Groups);

                // Update
                CategoryCollection.UpdateOne(c => c._id == categoryId, updateDef);
            }

                return newObject._id.Pid;
        }

        private void InsertOne(BlogGroup newObject)
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

            GroupCollection.InsertOne(newObject);
        }

        private void AssignCategory(ObjectId groupId,ObjectId categoryId)
        {

        }
        #endregion

    }
}
