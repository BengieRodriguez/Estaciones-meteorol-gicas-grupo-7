using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioTipoReporte
    {
        IEnumerable<TipoReporte> GetAllTipoReporte();

        TipoReporte AddTipoReporte(TipoReporte tiporeporte);

        TipoReporte UpdateTipoReporte(TipoReporte tiporeporte);

        TipoReporte GetTipoReporte(string codigotiporeporte);

        TipoReporte DeleteTipoReporte(string codigotiporeporte);

        TipoReporte GetTipoReporteId(int idTipoReporte);

        TipoReporte DeleteTipoReporteId(int idTipoReporte);
    }
}