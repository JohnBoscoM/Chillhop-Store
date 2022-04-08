using Chillhop_Store.Models.Models;
using ChillhopStore.API.Public_API;
using ChillhopStore.Models;
using MongoDB.Driver;
using System;

namespace ChillhopStore.API.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _user;
        public UserRepository(IMongoDBSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("chillhop_store");
            _user = database.GetCollection<User>("Users");
        }

        public bool UserAuthentication(AuthenticationRequest request)
        {
            return (_user.Find(u => u.UserName == request.Username && u.Password == request.Password).FirstOrDefault() != null) ? true : false;                 
        }
    }
}
