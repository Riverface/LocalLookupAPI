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
        public ActionResult<IEnumerable<Business>> Get(string name, int id)
        {
            var query = _db.Businesses.AsQueryable();
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
        public void Post([FromBody] Business Business)
        {
            _db.Businesses.Add(Business);
            _db.SaveChanges();
        }

        //PUT api/Business/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Business Business)
        {
            Business.BusinessId = id;
            _db.Entry(Business).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/Business/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var BusinessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
            _db.Businesses.Remove(BusinessToDelete);
            _db.SaveChanges();
        }
    }
}