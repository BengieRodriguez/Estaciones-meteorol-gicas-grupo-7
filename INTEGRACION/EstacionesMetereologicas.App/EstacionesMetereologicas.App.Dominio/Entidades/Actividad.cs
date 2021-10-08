using System;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Actividad
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public Estacion Id_Estacion { get; set; }

        public Persona Id_persona { get; set; }
        
        public DateTime Fecha { get; set; }
        
        public Actuacion Id_Actuacion { get; set; }
    }
}