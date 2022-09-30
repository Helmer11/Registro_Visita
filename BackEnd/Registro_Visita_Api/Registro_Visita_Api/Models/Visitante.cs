using Microsoft.Extensions.Configuration;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Visita_Api.Models
{
    public class Visitante : IVisiantes
    {
        public readonly  IConfiguration _config;

        public Visitante(IConfiguration configuration)
        {
            _config = configuration;
        }


        public IEnumerable<VisitantesTran> ListaVisitante()
        {
            using( var db = new Registros_VisistasContext(_config) )
            {
                var listado = db.VisitantesTrans.ToList().OrderByDescending(x=> x.VisitanteId);

                return listado;
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
                return "1";
            } catch (Exception ex)
            {
              
                throw ex.InnerException.InnerException;

            } 
        }

        //public string EditarVisitante(VisitantesTran visita)
        //{
        //    try
        //    {
        //        using (var db = new Registros_VisistasContext(_config))
        //        {
        //            var _visit = new VisitantesTran()
        //            {
        //                VisitaNombre = visita.VisitaNombre,
        //                VisitaApellido = visita.VisitaApellido,

        //            };
        //            db.VisitantesTrans.Add(_visit);
        //            db.SaveChanges();
        //        }
        //        return "Se Actualizo del visitante";
        //    } catch (Exception ex)
        //    {
              
        //        throw ex.InnerException.InnerException;
        //    }
           
        //}


        //public string InactivarVisitante(int idVisitante)
        //{
        //    try
        //    {
        //        using (var db = new Registros_VisistasContext(_config))
        //        {
        //            var inactivar = db.VisitantesTrans.SingleOrDefault(b => b.VisitanteId == idVisitante);

        //            if (inactivar != null)
        //            {
        //                inactivar.RegistroEstado = "A";
        //            }
        //            db.SaveChanges();
        //        }
        //        return "Se Actualizo del visitante";
        //    }
        //    catch (Exception ex)
        //    {
               
        //        throw ex.InnerException.InnerException;
        //    }

        //}





    }
}
