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
            //var client = new MapsAPIClient("AIzaSyBfckBchOpn-lM4oJ9V9nBDBZmmlousIRQ");

            // Geocoding an address
            //var geocodeResult = client.Geocoding.Geocode("1600 Amphitheatre Parkway, Mountain View, CA");

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
                    GeoLat = b.GeoLatitude,
                    GeoLong = b.GeoLongitude
                });
            }
           
            return Json(brokerAdresses);
        }
    }
}