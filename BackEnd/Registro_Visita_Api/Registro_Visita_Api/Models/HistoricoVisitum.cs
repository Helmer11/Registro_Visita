using System;
using System.Collections.Generic;

#nullable disable

namespace Registro_Visita_Api.Models
{
    public partial class HistoricoVisitum
    {
        public int HistoricoId { get; set; }
        public string HistoricoNombre { get; set; }
        public DateTime HistoricoFecha { get; set; }
        public DateTime HistoricoHora { get; set; }
        public string RegistroEstado { get; set; }
        public string RegistroUsuario { get; set; }
        public DateTime? RegistroFecha { get; set; }
    }
}
