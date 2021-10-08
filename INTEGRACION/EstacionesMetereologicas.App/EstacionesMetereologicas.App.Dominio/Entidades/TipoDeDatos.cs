using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionesMetereologicas.App.Dominio
{
    public class TipoDeDatos
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }
    }
}