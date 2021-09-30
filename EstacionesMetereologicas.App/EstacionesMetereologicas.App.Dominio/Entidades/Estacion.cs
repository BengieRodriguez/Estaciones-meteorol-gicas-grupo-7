using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Estacion
    {
        public int Id { get; set; }

        public string Codigo_Estacion { get; set; }

        public int Latitud { get; set; }

        public int Longitud { get; set; }

        public string Municipio { get; set; }

        public DateTime Fecha_Montaje { get; set; }
    }
}
