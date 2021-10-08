using System;
using System.Collections.Generic;
using System.Linq;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioActuacion
    {
        IEnumerable<Actuacion> GetAllActuaciones();

        Actuacion AddActuacion(Actuacion actuacion);

        Actuacion UpdateActuacion(Actuacion actuacion);

        Actuacion GetActuacion(string codigoactuacion);

        Actuacion DeleteActuacion(string codigoactuacion);
    }
}