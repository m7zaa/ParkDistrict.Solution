using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkDistrict.Models;
using Microsoft.AspNetCore.Authorization;
using System;


namespace ParkDistrict.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParkDistrictContext _db;

        public ParksController(ParkDistrictContext db)
        {
            _db = db;
        }


        


        // GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string name, string location, bool playground, bool picnicArea, bool bathroom)
        {
            var query = _db.Parks.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
            }
            if (location != null)
            {
                query = query.Where(entry => entry.Location.ToLower().Contains(location.ToLower()));
            }
            if (playground != false)
            {
                query = query.Where(entry => entry.Playground == playground);
            }
            if (picnicArea != false)
            {
                query = query.Where(entry => entry.PicnicArea == picnicArea);
            }
            if (bathroom != false)
            {
                query = query.Where(entry => entry.Bathroom == bathroom);
            }
            return query.ToList();
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}