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
    public class MantenimientosTecnicoModel : PageModel
    {
        public IRepositorioReporte _repoReporte=new RepositorioReporte(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Reporte> reporte{ get; set; }
        public IRepositorioActuacion _repoActuacion=new RepositorioActuacion(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Actuacion> actuacion{ get; set; }
        public IRepositorioPersona _repoPersona=new RepositorioPersona(new EstacionesMetereologicas.App.Persistencia.AppContext());
        public IEnumerable<Persona> persona{ get; set; }

        public void OnGet()
        {
            actuacion = _repoActuacion.GetAllActuaciones();
            persona = _repoPersona.GetAllPersonas();
            reporte = _repoReporte.GetAllReportes();
        }

         public void OnPost(string idActuacion, string idTecnico, DateTime fechaInicio, DateTime fechaFin, string DescripReporte )
        {
           var reporte = new Reporte();
           reporte.Codigo_actuacion = idActuacion;
           reporte.Ident_persona = idTecnico;
           reporte.FechaInicio = fechaInicio;
           reporte.FechaFin =   fechaFin;
           reporte.Id_TipoReporte=2;
           reporte.Descripcion = DescripReporte;
           reporte.Codigo_Estacion = null;
           _repoReporte.AddReporte(reporte);           
        }
    }
}
