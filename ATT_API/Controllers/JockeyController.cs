using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using ATT_API.Models;
using ATT_API.Business;
using System.Web.Http.Cors;

namespace ATT_API.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class JockeyController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostJockey([FromBody] List<Jockey> jockeys)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                List<Jockey> returnJockeys = new List<Jockey>();
                foreach (var jockey in jockeys)
                {
                    Jockey returnJockey = AddDetails(jockey);
                    returnJockeys.Add(returnJockey);
                }
                return Ok(returnJockeys);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private static Jockey AddDetails(Jockey jockey)
        {
            Jockey returnJockey = new Jockey();
            JockeyService jockeyService = new JockeyService();
            returnJockey = jockey;
            returnJockey.RealAge = jockeyService.GetRealAge(returnJockey.DateOfBirth);
            returnJockey.DOBString = returnJockey.DateOfBirth.ToString("dd/MM/yyyy");
            return returnJockey;
        }
    }
}