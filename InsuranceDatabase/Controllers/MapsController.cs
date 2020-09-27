using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        private readonly InsuranceContext _context;
        public MapsController(InsuranceContext context)
        {
            _context = context;
        }
        [HttpGet("JsonMapsData")]
        public JsonResult JsonMapsData()
        {
            var brokers = _context.Brokers.ToList();
            List<object> brokerAdresses = new List<object>();
            //brokerAdresses.Add(new[] { "Категорія", "Послуг за категорією" });
            foreach (var b in brokers)
            {
                brokerAdresses.Add(new object[] { b.FullName , b.Adress });
            }
            return new JsonResult(brokerAdresses);
        }
    }
}
