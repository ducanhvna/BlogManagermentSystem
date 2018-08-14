using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.ObjectModel;
namespace BlogModel
{
    public class BlogPost
    {
        [BsonId]
        public ObjectId _id { get; set; }

        public string Name { get; set; }
        public PostTitle Title { get; set; } = null;
        public PostFooter Footer { get; set; } = null;
        public ObservableCollection< PostPart> ContentParts { get; set; }
    }
}