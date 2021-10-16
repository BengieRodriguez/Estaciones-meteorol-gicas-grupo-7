using System;
using System.Collections.Generic;
using System.Linq;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioNovedades
    {
        IEnumerable<Novedades> GetAllNovedades();

        Novedades AddNovedades(Novedades novedades);

        Novedades UpdateNovedades(Novedades novedades);

        Novedades GetNovedades(string codigonovedades);

        Novedades DeleteNovedades(string codigonovedades);

        Novedades GetNovedadesId(int idNovedades);

        Novedades DeleteNovedadesId(int idNovedades);
    }
}