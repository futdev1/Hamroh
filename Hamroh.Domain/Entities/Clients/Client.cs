using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamroh.Domain.Entities.Clients
{
    public class Client
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
