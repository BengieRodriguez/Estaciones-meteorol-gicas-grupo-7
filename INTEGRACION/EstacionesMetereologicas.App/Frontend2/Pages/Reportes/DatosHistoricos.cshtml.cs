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
    public class DatosHistoricosModel : PageModel
    {
        [TempData]
        public string codigoestacion{get;set;}
        public string Message { get; set; } = "Initial Request";
        public IRepositorioEstacion _repoEstacion=new RepositorioEstacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Estacion> estacion{ get; set; }
        public IRepositorioPersona _repoPersona=new RepositorioPersona(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Persona> persona{ get; set; }
        public IRepositorioReporte _repoReporte=new RepositorioReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Reporte> reporte{ get; set; }

        public void OnGet()
        {
            estacion = _repoEstacion.GetAllEstaciones();
            persona = _repoPersona.GetAllPersonas();
            reporte = _repoReporte.GetAllReportes();
            codigoestacion="";
        }

        public void OnPost(string codEstacion, string idTecnico, DateTime fechaInicio, DateTime fechaFin, string DescripReporte )
        {
           var reporte = new Reporte();
           reporte.Codigo_Estacion = codEstacion;
           reporte.Ident_persona = idTecnico;
           reporte.FechaInicio = fechaInicio;
           reporte.FechaFin =   fechaFin;
           reporte.Id_TipoReporte=1;
           reporte.Descripcion = DescripReporte;
           reporte.Codigo_actuacion = "0";
           _repoReporte.AddReporte(reporte);
        }

         public IActionResult OnPostConsultarEstacion(string codEstacion)
        {   
        var estacion = new Estacion();           
           string url="";
           if(estacion!=null)
           {
               codEstacion=estacion.Codigo_Estacion;
                url="AddDatMet";          
           }
           else
           {
                codigoestacion="";
                url="";
           }
           return RedirectToPage(url);
        }
    }
}
