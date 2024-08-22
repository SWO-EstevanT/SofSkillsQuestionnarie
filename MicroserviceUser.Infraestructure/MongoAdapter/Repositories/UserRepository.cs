using AutoMapper;
using MicroserviceUser.Domain.Commands;
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

    }
}
