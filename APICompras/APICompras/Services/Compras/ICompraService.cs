using APICompras.Contracts.Compras;
using APICompras.Models;

namespace APICompras.Services.Compras;

public interface ICompraService{
    void CreateCompra(Compra compra);

    // CompraResponse GetCompra(int compraId);
    // CompraResponse UpdateCompra(int compraId, CreateCompraRequest request);
    // CompraResponse DeleteCompra(int compraId);
}