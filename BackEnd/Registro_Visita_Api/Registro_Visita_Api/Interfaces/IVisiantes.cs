using Registro_Visita_Api.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Visita_Api.Interfaces
{
    interface IVisiantes
    {

        IEnumerable<VisitantesTran> ListaVisitante(string nombreVisitante);
        VisitantesTran getDetalleVisitante(int visitaID);

        string AgregarVisitante(VisitantesTran visita);
        string EditarVisitante(VisitantesTran visita);
        string InactivarVisitante(int idVisitante);

    }
}
