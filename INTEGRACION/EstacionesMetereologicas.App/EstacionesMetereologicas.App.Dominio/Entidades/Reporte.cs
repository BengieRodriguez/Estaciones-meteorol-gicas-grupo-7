using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Reporte
    {
        public int Id { get; set; }        

        public int Id_TipoReporte { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; } 

        public DateTime FechaFin { get; set; } 

        public string Codigo_Estacion { get; set; }

        public string Ident_persona { get; set; }

        public string Codigo_actuacion { get; set; }
    }
}
