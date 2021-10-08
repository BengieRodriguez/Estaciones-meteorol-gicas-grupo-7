using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioActuacion : IRepositorioActuacion
    {
        private readonly AppContext _appContext;

        public RepositorioActuacion(AppContext appContext)
        {
            _appContext = appContext;
        }

        Actuacion IRepositorioActuacion.AddActuacion(Actuacion actuacion)
        {
            var actuacionAdicionada = _appContext.Actuaciones.Add(actuacion);
            _appContext.SaveChanges();
            return actuacionAdicionada.Entity;
        }

        Actuacion IRepositorioActuacion.UpdateActuacion(Actuacion actuacion)
        {
            var actuacionEncontrada =
                _appContext.Actuaciones.FirstOrDefault(p =>
                        p.Codigo == actuacion.Codigo);
            if (actuacionEncontrada != null)
            {
                actuacionEncontrada.Codigo = actuacion.Codigo;
                actuacionEncontrada.Descripcion = actuacion.Descripcion;
                actuacionEncontrada.Estado = actuacion.Estado;
                _appContext.SaveChanges();
            }
            return actuacionEncontrada;
        }

        Actuacion IRepositorioActuacion.GetActuacion(string codigoactuacion)
        {
            var actuacionEncontrada =
                _appContext
                    .Actuaciones
                    .FirstOrDefault(p =>
                        p.Codigo == codigoactuacion);
            return actuacionEncontrada;
        }

        IEnumerable<Actuacion> IRepositorioActuacion.GetAllActuaciones()
        {
            return _appContext.Actuaciones;
        }

        Actuacion IRepositorioActuacion.DeleteActuacion(string codigoactuacion)
        {
            var actuacionEncontrada =
                _appContext
                    .Actuaciones
                    .FirstOrDefault(p =>
                        p.Codigo == codigoactuacion);
            if (actuacionEncontrada != null)
            {
                _appContext.Actuaciones.Remove (actuacionEncontrada);
                _appContext.SaveChanges();
            }
            return actuacionEncontrada;
        }
    }
}