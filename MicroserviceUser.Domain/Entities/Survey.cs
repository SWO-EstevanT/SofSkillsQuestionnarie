using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Domain.Entities
{
    public class Survey
    {

        public string id_fire { get; set; }
        public string tittleSurvey { get; set; }
        public DateTime? dateCreation {  get; set; }
        public string answer = "No contestada";
       
        




    }
}
