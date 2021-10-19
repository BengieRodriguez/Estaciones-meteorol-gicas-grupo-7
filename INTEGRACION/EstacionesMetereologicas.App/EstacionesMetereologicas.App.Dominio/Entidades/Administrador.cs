using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Dominio
{
    public class Administrador:Persona
    {
        public int Password{get;set;}
        public string Rol{get;set;}
    }
}