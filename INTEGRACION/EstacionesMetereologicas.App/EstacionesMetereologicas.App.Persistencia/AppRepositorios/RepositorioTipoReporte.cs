using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioTipoReporte : IRepositorioTipoReporte
    {
        private readonly AppContext _appContext;

        public RepositorioTipoReporte(AppContext appContext)
        {
            _appContext = appContext;
        }

        TipoReporte IRepositorioTipoReporte.AddTipoReporte(TipoReporte tiporeporte)
        {
            var tiporeporteAdicionado = _appContext.TipoDeReportes.Add(tiporeporte);
            _appContext.SaveChanges();
            return tiporeporteAdicionado.Entity;
        }

        TipoReporte IRepositorioTipoReporte.UpdateTipoReporte(TipoReporte tiporeporte)
        {
            var tiporeporteEncontrado =
                _appContext.TipoDeReportes.FirstOrDefault(p =>
                        p.Id == tiporeporte.Id);
            if (tiporeporteEncontrado != null)
            {
                tiporeporteEncontrado.Codigo = tiporeporte.Codigo;
                tiporeporteEncontrado.Nombre_TipoReporte = tiporeporte.Nombre_TipoReporte;
                tiporeporteEncontrado.Estado = tiporeporte.Estado;
                _appContext.SaveChanges();
            }
            return tiporeporteEncontrado;
        }

        TipoReporte IRepositorioTipoReporte.GetTipoReporte(string codigotiporeporte)
        {
            var tiporeporteEncontrado =
                _appContext
                    .TipoDeReportes
                    .FirstOrDefault(p =>
                        p.Codigo == codigotiporeporte);
            return tiporeporteEncontrado;
        }

        TipoReporte IRepositorioTipoReporte.GetTipoReporteId(int idTipoReporte)
        {
            var tipoReporteEncontrado =
                _appContext
                    .TipoDeReportes
                    .FirstOrDefault(p =>
                        p.Id == idTipoReporte);
            return tipoReporteEncontrado;
        }

        IEnumerable<TipoReporte> IRepositorioTipoReporte.GetAllTipoReporte()
        {
            return _appContext.TipoDeReportes;
        }

        TipoReporte IRepositorioTipoReporte.DeleteTipoReporte(string codigotiporeporte)
        {
            var tiporeporteEncontrado =
                _appContext
                    .TipoDeReportes
                    .FirstOrDefault(p =>
                        p.Codigo == codigotiporeporte);
            if (tiporeporteEncontrado != null)
            {
                _appContext.TipoDeReportes.Remove (tiporeporteEncontrado);
                _appContext.SaveChanges();
            }
            return tiporeporteEncontrado;
        }

        TipoReporte IRepositorioTipoReporte.DeleteTipoReporteId(int idTipoReporte)
        {
            var tipoReporteEncontrado =
                _appContext
                    .TipoDeReportes
                    .FirstOrDefault(p =>
                        p.Id == idTipoReporte);
            if (tipoReporteEncontrado != null)
            {
                _appContext.TipoDeReportes.Remove (tipoReporteEncontrado);
                _appContext.SaveChanges();
            }
            return tipoReporteEncontrado;
        }
    }
}