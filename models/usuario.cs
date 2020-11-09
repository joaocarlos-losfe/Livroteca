using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Livroteca.models
{
    public class User
    {
        [BsonId(IdGenerator = typeof(MongoDB.Bson.Serialization.IdGenerators.StringObjectIdGenerator))]
        public string CPF_ID { get; set; }
        public string CPF { get; set; }
        public string full_name{ get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int number_of_book { get; set; }

        public List<Books> books = new List<Books>();

    }

}
