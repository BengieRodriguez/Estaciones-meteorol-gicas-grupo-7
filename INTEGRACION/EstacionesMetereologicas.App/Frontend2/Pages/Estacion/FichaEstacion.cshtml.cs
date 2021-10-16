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
    public class FichaEstacionModel : PageModel
    {
        public IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Estacion> estacion{ get; set; }
        public void OnGet()
        {       
            estacion = _repoEstacion.GetAllEstaciones();
        }
    }
}
