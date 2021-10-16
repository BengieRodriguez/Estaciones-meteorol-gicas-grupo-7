using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioCargo
    {
        IEnumerable<Cargo> GetAllCargos();

        Cargo AddCargo(Cargo cargo);

        Cargo UpdateCargo(Cargo cargo);

        Cargo GetCargo(string codigocargo);

        Cargo DeleteCargo(string codigocargo);

        Cargo GetCargoId(int idCargo);

        Cargo DeleteCargoId(int idCargo);
    }
}
