using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioEstacion : IRepositorioEstacion
    {
        private readonly AppContext _appContext;

        public RepositorioEstacion(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estacion IRepositorioEstacion.AddEstacion(Estacion estacion)
        {
            var estacionAdicionado = _appContext.Estacion.Add(estacion);
            _appContext.SaveChanges();
            return estacionAdicionado.Entity;
        }

        Estacion IRepositorioEstacion.UpdateEstacion(Estacion estacion)
        {
            var estacionEncontrado =
                _appContext
                    .Estacion
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == estacion.Codigo_Estacion);
            if (estacionEncontrado != null)
            {
                estacionEncontrado.Codigo_Estacion = estacion.Codigo_Estacion;
                estacionEncontrado.Nombre_Estacion = estacion.Nombre_Estacion;
                estacionEncontrado.Fecha_Montaje = estacion.Fecha_Montaje;
                estacionEncontrado.Latitud = estacion.Latitud;
                estacionEncontrado.Longitud = estacion.Longitud;
                estacionEncontrado.Municipio = estacion.Municipio;
                _appContext.SaveChanges();
            }
            return estacionEncontrado;
        }

        Estacion IRepositorioEstacion.GetEstacion(string codigoestacion)
        {
            var estacionEncontrado =
                _appContext
                    .Estacion
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == codigoestacion);
            return estacionEncontrado;
        }

        IEnumerable<Estacion> IRepositorioEstacion.GetAllEstaciones()
        {
            return _appContext.Estacion;
        }

        Estacion IRepositorioEstacion.DeleteEstacion(string codigoestacion)
        {
            var estacionEncontrado =
                _appContext
                    .Estacion
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == codigoestacion);
            if (estacionEncontrado != null)
            {
                _appContext.Estacion.Remove (estacionEncontrado);
                _appContext.SaveChanges();
            }
            return estacionEncontrado;
        }
    }
}