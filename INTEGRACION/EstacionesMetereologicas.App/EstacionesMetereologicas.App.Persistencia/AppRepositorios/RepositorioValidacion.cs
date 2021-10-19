using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionesMetereologicas.App.Dominio;

namespace EstacionesMetereologicas.App.Persistencia
{
    public class RepositorioValidacion:IRepositorioValidacion
    {
        private readonly AppContext _appContext;
        public RepositorioValidacion(AppContext appContext)
        {
            _appContext=appContext;
        }

        
        Validacion IRepositorioValidacion.AddValidacion(Validacion validacion)
        {
            var validacionAdicionada=_appContext.Validaciones.Add(validacion);
            _appContext.SaveChanges();
            return validacionAdicionada.Entity;
        }

        Validacion IRepositorioValidacion.UpdateValidacion(int id,int val)
        {
            var validacionEncontrada=_appContext.Validaciones.FirstOrDefault(p=>  p.Id==id);
            if(validacionEncontrada!=null)
            {
                validacionEncontrada.Val=val;
                 _appContext.SaveChanges();
            }
            return validacionEncontrada;
        }
        
        Validacion IRepositorioValidacion.GetValidacion(int id)
        {
            var validacionEncontrada=_appContext.Validaciones.FirstOrDefault(p=>  p.Id==id);
            return validacionEncontrada;
        }
    }
}