using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Services;


namespace Registro_Visita_Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HistoricoController : Controller
    {
        private readonly IConfiguration configu;
        private readonly IHistorico _historico;
        public HistoricoController(IConfiguration _configu)
        {
            configu = _configu;
            _historico = new Historicos(configu);
        }


        [HttpGet]
        [Route("Lista")]
        public IActionResult ListaHistorico()
        {
            try
            {
                var lista = _historico.ListaHistorico();
                return Ok(lista);

            }catch( Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("Detalle")]
        public IActionResult DetalleHistorico(int historicoID)
        {
            try
            {
                var detalle = _historico.DetalleHistorico(historicoID);
                return Ok(detalle);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
