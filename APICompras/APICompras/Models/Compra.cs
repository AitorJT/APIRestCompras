namespace APICompras.Models;

public class Compra{
    public int compraId {get;}
    public int clienteId {get;}
    public DateTime fecha {get;}
    public string metodoPago {get;}
    public string estado {get;}

    public Compra(int compraId, int clienteId, DateTime fecha, string metodoPago, string estado){

        //TODO validaciones
        this.compraId = compraId;
        this.clienteId = clienteId;
        this.fecha = fecha;
        this.metodoPago = metodoPago;
        this.estado = estado;
    }




}