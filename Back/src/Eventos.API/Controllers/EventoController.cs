using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.API.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
     {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                EventoId = 1,
                Tema = "Angular",
                Local = "Teresina",
                Lote = "1 Lote",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                QtdPessoas = 100,
                ImagemURL = "https://www.google.com.br/images/branding/googlelogo/1"
            },
            new Evento() {
                EventoId = 2,
                Tema = "C #",
                Local = "Teresina",
                Lote = "2 Lote",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                QtdPessoas = 100,
                ImagemURL = "https://www.google.com.br/images/branding/googlelogo/2"
            }
            };
        
        public EventoController() 
        {
        
        }
        
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
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