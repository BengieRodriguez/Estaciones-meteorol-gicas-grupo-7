using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class TipoReporte
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public String Nombre_TipoReporte { get; set; }
        
        public String Estado { get; set; }
    }
}
