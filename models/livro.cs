using MongoDB.Bson.Serialization.Attributes;

namespace Livroteca.models
{
    public class Books
    {
        [BsonId(IdGenerator = typeof(MongoDB.Bson.Serialization.IdGenerators.StringObjectIdGenerator))]
        public string ISBN_ID { get; set; }
        public string ISBN{ get; set; }
        public string títle { get; set; }
        public string subtitle { get; set; }
        public string description { get; set; }
        public string publication_date{ get; set; }
        public int number_of_pages { get; set; }
    }
}
