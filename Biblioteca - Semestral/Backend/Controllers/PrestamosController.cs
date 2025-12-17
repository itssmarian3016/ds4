
using Microsoft.AspNetCore.Mvc;
using BibliotecaApi.Data;
using BibliotecaApi.Models;

namespace BibliotecaApi.Controllers{
 [ApiController]
 [Route("api/prestamos")]
 public class PrestamosController:ControllerBase{
  private readonly BibliotecaContext _c;
  public PrestamosController(BibliotecaContext c){_c=c;}

  [HttpGet] public IActionResult Get()=>Ok(_c.Prestamos.ToList());

  [HttpPost] public IActionResult Post(Prestamo p){
   _c.Prestamos.Add(p);
   _c.SaveChanges();
   return Ok(p);
  }
 }
}
