using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceDatabase.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutocompleteController : ControllerBase
    {
        private readonly InsuranceContext _context;
        public AutocompleteController(InsuranceContext context)
        {
            _context = context;
        }

        /*   [Produces("application/json")]
           [HttpGet("autocomplete")]
           public JsonResult Autocomplete(string term)
           {
               // try
               // {
              /* string term = HttpContext.Request.Query["term"].ToString();
               Console.WriteLine(term);
               //string term = HttpUtility.UrlDecode(HttpContext.Request.Query["term"].ToString());
               var names = _context.Brokers.Where(p => p.FullName.Contains(term)).Select(p => p.FullName).ToList();
               return Ok(names);
               /*  }
                 catch
                 {
                     return BadRequest();
                 }
               //string term = HttpContext.Request.Query["term"].ToString();
               List<object> brokersNameId = new List<object>();
               var brokers = _context.Brokers.Where(p => p.FullName.Contains(term)).ToList();
               foreach (var b in brokers)
               {
                   brokersNameId.Add(new object[] { b.FullName, b.Id });
               }
               return new JsonResult(brokersNameId);
           }*/

        [HttpGet]
        public JsonResult AutocompleteBrokerId(string term) {
            var models = _context.Brokers.Where(a => a.FullName.Contains(term))
                            .Select(a => new { label = a.FullName, value = a.Id })
                            .Distinct();

            return new JsonResult(models);
        }

        [HttpGet]
       public JsonResult AutocompleteTypeId(string term)
        {
            var models = _context.Types.Where(a => a.Type.Contains(term))
                            .Select(a => new { label = a.Type, value = a.Id })
                            .Distinct();

            return new JsonResult(models);
        }
    }
}
