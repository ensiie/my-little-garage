using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class Garagiste
    {
        public int Id { get; set; }
        public string Franchise { get; set; }
        public int TempsLibre { get; set; }
        public int PeriodeFermeture { get; set; }
    }
}