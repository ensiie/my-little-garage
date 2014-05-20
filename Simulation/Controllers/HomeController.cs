using Simulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simulation.Controllers
{
    public class HomeController : Controller
    {
        static int duree;
        static string jour;
        SimuDb _db = new SimuDb();

        public ActionResult Index()
        {
            List<SelectListItem> list = new List<SelectListItem> {
                new SelectListItem { Text = "Lundi", Value = "Lundi",Selected = true},
                new SelectListItem { Text = "Mardi", Value = "Mardi" },
                new SelectListItem { Text = "Mercredi", Value = "Mercredi" },
                new SelectListItem { Text = "Jeudi", Value = "Jeudi" },
                new SelectListItem { Text = "Vendredi", Value = "Vendredi" },
                new SelectListItem { Text = "Samedi", Value = "Samedi" },
                new SelectListItem { Text = "Dimanche", Value = "Dimanche" },
            };
            this.ViewData["list"] = list;

            return View();
        }

        public ActionResult About(FormCollection formCollection)
        {
            string[] MarqueVoiture = { "Peugeot", "Citroen", "BMW" }; 
            //"Audi", "Renau", "Mercedez",, "Mini", "Toyota", "Honda", "Chevrolet"

            //Enlever les données anciennes dans la base de donnée
            foreach (var entity in _db.Voiture)
            {
                _db.Voiture.Remove(entity);
            }

            foreach (var entity in _db.Garagiste)
            {
                _db.Garagiste.Remove(entity);
            }

            //Création des voitures
            foreach (var item in MarqueVoiture)
            {
                int nb = int.Parse(formCollection[item]);
                while (nb > 0)
                {
                    _db.Voiture.Add(new Car { Marque = item});
                    nb--;
                }
            }
            _db.SaveChanges();

            //kilomètre entre 20000 et 200000 km
            int kilo = 0;
            foreach (var entity in _db.Voiture)
            {
                entity.CreerKilometrage();
                while (entity.Kilometrage == kilo)   //attention, Random() n'est pas vraiment aléatoire
                {
                    entity.CreerKilometrage();
                }
                kilo = entity.Kilometrage;
            }
            _db.SaveChanges();

            //Création garagiste
            foreach (var item in MarqueVoiture)
            {
                string nomGarage = "G" + item;
                int nb = int.Parse(formCollection[nomGarage]);
                while (nb > 0)
                {
                    _db.Garagiste.Add(new Garagist { Franchise = item });
                    nb--;
                }
            }
            _db.SaveChanges();

            duree = int.Parse(formCollection["Duree"]);
            jour = formCollection["List"];


            var model = _db.Voiture.ToList();
            return View(model);
        }

        public ActionResult Rouler()
        {
            int kilo = 0;
            foreach (var entity in _db.Voiture)
            {
                int kiloDebut = entity.Kilometrage;
                entity.rouler(jour);

                while (entity.Kilometrage - kiloDebut == kilo)   //attention, Random n'est pas vraiment aléatoire
                {
                    entity.Kilometrage = kiloDebut;
                    entity.rouler(jour);
                }
                kilo = entity.Kilometrage - kiloDebut;
            }
            _db.SaveChanges();

            var model = _db.Voiture.ToList();
            return View(model);
        }
    }
}
