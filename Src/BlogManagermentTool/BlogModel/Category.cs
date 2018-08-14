using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlogModel
{
    public class Category
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public string Name { get; set; }

        public ObservableCollection<ObjectId> Groups { get; set; }

        [BsonIgnore]
        public ObservableCollection<BlogGroup> ListGroupObject { get; set; }
    }
}