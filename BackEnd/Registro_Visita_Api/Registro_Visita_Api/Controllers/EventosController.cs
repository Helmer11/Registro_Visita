using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Models;
using Registro_Visita_Api.Services;
using Microsoft.Extensions.Configuration;

namespace Registro_Visita_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventosController : Controller
    {
        IConfiguration _configu;
        IEventos _ev;

        public EventosController(IConfiguration config)
        {
            _configu = config;
             _ev = new Eventos(_configu);
        }


        [HttpGet]
        [Route("Lista")]
        public ActionResult ListaEvento()
        {
            try
            {
                var list = _ev.LisataEvento();
                return Ok(list);

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        [HttpPost]
        [Route("Inserta")]
        public ActionResult InsertarEvento([FromBody]  EventosTran evento)
        {
            try
            {
                var inserta = _ev.AgregarEvento(evento);
                return Ok(inserta);

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Edita")]
        public ActionResult EditaEvento([FromBody]  EventosTran evento)
        {
            try
            {
                var edita = _ev.EditaEvento(evento);
                 return Ok(edita);

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            } 
        }


        [HttpGet]
        [Route("Inactiva")]
        public ActionResult InactivaEvento(int idEvento)
        {
            try
            {
                var inactivar = _ev.InactivarEvento(idEvento);

                return Ok(inactivar);

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            
        }



    }
}
