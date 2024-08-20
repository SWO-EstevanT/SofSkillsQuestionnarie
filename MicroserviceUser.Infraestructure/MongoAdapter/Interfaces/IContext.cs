using MicroserviceUser.Infraestructure.MongoAdapter.MongoEntities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Infraestructure.MongoAdapter.Interfaces
{
    public class IContext
    {
        public IMongoCollection<UserMongo> Users { get; }


    }
}
