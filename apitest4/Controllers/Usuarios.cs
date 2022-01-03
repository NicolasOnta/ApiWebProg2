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
    public class Usuarios : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;
        public Usuarios(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }
        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _CRUDContext.Usuarios;
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _CRUDContext.Usuarios.SingleOrDefault(x => x.UsuarioId == id);
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            _CRUDContext.Usuarios.Add(usuario);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Usuario usuario)
        {
            _CRUDContext.Usuarios.Update(usuario);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Usuarios.FirstOrDefault(x => x.UsuarioId == id);
            if (item != null)
            {
                _CRUDContext.Usuarios.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
