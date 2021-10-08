using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionesMetereologicas.App.Dominio
{
    public class DataMeteorologica
    {
         public int Id { get; set; }

        public string Codigo_Estacion { get; set; }

        public string Nombre_Estacion { get; set; }

        public DateTime Fecha { get; set; }

        public string Temperatura { get; set; }

        public string Humedad { get; set; }

        public string Presion_Atmosferica { get; set; }

        public string Velocidad_Viento { get; set; }

        public string Pluviosidad { get; set; }

        public string Radiacion_Solar { get; set; }
    }
}