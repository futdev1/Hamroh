using Hamroh.Domain.Entities.ClientRequests;
using Hamroh.Domain.Entities.Clients;
using Hamroh.Domain.Entities.DriverRequests;
using Hamroh.Domain.Entities.Drivers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamroh.Data.Contexts
{
    public class HamrohDbContext : DbContext
    {
        public HamrohDbContext(DbContextOptions<HamrohDbContext> options) 
            : base(options)
        {

        }

        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DriverRequest> DriverRequests { get; set; }
        public virtual DbSet<ClientRequest> ClientRequests { get; set; }

    }
}
