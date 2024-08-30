using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.UsesCases.Gateway
{
    public interface ISurveyUseCase
    {

        Task<string> CreateSurvey(CreateSurvey survey);
        Task<List<Survey>> GetSurveys();
    }
}
