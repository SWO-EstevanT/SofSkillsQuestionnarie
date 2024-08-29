using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.Domain.Commands
{
    public class CreateUser
    {

        public string? id_fire {  get; set; } 
        public string? name { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
     }
}
