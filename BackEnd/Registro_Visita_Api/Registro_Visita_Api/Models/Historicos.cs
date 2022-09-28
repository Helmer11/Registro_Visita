using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Persistencia;


namespace Registro_Visita_Api.Models
{
    public class Historicos : IHistorico
    {

        IConfiguration _configu;
        public Historicos(IConfiguration config)
        {
            _configu = config;
        }

        public List<HistoricoVisitum> ListaHistorico()
        {
            using( var db = new Registros_VisistasContext(_configu))
            {
                var list = db.HistoricoVisita.ToList();

                return list;
            }
        }




    }
}
