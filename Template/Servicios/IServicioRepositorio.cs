using Dominio.Entidades;
using System.Collections.Generic;
using System.ServiceModel;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioRepositorio" in both code and config file together.
    [ServiceContract]
    public interface IServicioRepositorio
    {
        [OperationContract]
        bool InsertarEntidadDePruebas(EntidadDePrueba entidad);

        [OperationContract]
        IList<EntidadDePrueba> ListarEntidadDePruebas();

        [OperationContract]
        void BorrarEntidadDePrueba(int id);
    }
}
