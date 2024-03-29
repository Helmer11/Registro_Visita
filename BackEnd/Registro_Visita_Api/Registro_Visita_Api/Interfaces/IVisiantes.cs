﻿using Registro_Visita_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Visita_Api.Interfaces
{
    interface IVisiantes
    {

        IEnumerable<VisitantesTran> ListaVisitante(string nombreVisitante);
        List<VisitantesTran> getDetalleVisitante(int visitaID);

        string AgregarVisitante(VisitantesTran visita);
        string EditarVisitante(VisitantesTran visita);
        string InactivarVisitante(int idVisitante);

    }
}
