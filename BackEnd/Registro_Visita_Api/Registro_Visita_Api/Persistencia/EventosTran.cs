using System;
using System.Collections.Generic;

#nullable disable

namespace Registro_Visita_Api.Persistencia
{
    public partial class EventosTran
    {
        public EventosTran()
        {
            EventoVisitanteTrans = new HashSet<EventoVisitanteTran>();
        }

        public int EventoId { get; set; }
        public string EventoNombre { get; set; }
        public string EventoDescripcion { get; set; }
        public DateTime EventoFecha { get; set; }
        public DateTime EventoHora { get; set; }
        public string RegistroEstado { get; set; }
        public string RegistroUsuario { get; set; }
        public DateTime RegistroFecha { get; set; }

        public virtual ICollection<EventoVisitanteTran> EventoVisitanteTrans { get; set; }
    }
}
