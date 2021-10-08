using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioCargo : IRepositorioCargo
    {
        private readonly AppContext _appContext;

        public RepositorioCargo(AppContext appContext)
        {
            _appContext = appContext;
        }

        Cargo IRepositorioCargo.AddCargo(Cargo cargo)
        {
            var cargoAdicionado = _appContext.Cargos.Add(cargo);
            _appContext.SaveChanges();
            return cargoAdicionado.Entity;
        }

        Cargo IRepositorioCargo.UpdateCargo(Cargo cargo)
        {
            var cargoEncontrado =
                _appContext
                    .Cargos
                    .FirstOrDefault(p =>
                        p.Codigo == cargo.Codigo);
            if (cargoEncontrado != null)
            {
                cargoEncontrado.Codigo = cargo.Codigo;
                cargoEncontrado.Descripcion = cargo.Descripcion;
                cargoEncontrado.Estado = cargo.Estado;
                _appContext.SaveChanges();
            }
            return cargoEncontrado;
        }

        Cargo IRepositorioCargo.GetCargo(string codigocargo)
        {
            var cargoEncontrado =
                _appContext
                    .Cargos
                    .FirstOrDefault(p =>
                        p.Codigo == codigocargo);
            return cargoEncontrado;
        }

        IEnumerable<Cargo> IRepositorioCargo.GetAllCargos()
        {
            return _appContext.Cargos;
        }

        Cargo IRepositorioCargo.DeleteCargo(string codigocargo)
        {
            var cargoEncontrado =
                _appContext
                    .Cargos
                    .FirstOrDefault(p =>
                        p.Codigo == codigocargo);
            if (cargoEncontrado != null)
            {
                _appContext.Cargos.Remove (cargoEncontrado);
                _appContext.SaveChanges();
            }
            return cargoEncontrado;
        }
    }
}