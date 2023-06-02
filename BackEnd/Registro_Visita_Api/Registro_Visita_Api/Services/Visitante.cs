using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Visita_Api.Services
{
    public class Visitante : IVisiantes
    {
        public readonly IConfiguration _config;

        public Visitante(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IEnumerable<VisitantesTran> ListaVisitante(string nombreVisitante)
        {
            string visitaNombre = nombreVisitante != null ? nombreVisitante : nombreVisitante = "";
            using (var db = new Registros_VisistasContext(_config))
            {
                var listado = db.VisitantesTrans.Where(w => w.VisitaNombre.StartsWith(visitaNombre)).OrderByDescending(x => x.VisitanteId).ToList();

                return listado;
            }
        }

        public List<VisitantesTran> getDetalleVisitante(int visitaID)
        {
            using (var db = new Registros_VisistasContext(_config))
            {
                var detalle = db.VisitantesTrans.Where(q => q.VisitanteId == visitaID).ToList();

                return detalle;
            }
        }

        public string AgregarVisitante(VisitantesTran visita)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_config))
                {
                    var _visit = new VisitantesTran()
                    {
                        VisitaNombre = visita.VisitaNombre,
                        VisitaApellido = visita.VisitaApellido,

                    };
                    db.VisitantesTrans.Add(_visit);
                    db.SaveChanges();
                }
                return "Se Agrego correctamente la visita";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string EditarVisitante(VisitantesTran visita)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_config))
                {
                    var result = db.VisitantesTrans.Where(x => x.VisitanteId == visita.VisitanteId).FirstOrDefault();

                    result.VisitaNombre = visita.VisitaNombre;
                    result.VisitaApellido = visita.VisitaApellido;
                    result.RegistroFecha = visita.RegistroFecha;
                    result.RegistroEstado = visita.RegistroEstado;
                    result.RegistroUsuario = visita.RegistroUsuario;

                    db.SaveChanges();
                }
                return "Se actualizo el registro del visitante";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string InactivarVisitante(int idVisitante)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_config))
                {
                    var inactivar = db.VisitantesTrans.SingleOrDefault(b => b.VisitanteId == idVisitante);

                    if (inactivar != null)
                    {
                        inactivar.RegistroEstado = "I";
                    }
                    db.SaveChanges();
                }
                return "Se elimino correctamente el visitante";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}
