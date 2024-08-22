using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Domain.Entities
{
    public class Survey
    {
        public string surveyMongoId { get; set; }
        public string tittle { get; set; }
        public DateTime? dateCreation { get; set; }
        
        //public string enginnerId { get; set; }
        public int state { get; set; }




    }
}
