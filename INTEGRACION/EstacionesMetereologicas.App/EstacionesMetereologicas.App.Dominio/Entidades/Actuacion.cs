using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Actuacion
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }
    }
}
