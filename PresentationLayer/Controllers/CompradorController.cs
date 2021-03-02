using System.Collections.Generic;
using AplicationLayer.Inteface;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    public class CompradorController : Controller
    {
        private readonly IComparadorAplication _CompradorAplication;

        
        public CompradorController(IComparadorAplication CompradorAplication)
        {
            _CompradorAplication = CompradorAplication;
        }
        

        // GET api/values
        [HttpGet]
        public List<Comprador> Get()
        {
            return _CompradorAplication.GetComprador();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Comprador Get(int id)
        {
            return _CompradorAplication.GetComprador(id);
        }

        // POST api/values
        [HttpPost]
        public Comprador Post([FromBody]Comprador Comprador)
        {
            return _CompradorAplication.AddComprador(Comprador);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Comprador Put(int id, [FromBody]Comprador Comprador)
        {
            return _CompradorAplication.UpdateComprador(Comprador);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Comprador Delete(int id, [FromBody]Comprador Comprador)
        {
            return _CompradorAplication.DeleteComprador(Comprador);
        }
    }
}