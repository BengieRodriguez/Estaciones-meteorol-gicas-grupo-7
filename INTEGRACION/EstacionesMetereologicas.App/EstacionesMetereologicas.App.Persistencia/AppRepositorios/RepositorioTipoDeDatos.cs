using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioTipoDeDatos : IRepositorioTipoDeDatos
    {
        private readonly AppContext _appContext;

        public RepositorioTipoDeDatos(AppContext appContext)
        {
            _appContext = appContext;
        }

        TipoDeDatos IRepositorioTipoDeDatos.AddTipoDeDatos(TipoDeDatos tipodedatos)
        {
            var tipodedatoAdicionado = _appContext.TipoDeDatos.Add(tipodedatos);
            _appContext.SaveChanges();
            return tipodedatoAdicionado.Entity;
        }

        TipoDeDatos IRepositorioTipoDeDatos.UpdateTipoDeDatos(TipoDeDatos tipodedatos)
        {
            var tipodedatoEncontrado =
                _appContext
                    .TipoDeDatos
                    .FirstOrDefault(p =>
                        p.Codigo == tipodedatos.Codigo);
            if (tipodedatoEncontrado != null)
            {
                tipodedatoEncontrado.Codigo = tipodedatos.Codigo;
                tipodedatoEncontrado.Descripcion = tipodedatos.Descripcion;
                tipodedatoEncontrado.Estado = tipodedatos.Estado;
                _appContext.SaveChanges();
            }
            return tipodedatoEncontrado;
        }

        TipoDeDatos IRepositorioTipoDeDatos.GetTipoDeDatos(string codigotipodedatos)
        {
            var tipodedatoEncontrado =
                _appContext
                    .TipoDeDatos
                    .FirstOrDefault(p =>
                        p.Codigo == codigotipodedatos);
            return tipodedatoEncontrado;
        }

        TipoDeDatos IRepositorioTipoDeDatos.GetTipoDeDatosId(int idTipoDeDatos)
        {
            var tipodedatoEncontrado =
                _appContext
                    .TipoDeDatos
                    .FirstOrDefault(p =>
                        p.Id == idTipoDeDatos);
            return tipodedatoEncontrado;
        }

        IEnumerable<TipoDeDatos> IRepositorioTipoDeDatos.GetAllTipoDeDatos()
        {
            return _appContext.TipoDeDatos;
        }

        TipoDeDatos IRepositorioTipoDeDatos.DeleteTipoDeDatos(string codigotipodedatos)
        {
            var tipodedatoEncontrado =
                _appContext
                    .TipoDeDatos
                    .FirstOrDefault(p =>
                        p.Codigo == codigotipodedatos);
            if (tipodedatoEncontrado != null)
            {
                _appContext.TipoDeDatos.Remove (tipodedatoEncontrado);
                _appContext.SaveChanges();
            }
            return tipodedatoEncontrado;
        }

        TipoDeDatos IRepositorioTipoDeDatos.DeleteTipoDeDatosId(int idTipoDeDatos)
        {
            var tipodedatoEncontrado =
                _appContext
                    .TipoDeDatos
                    .FirstOrDefault(p =>
                        p.Id == idTipoDeDatos);
            if (tipodedatoEncontrado != null)
            {
                _appContext.TipoDeDatos.Remove (tipodedatoEncontrado);
                _appContext.SaveChanges();
            }
            return tipodedatoEncontrado;
        }
    }
}