using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamroh.Domain.Entities.ClientRequests
{
    public class ClientRequest
    {
        public string WhereFrom { get; set; }

        public string WhereTo { get; set; }

        public decimal Price { get; set; }

        public DateTime Date { get; set; }
    }
}
