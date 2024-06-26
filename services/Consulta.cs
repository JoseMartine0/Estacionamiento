using system;
using system.ServiceModel;

namespace EstacionamientoService{

    [ServiceContract]
    public interface Consulta{

        [OperationContract]
        int ConsultarLugaresDisponibles();

        [OperationContract]
        void AgregarLugaresDisponibles(int cantidad);

        [OperationContract]
        void EliminarLugares(int cantidad);


    }
}