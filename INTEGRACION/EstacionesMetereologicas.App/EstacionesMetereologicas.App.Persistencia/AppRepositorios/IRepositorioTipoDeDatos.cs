using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioTipoDeDatos
    {
        IEnumerable<TipoDeDatos> GetAllTipoDeDatos();

        TipoDeDatos AddTipoDeDatos(TipoDeDatos tipodedatos);

        TipoDeDatos UpdateTipoDeDatos(TipoDeDatos tipodedatos);

        TipoDeDatos GetTipoDeDatos(string tipodedatos);

        TipoDeDatos DeleteTipoDeDatos(string tipodedatos);
    }
}
