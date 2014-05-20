using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class Service
    {
        [Key]
        public int service_id { get; set; }
        public string label { get; set; }
        public int distance { get; set; }
        public int duration { get; set; }
        [ForeignKey("car_id")]
        public int car_id { get; set; }
    }

    public class Garagist
    {
        [Key]
        public int garagist_id { get; set; }
        public string franchise { get; set; }
        [ForeignKey("car_id")]
        public int car_id { get; set; }
        [ForeignKey("service_id")]
        public int service_id { get; set; }
    }

    public class Car
    {
        [Key]
        public int car_id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        [ForeignKey("service_id")]
        public int service_id { get; set; }
    }
}