using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioValidacion
    {
        Validacion AddValidacion(Validacion validacion);
        Validacion UpdateValidacion(int id,int val);
        Validacion GetValidacion(int id);
    }
}