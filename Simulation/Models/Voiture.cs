using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulation.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public int Kilometrage { get; set; }
        public List<CarnetEntretien> Carnet { get; set; }


        public void CreerKilometrage()
        {
            Random kilo = new Random();
            this.Kilometrage = kilo.Next(20000, 200000);
        }

        public void rouler(string jour)  //à améliorer     jours ouvrés ou weekend
        {
            Random distance = new Random();
            if (jour == "Samedi" || jour == "Dimanche")
            {
                this.Kilometrage += distance.Next(50, 100);
            }
            else
            {
                this.Kilometrage += distance.Next(20, 50);
            }
        }
    }
}