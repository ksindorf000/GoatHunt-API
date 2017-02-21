using GoatHunt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace GoatHunt.Controllers
{
    public class HuntController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        /*************************
         * Get all Hunts
         *************************/
        public IQueryable<Hunt> Get()
        {
            return db.Hunts;
        }

        /*************************
         * Get Single Hunt
         *************************/
         [ResponseType(typeof(Hunt))]
        public IHttpActionResult Get(int? id)
        {
            Hunt instance = db.Hunts.Find(id);

            if (id == null)
            {
                return BadRequest();
            }

            if (instance == null)
            {
                return NotFound();
            }

            return Ok(instance);
        }

    }
}
