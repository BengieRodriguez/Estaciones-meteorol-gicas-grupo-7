using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Reporte
    {
        public int Id { get; set; }

        public int Id_Tipo_Reporte { get; set; }

        public String Nombre_TipoReporte { get; set; }

        public string Descripcion { get; set; }

        public Actividad Id_Actividad { get; set; }
    }
}
