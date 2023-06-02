using Registro_Visita_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Visita_Api.Interfaces
{
    interface IEventos
    {

        List<EventosTran> LisataEvento();
        string AgregarEvento(EventosTran evento);
        string EditaEvento(EventosTran evento);
        string InactivarEvento(int evento_id);


    }
}
