using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class SimuDb:DbContext
    {
        public DbSet<Car> Voiture { get; set; }
        public DbSet<Garagist> Garagiste { get; set; } 
        public DbSet<Service> Carnet { get; set; }
    }
}