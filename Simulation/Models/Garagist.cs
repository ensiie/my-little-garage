using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    
    public class Garagiste
    {
        [Key]
        public int garagist_id { get; set; }
        public string franchise { get; set; }
        public int car_id { get; set; }
        //Comment gerer le planning ?

        [ForeignKey ("service_id")]
        public int service_id { get; set; }

    }

   
}