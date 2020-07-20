using LocalLookupAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LocalLookupAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        private LocalLookupAPIContext _db;

        public BusinessesController(LocalLookupAPIContext db)
        {
            _db = db;
        }

        // GET api/Business

        [HttpGet]
        public ActionResult<IEnumerable<Business>> Get(string name, int businessId, string phoneNumber, string cityId)
        {
            var query = _db.Businesses.AsQueryable();
            if (name != null) query = query.Where(entry => entry.Name == name);
            if (cityId != null) query = query.Where(entry => entry.Name == cityId);
            if (businessId > 0) query = query.Where(entry => entry.BusinessId == businessId);
            return query.ToList();
        }

        // GET api/Business/{id}
        [HttpGet("{id}")]
        public ActionResult<Business> Get(int id)
        {
            return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
        }

        // POST api/Business
        [HttpPost /*, ActionName("PostSingle") */ ]
        public void Post([FromBody] Business business)
        {
            _db.Businesses.Add(business);
            _db.SaveChanges();
        }

        //PUT api/Business/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Business business)
        {
            business.BusinessId = id;
            _db.Entry(business).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/Business/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Business BusinessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
            _db.Businesses.Remove(BusinessToDelete);
            _db.SaveChanges();
        }
    }
}