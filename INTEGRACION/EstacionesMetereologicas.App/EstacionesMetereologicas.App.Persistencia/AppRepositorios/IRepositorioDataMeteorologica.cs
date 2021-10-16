using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public interface IRepositorioDataMeteorologica
    {
        IEnumerable<DataMeteorologica> GetAllDataMeteorologica();

        DataMeteorologica AddDataMeteorologica(DataMeteorologica datameteorologica);

        DataMeteorologica UpdateDataMeteorologica(DataMeteorologica datameteorologica);

        DataMeteorologica GetDataMeteorologica(string codigodatameteorologica);

        DataMeteorologica DeleteDataMeteorologica(string codigodatameteorologica);

        DataMeteorologica GetDataMeteorologicaId(int idDataMeteorologica);

        DataMeteorologica DeleteDataMeteorologicaId(int idDataMeteorologica);
    }
}
