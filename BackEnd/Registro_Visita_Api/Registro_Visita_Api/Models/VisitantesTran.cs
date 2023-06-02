using System;
using System.Collections.Generic;

#nullable disable

namespace Registro_Visita_Api.Models
{
    public partial class VisitantesTran
    {
        public VisitantesTran()
        {
            EventoVisitanteTrans = new HashSet<EventoVisitanteTran>();
        }

        public int VisitanteId { get; set; }
        public string VisitaNombre { get; set; }
        public string VisitaApellido { get; set; }
        public string RegistroEstado { get; set; }
        public string RegistroUsuario { get; set; }
        public DateTime RegistroFecha { get; set; }

        public virtual ICollection<EventoVisitanteTran> EventoVisitanteTrans { get; set; }
    }
}
