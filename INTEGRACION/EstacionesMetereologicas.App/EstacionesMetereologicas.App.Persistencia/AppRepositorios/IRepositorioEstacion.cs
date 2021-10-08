using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioEstacion
    {
        IEnumerable<Estacion> GetAllEstaciones();

        Estacion AddEstacion(Estacion estacion);

        Estacion UpdateEstacion(Estacion estacion);

        Estacion GetEstacion(string codigoestacion);

        Estacion DeleteEstacion(string codigoestacion);
    }
}