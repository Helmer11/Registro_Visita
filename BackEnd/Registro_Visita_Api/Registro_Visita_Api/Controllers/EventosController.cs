using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Models;
using Registro_Visita_Api.Persistencia;


namespace Registro_Visita_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventosController : Controller
    {
        [HttpGet]
        [Route("Lista")]
        public ActionResult ListaEvento()
        {
            IEventos ev = new Eventos();

            var list = ev.LisataEvento();

            return Ok(list);
        }

        [HttpPost]
        [Route("Inserta")]
        public ActionResult InsertarEvento([FromBody]  EventosTran evento)
        {
            IEventos ev = new Eventos();

            var inserta = ev.AgregarEvento(evento);

            return Ok(inserta);
        }

        [HttpPut]
        [Route("Edita")]
        public ActionResult EditaEvento([FromBody]  EventosTran evento)
        {
            IEventos ev = new Eventos();

            var edita = ev.EditaEvento(evento);

            return Ok(edita);
        }


        [HttpGet]
        [Route("Inactiva")]
        public ActionResult InactivaEvento(int idEvento)
        {
            IEventos ev = new Eventos();

            var inactivar = ev.InactivarEvento(idEvento);

            return Ok(inactivar);
        }



    }
}
