using System.ComponentModel.DataAnnotations;

namespace APICompras.Models;

public class Compra{
    [Key]
    public int compra_id {get;set;}
    public int cliente_id {get;set;}
    public DateTime fecha {get;set;}
    public string metodo_pago {get;set;}
    public string estado {get;set;}






}