using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioDataMeteorologica : IRepositorioDataMeteorologica
    {
        private readonly AppContext _appContext;

        public RepositorioDataMeteorologica(AppContext appContext)
        {
            _appContext = appContext;
        }

        DataMeteorologica IRepositorioDataMeteorologica.AddDataMeteorologica(DataMeteorologica datameteorologica)
        {
            var datameteorologicaAdicionado =
                _appContext.DataMeteorologica.Add(datameteorologica);
            _appContext.SaveChanges();
            return datameteorologicaAdicionado.Entity;
        }

        DataMeteorologica IRepositorioDataMeteorologica.UpdateDataMeteorologica(DataMeteorologica datameteorologica)
        {
            var datameteorologicaEncontrado =
                _appContext
                    .DataMeteorologica
                    .FirstOrDefault(p =>
                        p.Id == datameteorologica.Id);
            if (datameteorologicaEncontrado != null)
            {
                datameteorologicaEncontrado.Codigo_Estacion = datameteorologica.Codigo_Estacion;
                datameteorologicaEncontrado.Nombre_Estacion = datameteorologica.Nombre_Estacion;
                datameteorologicaEncontrado.Fecha = datameteorologica.Fecha;
                datameteorologicaEncontrado.Temperatura = datameteorologica.Temperatura;
                datameteorologicaEncontrado.Humedad = datameteorologica.Humedad;
                datameteorologicaEncontrado.Presion_Atmosferica = datameteorologica.Presion_Atmosferica;
                datameteorologicaEncontrado.Velocidad_Viento = datameteorologica.Velocidad_Viento;
                datameteorologicaEncontrado.Pluviosidad = datameteorologica.Pluviosidad;
                datameteorologicaEncontrado.Radiacion_Solar = datameteorologica.Radiacion_Solar;
                _appContext.SaveChanges();
            }
            return datameteorologicaEncontrado;
        }

        DataMeteorologica IRepositorioDataMeteorologica.GetDataMeteorologica(string codigodatameteorologica)
        {
            var datameteorologicaEncontrado =
                _appContext
                    .DataMeteorologica
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == codigodatameteorologica);
            return datameteorologicaEncontrado;
        }

        DataMeteorologica IRepositorioDataMeteorologica.GetDataMeteorologicaId(int idDataMeteorologica)
        {
            var dataMeteorologicaEncontrada =
                _appContext
                    .DataMeteorologica
                    .FirstOrDefault(p =>
                        p.Id == idDataMeteorologica);
            return dataMeteorologicaEncontrada;
        }

        IEnumerable<DataMeteorologica> IRepositorioDataMeteorologica.GetAllDataMeteorologica()
        {
            return _appContext.DataMeteorologica;
        }

        DataMeteorologica IRepositorioDataMeteorologica.DeleteDataMeteorologica(string codigodatameteorologica)
        {
            var datameteorologicaEncontrado =
                _appContext
                    .DataMeteorologica
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == codigodatameteorologica);
            if (datameteorologicaEncontrado != null)
            {
                _appContext.DataMeteorologica.Remove (
                    datameteorologicaEncontrado
                );
                _appContext.SaveChanges();
            }
            return datameteorologicaEncontrado;
        }

        DataMeteorologica IRepositorioDataMeteorologica.DeleteDataMeteorologicaId(int idDataMeteorologica)
        {
            var dataMeteorologicaEncontrada =
                _appContext
                    .DataMeteorologica
                    .FirstOrDefault(p =>
                        p.Id == idDataMeteorologica);
            if (dataMeteorologicaEncontrada != null)
            {
                _appContext.DataMeteorologica.Remove (dataMeteorologicaEncontrada);
                _appContext.SaveChanges();
            }
            return dataMeteorologicaEncontrada;
        }
    }
}