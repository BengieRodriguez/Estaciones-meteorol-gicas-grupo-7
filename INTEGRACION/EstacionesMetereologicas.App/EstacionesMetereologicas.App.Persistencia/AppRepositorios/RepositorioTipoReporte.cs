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
                _appContext
                    .TipoDeReportes
                    .FirstOrDefault(p =>
                        p.Codigo == tiporeporte.Codigo);
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
    }
}