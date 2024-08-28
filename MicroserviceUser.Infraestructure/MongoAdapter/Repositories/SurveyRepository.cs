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
    public class SurveyRepository : ISurveyRepository
    {
        private readonly IMongoCollection<SurveyMongo> _collection;
        private readonly IMapper _mapper;


        public SurveyRepository(IContext context, IMapper mapper)
        {
            _collection = context.Surveys;
            _mapper = mapper;
        }
        public async Task<string> CreateSurvey(CreateSurvey survey)
        {
            await _collection.InsertOneAsync(_mapper.Map<SurveyMongo>(survey));
            return JsonSerializer.Serialize("Survey Created");
        }
        public async Task<List<Survey>> GetSurveys()
        {
            var surveys = await _collection.FindAsync(Builders<SurveyMongo>.Filter.Empty);
            var surveyList = surveys.ToEnumerable().Select(x => _mapper.Map<Survey>(x)).ToList();
            if (surveyList.Count == 0)
            {
                throw new Exception("No surveys found.");
            }
            return surveyList;
        }


        public async Task<string> deleteSurvey(int uidSurvey) {

            await _collection.FindAsync<>
            return JsonSerializer.Serialize("Survey Deleted");
        }

    }
}
