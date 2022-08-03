using APICompras.Contracts.Compras;
using Microsoft.AspNetCore.Mvc;

namespace APICompras.Controllers;

[ApiController]
public class CompraController : ControllerBase{
    
    [HttpPost("/compras")]
    public IActionResult CreateCompra(CreateCompraRequest request){
        return Ok(request);
    }

    [HttpGet("/compras/{compraId:int}")]
    public IActionResult GetCompra(int compraId){
        return Ok(compraId);
    }

    [HttpPut("/compras/{id:guid}")]
    public IActionResult UpsertCompra(UpsertCompraRequest request, int compraId){
        return Ok(request);
    }

    [HttpDelete("/compras/{id:guid}")]
    public IActionResult DeleteCompra(int compraId){
        return Ok(compraId);
    }
}
