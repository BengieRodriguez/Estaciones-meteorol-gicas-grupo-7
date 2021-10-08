using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioNovedades : IRepositorioNovedades
    {
        private readonly AppContext _appContext;

        public RepositorioNovedades(AppContext appContext)
        {
            _appContext = appContext;
        }

        Novedades IRepositorioNovedades.AddNovedades(Novedades novedades)
        {
            var novedadesAdicionado = _appContext.Novedades.Add(novedades);
            _appContext.SaveChanges();
            return novedadesAdicionado.Entity;
        }

        Novedades IRepositorioNovedades.UpdateNovedades(Novedades novedades)
        {
            var novedadesEncontrado =
                _appContext
                    .Novedades
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == novedades.Codigo_Estacion);
            if (novedadesEncontrado != null)
            {
                novedadesEncontrado.Codigo_Estacion = novedades.Codigo_Estacion;
                novedadesEncontrado.Fecha_Novedad = novedades.Fecha_Novedad;
                novedadesEncontrado.Actuacion = novedades.Actuacion;
                novedadesEncontrado.Observacion = novedades.Observacion;
                _appContext.SaveChanges();
            }
            return novedadesEncontrado;
        }

        Novedades IRepositorioNovedades.GetNovedades(string codigonovedades)
        {
            var novedadesEncontrado =
                _appContext
                    .Novedades
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == codigonovedades);
            return novedadesEncontrado;
        }

        IEnumerable<Novedades> IRepositorioNovedades.GetAllNovedades()
        {
            return _appContext.Novedades;
        }

        Novedades IRepositorioNovedades.DeleteNovedades(string codigonovedades)
        {
            var novedadesEncontrado =
                _appContext
                    .Novedades
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == codigonovedades);
            if (novedadesEncontrado != null)
            {
                _appContext.Novedades.Remove (novedadesEncontrado);
                _appContext.SaveChanges();
            }
            return novedadesEncontrado;
        }
    }
}