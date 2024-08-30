using AutoMapper;
using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using MicroserviceUser.UsesCases.Gateway;
using MicroserviceUser.UsesCases.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController
    {


        private readonly ISurveyUseCase _surveyUseCase;
        private readonly IMapper _mapper;

        public SurveyController(ISurveyUseCase surveyUseCase, IMapper mapper) {

            _surveyUseCase = surveyUseCase;
            _mapper = mapper;

        }

        [HttpPost]
        public async Task<string> CreateSurvey([FromBody] CreateSurvey survey)
        {
            return await _surveyUseCase.CreateSurvey(survey);
        }

        [HttpGet("")]
        public async Task<List<Survey>> GetSurveys()
        {
            return await _surveyUseCase.GetSurveys();
        }


        


    }
}
