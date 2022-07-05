using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Persistencia;


namespace Registro_Visita_Api.Models
{
    public class Eventos : IEventos
    {
        public List<EventosTran> LisataEvento()
        {

            using (var db = new Registros_VisistasContext())
            {
                var listaevento = db.EventosTrans.ToList();

                return listaevento;

            }
        }

        public string AgregarEvento(EventosTran evento)
        {
            try
            {
                using (var db= new Registros_VisistasContext() )
                {
                    var even = new EventosTran()
                    {
                        EventoNombre = evento.EventoNombre,
                        EventoDescripcion = evento.EventoDescripcion,
                        EventoFecha = evento.EventoFecha,
                        EventoHora = evento.EventoHora
                    };

                    db.EventosTrans.Add(even);
                    db.SaveChanges();
                    return "Se Agrego el evento";
                }
            } catch (Exception ex)
            {
                throw ex.InnerException.InnerException;
            }
        }

        public string EditaEvento(EventosTran evento)
        {
            try
            {
                using (var db = new Registros_VisistasContext())
                {
                    var even = new EventosTran()
                    {
                        EventoNombre = evento.EventoNombre,
                        EventoDescripcion = evento.EventoDescripcion,
                        EventoFecha = evento.EventoFecha,
                        EventoHora = evento.EventoHora
                    };

                    db.EventosTrans.Add(even);
                    db.SaveChanges();
                    return "Se Agrego el evento";
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException.InnerException;
            }
        }


        public string InactivarEvento(int evento_id)
        {
            try
            {
                using (var db = new Registros_VisistasContext())
                {
                    var inactivarEvento = db.EventosTrans.SingleOrDefault(b => b.EventoId == evento_id);

                    if (inactivarEvento != null)
                    {
                        inactivarEvento.RegistroEstado = "A";
                    }
                    db.SaveChanges();
                }
                return "Se Actualizo del visitante";
            }
            catch (Exception ex)
            {

                throw ex.InnerException.InnerException;
            }

        }




    }
    }



