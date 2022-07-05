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
    public class VisitanteController : Controller
    {
        [HttpGet]
        [Route("Lista")]
        public ActionResult ListadoVisitante()
        {
            IVisiantes visit = new Visitante();

            var list = visit.ListaVisitante();
            
            return Ok(list);
        }

        [HttpPost]
        [Route("Agregar")]
        public ActionResult InsertarVisitante(VisitantesTran visit)
        {

            IVisiantes visitante = new Visitante();

          var insertarVisitante =   visitante.AgregarVisitante(visit);

          return  Ok(insertarVisitante);

        }


        [HttpPut]
        [Route("Edita")]
        public ActionResult EditarVisitante(VisitantesTran visit)
        {

            IVisiantes visitante = new Visitante();

            var editaVisitante = visitante.EditarVisitante(visit);

            return Ok(editaVisitante);

        }
        [HttpPost]
        [Route("Inactiva")]
        public ActionResult InactivaVisitante(int visit)
        {

            IVisiantes visitante = new Visitante();

            var inactivaVisitante = visitante.InactivarVisitante(visit);

            return Ok(inactivaVisitante);

        }



    }
}
