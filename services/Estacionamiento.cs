using system;
using consulta;

public class Estacionamiento : Consulta{

    private int totalLugares = 80;

    public int ConsultarLugaresDisponibles(){
        return totalLugares;
    }

    public void AgregarLugares(int cantidad){

        if (cantidad > 0){
            totalLugares += cantidad;
        }
        else{
            throw now ArgumentException("Cantidad tiene que ser más de cero")
        }
    }
}

public void EliminarLugares(int cantidad){
    if (cantidad > 0 && totalLugares >= cantidad){
        totalLugares -= cantidad;
    }
    else{
        throw now ArgumentException("No se puede eliminar esa cantidad")
    }
}