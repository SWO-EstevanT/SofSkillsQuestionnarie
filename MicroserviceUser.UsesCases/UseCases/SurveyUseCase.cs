using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using MicroserviceUser.UsesCases.Gateway;
using MicroserviceUser.UsesCases.Gateway.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.UsesCases.UseCases
{
    public class SurveyUseCase : ISurveyUseCase
    {
        private readonly ISurveyRepository _surveyRepository;
        public SurveyUseCase(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }
        public async Task<string> CreateSurvey(CreateSurvey survey)
        {
            return await _surveyRepository.CreateSurvey(survey);
        }

        public async Task<Survey> GetSurveyById(Guid id)
        {
            return await _surveyRepository.GetSurveyById(id);
        }

        public async Task<List<Survey>> GetSurveys()
        {
            return await _surveyRepository.GetSurveys();
        }

        public async Task<string> UpdateSurvey(string id, SurveyUpdate upsur)
        {
           return await _surveyRepository.UpdateSurvey(id, upsur);
        }
    }
}
