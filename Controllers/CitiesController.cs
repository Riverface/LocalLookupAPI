using LocalLookupAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LocalLookupAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private LocalLookupAPIContext _db;

        public CitiesController(LocalLookupAPIContext db)
        {
            _db = db;
        }

        // GET api/City
        [HttpGet]
        public ActionResult<IEnumerable<City>> Get(string name, int cityId, int ZipCode)
        {
            var query = _db.Cities.AsQueryable();
            if (name != null) query = query.Where(entry => entry.Name == name);
            if (cityId > 0) query = query.Where(entry => entry.CityId == cityId);
            if (name != null) query = query.Where(entry => entry.ZipCode == ZipCode);
            return query.ToList();
        }

        // GET api/City/{id}
        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            return _db.Cities.FirstOrDefault(entry => entry.CityId == id);
        }

        // POST api/City
        [HttpPost]
        public void Post([FromBody] City City)
        {
            _db.Cities.Add(City);
            _db.SaveChanges();
        }

        //PUT api/City/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City City)
        {
            City.CityId = id;
            _db.Entry(City).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/City/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var CityToDelete = _db.Cities.FirstOrDefault(entry => entry.CityId == id);
            _db.Cities.Remove(CityToDelete);
            _db.SaveChanges();
        }
    }
}