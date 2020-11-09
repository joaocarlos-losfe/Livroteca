using MongoDB.Driver;
using MongoDB.Bson;
using Livroteca.models;
using System.Collections.Generic;

namespace Livroteca.services
{
    public class MongodbAcess
    {
        MongoClient baselink = new MongoClient("mongodb+srv://joaocarlos:joaocarlos18@cluster0.foaek.mongodb.net/livroteca?retryWrites=true&w=majority");
        public bool getUser(string cpf)
        {
            var database = baselink.GetDatabase("usuarios");
            IMongoCollection<User> user = database.GetCollection<User>("Dados");

            var seach_user = user.Find(x => x.CPF_ID == cpf).ToList();

            foreach (var seach in seach_user)
            {
                if (seach.CPF_ID == cpf)
                {
                    return true;
                }
            }
            return false;
        }

        public bool getUser(string cpf, string password)
        {
            var database = baselink.GetDatabase("usuarios");
            IMongoCollection<User> user = database.GetCollection<User>("Dados");

            var seach_user = user.Find(x => x.CPF_ID == cpf).ToList();

            foreach (var seach in seach_user)
            {
                if (seach.CPF_ID == cpf && seach.password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public void insertUser(User user)
        {
            var database = baselink.GetDatabase("usuarios");
            IMongoCollection<User> user_add = database.GetCollection<User>("Dados");
            user_add.InsertOneAsync(user);
        }

        public User getAllInfoUser(string cpf)
        {
            
            User user = new User();
            var database = baselink.GetDatabase("usuarios");
            IMongoCollection<User> user_data = database.GetCollection<User>("Dados");

            var seach_user = user_data.Find(x => x.CPF_ID == cpf).ToList();

            foreach (var user_info in seach_user)
            {
                user.books.AddRange(user_info.books);
                user.CPF_ID = user_info.CPF_ID;
                user.CPF = user_info.CPF;
                user.full_name = user_info.full_name;
                user.email = user_info.email;
                user.number_of_book = user_info.number_of_book;
                user.password = user.password;   
            }

            return user;
        }
       
    }
}
