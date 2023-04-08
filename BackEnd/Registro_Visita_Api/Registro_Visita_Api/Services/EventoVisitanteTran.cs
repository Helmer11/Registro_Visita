using System;
using System.Collections.Generic;

#nullable disable

namespace Registro_Visita_Api.Persistencia
{
    public partial class EventoVisitanteTran
    {
        public int EventoVisitanteId { get; set; }
        public int VisitanteId { get; set; }
        public int EventoId { get; set; }
        public string RegistroEstado { get; set; }
        public string RegistroUsuario { get; set; }
        public DateTime RegistroFecha { get; set; }

        public virtual EventosTran Evento { get; set; }
        public virtual VisitantesTran Visitante { get; set; }
    }
}
