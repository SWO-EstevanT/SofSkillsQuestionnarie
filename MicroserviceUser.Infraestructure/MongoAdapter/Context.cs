using MicroserviceUser.Infraestructure.MongoAdapter.Interfaces;
using MicroserviceUser.Infraestructure.MongoAdapter.MongoEntities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Infraestructure.MongoAdapter
{
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        public Context(string stringConnection, string dbName)
        {
            MongoClient cliente = new(stringConnection);
            _database = cliente.GetDatabase(dbName);
        }

        public IMongoCollection<UserMongo> Users => _database.GetCollection<UserMongo>("Users");



    }
}
