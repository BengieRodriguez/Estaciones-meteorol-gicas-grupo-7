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
    public class IngNuevaActModel : PageModel
    {
        public static IRepositorioActuacion _repoActuacion=new RepositorioActuacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(string NumActuacion,string DescripActuacion,string EstActuacion)
        {
            var actuacion = new Actuacion();
            actuacion.Codigo=NumActuacion;
            actuacion.Descripcion=DescripActuacion;
            actuacion.Estado=EstActuacion;
            _repoActuacion.AddActuacion(actuacion);
        }
    }
}
