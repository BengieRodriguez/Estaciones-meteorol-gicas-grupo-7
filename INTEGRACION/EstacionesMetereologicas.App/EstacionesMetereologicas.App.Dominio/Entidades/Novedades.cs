using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Novedades
    {
        public int Id { get; set; }

        public string Codigo_Estacion { get; set; }

        public DateTime Fecha_Novedad { get; set; }

        public string Actuacion { get; set; }

        public string Observacion { get; set; }
    }
}