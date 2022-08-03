namespace APICompras.Contracts.Compras;

public record UpsertCompraRequest(
    int cliente_id,
    DateTime fecha,
    string metodo_pago,
    string estado
);