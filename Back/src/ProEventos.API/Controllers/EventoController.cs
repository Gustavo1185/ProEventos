using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular",
                    Local = "Belo Horizonte",
                    Lote = "Primeiro Lote",
                    QtdPessoa = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()

            },
            new Evento(){
                    EventoId = 2,
                    Tema = "Angularrrrrrrrr",
                    Local = "Salvador",
                    Lote = "Segundo Lote",
                    QtdPessoa = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()

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
        public IEnumerable<Evento> GetById (int id)
        {
            return _evento.Where(x => x.EventoId == id);
            
        }

         [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }
    }
}
