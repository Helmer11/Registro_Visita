using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Models;
using Registro_Visita_Api.Persistencia;
using Microsoft.Extensions.Configuration;

namespace Registro_Visita_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitanteController : Controller
    {
        
        IConfiguration _configu;
        IVisiantes _visit;

        public VisitanteController(IConfiguration config)
        {
            _configu = config;
            _visit = new Visitante(_configu);
        }

        [HttpGet]
        [Route("Lista")]
        public ActionResult ListadoVisitante(string nombreVisitante)
        {
           // IVisiantes visit = new Visitante(_configu);

            var list = _visit.ListaVisitante(nombreVisitante);
            
            return Ok(list);
        }

        [HttpGet]
        [Route("detalle")]
        public ActionResult getDetalleVisitante(int id)
        {

            var list = _visit.getDetalleVisitante(id);

            return Ok(list);
        }

        [HttpPost]
        [Route("Agregar")]
        public ActionResult InsertarVisitante(VisitantesTran visit)
        {
          var insertarVisitante =   _visit.AgregarVisitante(visit);

          return  Ok(insertarVisitante);

        }

        [HttpPut]
        [Route("Edita")]
        public ActionResult EditarVisitante(VisitantesTran visit)
        {
            var editaVisitante = _visit.EditarVisitante(visit);

            return Ok(editaVisitante);
        }


        [HttpPost]
        [Route("Inactiva")]
        public ActionResult InactivaVisitante(int visit)
        {
            var inactivar = _visit.InactivarVisitante(visit);

            return Ok(inactivar);

        }



    }
}
