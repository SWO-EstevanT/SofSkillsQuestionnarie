using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Infraestructure.MongoAdapter.MongoEntities
{
    public class SurveyMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string uidSurvey { get; set; }
        public string tittle { get; set; }
        public DateTime dateCreation { get; set; }
        public string state  { get; set; }
    }
}
