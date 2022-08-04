using APICompras.Contracts.Compras;
using Microsoft.AspNetCore.Mvc;

namespace APICompras.Controllers;

[ApiController]
[Route("[controller]")]
public class CompraController : ControllerBase{

    [HttpPost()]
    public IActionResult CreateCompra(CreateCompraRequest request){

        
        return Ok(request);
    }

    [HttpGet("{compraId:int}")]
    public IActionResult GetCompra(int compraId){
        return Ok(compraId);
    }

    [HttpPut("{compraId:int}")]
    public IActionResult UpsertCompra(UpsertCompraRequest request, int compraId){
        return Ok(request);
    }

    [HttpDelete("{compraId:int}")]
    public IActionResult DeleteCompra(int compraId){
        return Ok(compraId);
    }
}
