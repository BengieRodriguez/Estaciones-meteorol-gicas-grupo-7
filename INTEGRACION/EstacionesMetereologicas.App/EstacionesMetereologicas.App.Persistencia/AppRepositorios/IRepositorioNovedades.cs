using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}