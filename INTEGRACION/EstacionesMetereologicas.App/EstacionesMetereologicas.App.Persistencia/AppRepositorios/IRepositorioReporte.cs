using System;
using System.Collections.Generic;
using System.Linq;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioReporte
    {
        IEnumerable<Reporte> GetAllReportes();

        Reporte AddReporte(Reporte reporte);

        Reporte UpdateReporte(Reporte reporte);   

        Reporte GetReporteId(int idReporte);

        void DeleteReporteId(int idReporte);
    }
}