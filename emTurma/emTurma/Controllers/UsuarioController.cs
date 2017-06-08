using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using emTurma.Models;

namespace emTurma.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly Usuario[] Usuario = new Usuario[]
        {
            new Usuario  {ID=1,Nome="Teste",Email="teste@teste.com",Senha="123456"},
            new Usuario  {ID=2,Nome="Vamos",Email="Vamos@teste.com",Senha="654321"},
            new Usuario  {ID=3,Nome="Que vamos",Email="Qvamos@teste.com",Senha="456123"}
        };


        // GET api/usuario

        public Usuario[] Get()
        {
            return Usuario;
        }

        // GET api/usuario/5
        public Usuario Get(int id)
        {
            var usuario = Usuario;
            return usuario.SingleOrDefault(x => x.ID == id);
        }
        // POST api/usuario
        public void Post([FromBody]string value)
        {
        }
        
        // PUT api/usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/usuario/5
        public void Delete(int id)
        {
        }
    }
}
