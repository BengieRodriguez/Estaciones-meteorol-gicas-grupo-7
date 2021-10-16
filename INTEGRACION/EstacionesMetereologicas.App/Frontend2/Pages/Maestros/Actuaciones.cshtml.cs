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
    public class ActuacionesModel : PageModel
    {
        public IRepositorioActuacion _repoActuacion=new RepositorioActuacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Actuacion> actuacion{ get; set; }
        public void OnGet()
        {       
            actuacion = _repoActuacion.GetAllActuaciones();
        }
    }
}
