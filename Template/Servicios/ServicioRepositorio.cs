using Dominio.Entidades;
using Repositorio;
using System.Collections.Generic;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioRepositorio" in both code and config file together.
    public class ServicioRepositorio : IServicioRepositorio
    {
        private readonly IRepositorio repositorio;
        public ServicioRepositorio(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public bool InsertarEntidadDePruebas(EntidadDePrueba entidad)
        {
            if (repositorio.Existe<EntidadDePrueba>(x => x.Usuario == entidad.Usuario)) 
            {
                return false;
            }
            repositorio.Agregar(entidad);
            repositorio.GuardarCambios();
            return true;
        }

        public IList<EntidadDePrueba> ListarEntidadDePruebas()
        {
            return repositorio.Listar<EntidadDePrueba>(x => true);
        }
        
        public void BorrarEntidadDePrueba(int id)
        {
            var j = repositorio.Obtener<EntidadDePrueba>(x => x.Id == id);
            repositorio.Remover(j);
            repositorio.GuardarCambios();
        }
    }
}
