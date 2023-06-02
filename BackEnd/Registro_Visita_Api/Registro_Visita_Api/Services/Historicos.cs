using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Models;


namespace Registro_Visita_Api.Services
{
    public class Historicos : IHistorico
    {

        private readonly IConfiguration _configu;
        public Historicos(IConfiguration config)
        {
            _configu = config;
        }

        public List<HistoricoVisitum> ListaHistorico()
        {
            try
            {
                using (var db = new Registros_VisistasContext(_configu))
                {
                    var list = db.HistoricoVisita.ToList();

                    return list;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public List<HistoricoVisitum> DetalleHistorico(int historicoID)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_configu))
                {
                    var detalle = db.HistoricoVisita.Where(x => x.HistoricoId == historicoID).ToList();

                    return detalle;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }







    }
}
