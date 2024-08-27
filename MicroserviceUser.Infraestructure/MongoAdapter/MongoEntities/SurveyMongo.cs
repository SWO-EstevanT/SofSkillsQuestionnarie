using MicroserviceUser.Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public string tittleSurvey { get; set; }
        public DateTime dateCreation { get; set; }
        public string state  { get; set; }
        public Collection<SurveyDetail> surveyDetails { get; set; }
    }
}
