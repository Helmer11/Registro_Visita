using System;
using System.Collections.Generic;

#nullable disable

namespace Registro_Visita_Api.Persistencia
{
    public partial class HistoricosMovimiento
    {
        public int HistoricoMovimientoId { get; set; }
        public int VisitanteId { get; set; }
        public int EventosId { get; set; }
        public DateTime MovimientoFecha { get; set; }
        public string RegistroEstado { get; set; }
        public string RegistroUsuario { get; set; }
        public DateTime RegistroFecha { get; set; }
    }
}
