using System;
using System.Collections.Generic;
using System.Linq;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioReporte : IRepositorioReporte
    {
        private readonly AppContext _appContext;

        public RepositorioReporte(AppContext appContext)
        {
            _appContext = appContext;
        }

        Reporte IRepositorioReporte.AddReporte(Reporte reporte)
        {
            var reporteAdicionado = _appContext.Reportes.Add(reporte);
            _appContext.SaveChanges();
            return reporteAdicionado.Entity;
        }

        Reporte IRepositorioReporte.UpdateReporte(Reporte reporte)
        {
            var reporteEncontrado =
                _appContext.Reportes.FirstOrDefault(p =>
                        p.Id == reporte.Id);
            if (reporteEncontrado != null)
            {
                reporteEncontrado.Id_TipoReporte  = reporte.Id_TipoReporte;
                reporteEncontrado.Descripcion  = reporte.Descripcion;
                reporteEncontrado.FechaInicio  = reporte.FechaInicio;
                reporteEncontrado.FechaFin  = reporte.FechaFin;
                reporteEncontrado.Codigo_Estacion  = reporte.Codigo_Estacion;
                reporteEncontrado.Ident_persona  = reporte.Ident_persona;
                reporteEncontrado.Codigo_actuacion  = reporte.Codigo_actuacion;
                _appContext.SaveChanges();
            }
            return reporteEncontrado;
        }

       
        Reporte IRepositorioReporte.GetReporteId(int idReporte)
        {
            var reporteEncontrado =
                _appContext
                    .Reportes
                    .FirstOrDefault(p =>
                        p.Id == idReporte);
            return reporteEncontrado;
        }

        IEnumerable<Reporte> IRepositorioReporte.GetAllReportes()
        {
            return _appContext.Reportes;
        }

      

        void IRepositorioReporte.DeleteReporteId(int idReporte)
        {
            var reporteEncontrado =
                _appContext
                    .Reportes
                    .FirstOrDefault(p =>
                        p.Id == idReporte);
            if (reporteEncontrado != null)
            {
                _appContext.Reportes.Remove(reporteEncontrado);
                _appContext.SaveChanges();
            }
            
        }
    }
}