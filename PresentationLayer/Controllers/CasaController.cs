using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    public class CasaController : Controller
    {
        private readonly ICasaAplication _casaAplciation;
        private readonly IMapper _mapper;

        public CasaController(ICasaAplication casaAplciation, IMapper mapper) {
            _casaAplciation = casaAplciation;
            _mapper = mapper;
        }
        // GET: api/Casa
        [HttpGet]
        public IEnumerable<CasaDTO> Get()
        {
            var data = _casaAplciation.GetCasa();

            var casas = data.Select(x => _mapper.Map<CasaDTO>(x)).ToList();

            return casas;
        }

        // GET: api/Casa/5
        [HttpGet("{id}")]
        public CasaDTO Get(int id)
        {       
            return _mapper.Map<CasaDTO>(_casaAplciation.GetCasa(id));
        }
        
        // POST: api/Casa
        [HttpPost]
        public Casa Post([FromBody]CasaDTO casa1)
        {
            Casa casa = _mapper.Map<Casa>(casa1);
            return _casaAplciation.AddCasa(casa);
        }
        
        // PUT: api/Casa/5
        [HttpPut()]
        public Casa Put([FromBody]CasaDTO casa2)
        {
            Casa casa = _mapper.Map<Casa>(casa2);
            return _casaAplciation.UpdateCasa(casa);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Casa Delete([FromBody]CasaDTO casa2)
        {
            Casa casa = _mapper.Map<Casa>(casa2);
            return _casaAplciation.DeleteCasa(casa);
        }
    }
}
