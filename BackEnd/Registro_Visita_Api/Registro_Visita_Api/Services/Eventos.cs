using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Registro_Visita_Api.Interfaces;
using Registro_Visita_Api.Models;
using Registro_Visita_Api.Services;


namespace Registro_Visita_Api.Services
{
    public class Eventos : IEventos
    {
        private readonly IConfiguration _configu;

        public Eventos(IConfiguration config)
        {
            _configu = config;
        }


        public List<EventosTran> LisataEvento()
        {

            using (var db = new Registros_VisistasContext(_configu))
            {
                var listaevento = db.EventosTrans.ToList();

                return listaevento;

            }
        }

        public string AgregarEvento(EventosTran evento)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_configu))
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
                throw new Exception(ex.Message);
            }
        }

        public string EditaEvento(EventosTran evento)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_configu))
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
                    return "Se actualizo el evento";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string InactivarEvento(int evento_id)
        {
            try
            {
                using (var db = new Registros_VisistasContext(_configu))
                {
                    var inactivarEvento = db.EventosTrans.SingleOrDefault(b => b.EventoId == evento_id);

                    if (inactivarEvento != null)
                    {
                        inactivarEvento.RegistroEstado = "I";
                    }
                    db.SaveChanges();
                }
                return "Fue eliminado el visitante";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }




    }
}



