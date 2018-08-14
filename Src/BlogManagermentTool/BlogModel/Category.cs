using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlogModel
{
    public class Category
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public string Name { get; set; }
    }
}