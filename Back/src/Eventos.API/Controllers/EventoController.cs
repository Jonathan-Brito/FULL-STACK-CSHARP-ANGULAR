using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Data;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Eventos.API.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
     {
       
        private readonly DataContext context;
        
        public EventoController(DataContext context) 
        {
            this.context = context;
        
        }
        
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}