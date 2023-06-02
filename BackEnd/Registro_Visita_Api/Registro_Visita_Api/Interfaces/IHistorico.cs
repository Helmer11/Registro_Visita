using Registro_Visita_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Registro_Visita_Api.Interfaces
{
    interface IHistorico
    {
        List<HistoricoVisitum> ListaHistorico();

        List<HistoricoVisitum> DetalleHistorico(int historicoID);
    }
}
