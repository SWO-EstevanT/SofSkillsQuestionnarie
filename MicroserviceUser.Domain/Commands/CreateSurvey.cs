using MicroserviceUser.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Domain.Commands
{
    public class CreateSurvey
    {

        public string tittleSurvey { get; set; }
        public DateTime? dateCreation { get; set; }
        //public string enginnerId { get; set; }
        public string state { get; set; }
        public Collection<SurveyDetail> surveyDetail { get; set; }



    }
}
