using GoogleMapsAPI.NET.API.Client;
using InsuranceDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;


namespace InsuranceDatabase.Controllers
{
    public class GoogleMapsController : Controller
    {
        private readonly InsuranceContext _context;

        public GoogleMapsController(InsuranceContext context)
        {
            _context = context;
        }
       /* public ActionResult Index()
        {
            return PartialView();
        }*/

        public JsonResult GetData()
        {
            var client = new MapsAPIClient("AIzaSyBfckBchOpn-lM4oJ9V9nBDBZmmlousIRQ");

            // Geocoding an address
            //var geocodeResult = client.Geocoding.Geocode("1600 Amphitheatre Parkway, Mountain View, CA");

            // создадим список данных
            List<BrokerAdress> brokerAdresses = new List<BrokerAdress>();
            var brokers = _context.Brokers.ToList();
            foreach(var b in brokers)
            {
                if (b.Adress == null) b.Adress = "вул. Матеюка 20";
                brokerAdresses.Add(new BrokerAdress()
                {
                    Name = b.Name,
                    Surname = b.Surname,
                    Adress = b.Adress,
                    GeoLat = client.Geocoding.Geocode(b.Adress).Results.FirstOrDefault().Geometry.Location.Latitude,
                    GeoLong = client.Geocoding.Geocode(b.Adress).Results.FirstOrDefault().Geometry.Location.Longitude
                });
            }
           /* {
                Id = 1,
                PlaceName = "Библиотека имени Ленина",
                GeoLat = 37.610489,
                GeoLong = 55.752308,
                Line = "Сокольническая",
                Traffic = 1.0
            });
            stations.Add(new Station()
            {
                Id = 2,
                PlaceName = "Александровский сад",
                GeoLat = 37.608644,
                GeoLong = 55.75226,
                Line = "Арбатско-Покровская",
                Traffic = 1.2
            });
            stations.Add(new Station()
            {
                Id = 3,
                PlaceName = "Боровицкая",
                GeoLat = 37.609073,
                GeoLong = 55.750509,
                Line = "Серпуховско-Тимирязевская",
                Traffic = 1.0
            });*/

            return Json(brokerAdresses);
        }
    }
}