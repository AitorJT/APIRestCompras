namespace APICompras.Contracts.Compras;

public record CompraResponse(
    int compra_id,
    int cliente_id,
    DateTime fecha,
    string metodo_pago,
    string estado
);