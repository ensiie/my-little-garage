using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class SimuDb:DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Garagist> Garagist { get; set; } 
        public DbSet<Service> Carnet { get; set; }
    }
}