using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamroh.Domain.Entities.Drivers
{
    public class Driver
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string CarName { get; set; }

        public byte[] CarImage { get; set; }
    }
}
