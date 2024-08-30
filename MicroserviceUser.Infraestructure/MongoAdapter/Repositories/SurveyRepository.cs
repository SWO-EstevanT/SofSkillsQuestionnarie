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
        public async Task<Survey> GetSurveyById(string id)
        {

            var survey = await _collection.Find(c => c.id_fire == id).FirstOrDefaultAsync()
            ?? throw new Exception($"There isn't a survey with this ID: {id}.");
            var surveyComplete = _mapper.Map<Survey>(survey);
            return surveyComplete;
        }

        public async Task<string> UpdateSurvey(string id, Survey survey) { 

            var surveyFind = GetSurveyById(id);
            // Crear el filtro para encontrar la encuesta por su ID
            var filter = Builders<SurveyMongo>.Filter.Eq(s => s.id_fire, id);

            // Definir la actualización de los campos
            var update = Builders<SurveyMongo>.Update
                .Set(s => s.answer, survey.answer);

            // Ejecutar la actualización
            var updateResult = await _collection.UpdateOneAsync(filter, update);

            if (updateResult.ModifiedCount > 0)
            {
                return "Survey updated successfully.";
            }
            else
            {
                return "No changes were made to the survey.";
            }
        }

    }
}
