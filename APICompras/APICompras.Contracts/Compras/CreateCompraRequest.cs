namespace APICompras.Contracts.Compras;

public record CreateCompraRequest(
    int cliente_id,
    DateTime fecha,
    string metodo_pago,
    string estado
);