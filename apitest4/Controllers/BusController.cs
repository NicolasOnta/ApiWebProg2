using apitest4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apitest4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;
        public BusController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }
        // GET: api/<BusController>
        [HttpGet]
        public IEnumerable<Bus> Get()
        {
            return _CRUDContext.Buses;
        }

        // GET api/<BusController>/5
        [HttpGet("{id}")]
        public Bus Get(string id)
        {
            return _CRUDContext.Buses.SingleOrDefault(x => x.Placa == id);
        }

        // POST api/<BusController>
        [HttpPost]
        public void Post([FromBody] Bus Bus)
        {
            _CRUDContext.Buses.Add(Bus);
            _CRUDContext.SaveChanges();

        }

        // PUT api/<BusController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Bus Bus)
        {
            _CRUDContext.Buses.Update(Bus);
            _CRUDContext.SaveChanges();

        }

        // DELETE api/<BusController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var item = _CRUDContext.Buses.FirstOrDefault(x => x.Placa == id);
            if (item != null)
            {
                _CRUDContext.Buses.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
