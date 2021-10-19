using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EstacionesMetereologicas.App.Persistencia;
using EstacionesMetereologicas.App.Dominio;

namespace FrontEnd2.Pages
{
    public class UsuariosModel : PageModel
    {
        public static IRepositorioValidacion _repoValidacion=new RepositorioValidacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IRepositorioPersona _repoPersona=new RepositorioPersona(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Persona> persona{ get; set; }
        public void OnGet()
        {       
            
            persona = _repoPersona.GetAllPersonas();
            
        }
    }
}
