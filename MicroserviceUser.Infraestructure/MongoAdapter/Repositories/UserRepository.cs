using AutoMapper;
using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using MicroserviceUser.Infraestructure.MongoAdapter.Interfaces;
using MicroserviceUser.Infraestructure.MongoAdapter.MongoEntities;
using MicroserviceUser.UsesCases.Gateway.Repositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MicroserviceUser.Infraestructure.MongoAdapter.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<UserMongo> _collection;
        private readonly IMapper _mapper;
        public UserRepository(IContext context, IMapper mapper)
        {
            _collection = context.Users;
            _mapper = mapper;
        }

        public async Task<string> CreateUser(CreateUser user)
        {
            await _collection.InsertOneAsync(_mapper.Map<UserMongo>(user));
            return JsonSerializer.Serialize("User Created");
        }
        public async Task<List<User>> GetUsers()
        {
            var users = await _collection.FindAsync(Builders<UserMongo>.Filter.Empty);
            var userList = users.ToEnumerable().Select(x => _mapper.Map<User>(x)).ToList();
            if (userList.Count == 0)
            {
                throw new Exception("No users found.");
            }
            return userList;

        }

        public async Task<User> GetUserById(string id) { 
        
            var user = await _collection.Find(c=> c.id_fire == id).FirstOrDefaultAsync()
            ?? throw new Exception($"There isn't a user with this ID: {id}.");
            var userComplete = _mapper.Map<User>(user);
            return userComplete;
        


        }


    }
}
