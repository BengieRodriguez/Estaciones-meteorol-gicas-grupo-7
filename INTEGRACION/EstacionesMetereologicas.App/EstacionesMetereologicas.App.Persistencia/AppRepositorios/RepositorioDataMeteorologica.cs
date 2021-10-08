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
            var datameteorologicaAdicionado = _appContext.DataMeteorologica.Add(datameteorologica);
            _appContext.SaveChanges();
            return datameteorologicaAdicionado.Entity;
        }

        DataMeteorologica IRepositorioDataMeteorologica.UpdateDataMeteorologica(DataMeteorologica datameteorologica)
        {
            var datameteorologicaEncontrado =
                _appContext
                    .DataMeteorologica
                    .FirstOrDefault(p =>
                        p.Codigo_Estacion == datameteorologica.Codigo_Estacion);
            if (datameteorologicaEncontrado != null)
            {
                datameteorologica.Codigo_Estacion = datameteorologica.Codigo_Estacion;
                datameteorologica.Nombre_Estacion = datameteorologica.Nombre_Estacion;
                datameteorologica.Fecha = datameteorologica.Fecha;
                datameteorologica.Temperatura = datameteorologica.Temperatura;
                datameteorologica.Humedad = datameteorologica.Humedad;
                datameteorologica.Presion_Atmosferica = datameteorologica.Presion_Atmosferica;
                datameteorologica.Velocidad_Viento = datameteorologica.Velocidad_Viento;
                datameteorologica.Pluviosidad = datameteorologica.Pluviosidad;
                datameteorologica.Radiacion_Solar = datameteorologica.Radiacion_Solar;
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
                _appContext.DataMeteorologica.Remove (datameteorologicaEncontrado);
                _appContext.SaveChanges();
            }
            return datameteorologicaEncontrado;
        }
    }
}