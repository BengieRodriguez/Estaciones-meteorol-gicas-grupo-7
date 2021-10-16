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
    public class NovedadesModel : PageModel
    {
        public IRepositorioNovedades _repoNovedades=new RepositorioNovedades(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Novedades> novedades{ get; set; }
        public void OnGet()
        {       
            novedades = _repoNovedades.GetAllNovedades();
        }
    }
}
