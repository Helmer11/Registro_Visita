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
            try
            {
                var list = _visit.ListaVisitante(nombreVisitante);
                return Ok(list);

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message); 
            }

        }

        [HttpGet]
        [Route("detalle")]
        public ActionResult getDetalleVisitante(int id)
        {
            try
            {

                var list = _visit.getDetalleVisitante(id);

                return Ok(list);
            } catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }


        }

        [HttpPost]
        [Route("Agregar")]
        public ActionResult InsertarVisitante(VisitantesTran visit)
        {
            try
            {
                var insertarVisitante = _visit.AgregarVisitante(visit);

                return Ok(insertarVisitante);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Edita")]
        public ActionResult EditarVisitante(VisitantesTran visit)
        {
            try
            {
                var editaVisitante = _visit.EditarVisitante(visit);

                return Ok(editaVisitante);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }   
        }


        [HttpPost]
        [Route("Inactiva")]
        public ActionResult InactivaVisitante(int visit)
        {
            try
            {

                var inactivar = _visit.InactivarVisitante(visit);

                return Ok(inactivar);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
