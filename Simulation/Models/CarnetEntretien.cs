using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class CarnetEntretien
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Libelle { get; set; }
        public int Kilometrage { get; set; }
        public int DureeIntervention { get; set; }
    }
}