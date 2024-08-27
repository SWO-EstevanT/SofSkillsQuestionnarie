using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MicroserviceUser.Domain.Entities
{
    public class SurveyDetail { 
    
        
        //public string Id { get; set; } = Guid.NewGuid().ToString();
        public string titleQuestion { get; set; } 
        public string type { get; set; }  
        public List<string> Options { get; set; } 


    }
}
