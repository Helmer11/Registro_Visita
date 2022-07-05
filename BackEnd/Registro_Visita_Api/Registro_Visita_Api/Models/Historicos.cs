using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Persistencia;


namespace Registro_Visita_Api.Models
{
    public class Historicos : IHistorico
    {

        public List<HistoricoVisitum> ListaHistorico()
        {
            using( var db = new Registros_VisistasContext())
            {
                var list = db.HistoricoVisita.ToList();

                return list;
            }
        }




    }
}
