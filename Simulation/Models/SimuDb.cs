using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class SimuDb:DbContext
    {
        public DbSet<Voiture> Voiture { get; set; }
        public DbSet<Garagiste> Garagiste { get; set; } 
        public DbSet<CarnetEntretien> Carnet { get; set; }
    }
}