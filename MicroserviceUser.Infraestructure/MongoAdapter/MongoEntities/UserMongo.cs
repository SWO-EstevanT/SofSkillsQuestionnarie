﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Infraestructure.MongoAdapter.MongoEntities
{
    public class UserMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
       // public string Id { get; set; }
        public string uidUser { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int role { get; set; }



    }
}
