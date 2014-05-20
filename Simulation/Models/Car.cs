using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class Car
    {
        [Key]
        public int car_id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int kilometre { get; set; }
        [ForeignKey ("service_id")]
        public int service_id { get; set; }


        public void CreerKilometrage()
        {
            Random kilo = new Random();
            this.kilometre = kilo.Next(20000, 200000);
        }

        public void rouler(string jour)  //à améliorer     jours ouvrés ou weekend
        {
            Random distance = new Random();
            if (jour == "Samedi" || jour == "Dimanche")
            {
                this.kilometre += distance.Next(50, 100);
            }
            else
            {
                this.kilometre += distance.Next(20, 50);
            }
        }
    }
}