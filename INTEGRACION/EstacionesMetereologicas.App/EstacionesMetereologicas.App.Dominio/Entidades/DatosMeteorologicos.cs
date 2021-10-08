using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class DatosMeteorologicos
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public DateTime FechaDato { get; set; }

        public float Valor { get; set; }

        public int id_TipoDato { get; set; }

        public int id_Estacion { get; set; }

        public TipoDato TipoDato { get; set; }
    }
}
