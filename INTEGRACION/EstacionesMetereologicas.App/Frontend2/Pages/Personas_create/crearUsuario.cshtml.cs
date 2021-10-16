using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstacionesMetereologicas.App.Dominio;
using EstacionesMetereologicas.App.Persistencia;

namespace FrontEnd2.Pages
{
    public class crearUsuarioModel : PageModel
    {
        public static IRepositorioPersona _repoPersona=new RepositorioPersona(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string CodePersona,string NamePersona,string LastNamePersona, string GeneroPersona, string CargoPersona, string EmailPersona, string ContraseniaPersona)
        {
            var persona=new Persona();
            persona.Identificacion=CodePersona;
            persona.Nombres=NamePersona;
            persona.Apellidos=LastNamePersona;
            persona.Genero=GeneroPersona;
            persona.Id_Cargo=CargoPersona;
            persona.Email=EmailPersona;
            persona.Contrasenia=ContraseniaPersona;
            _repoPersona.AddPersona(persona);
        }
    }
}
