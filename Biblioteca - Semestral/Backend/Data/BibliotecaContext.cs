
using Microsoft.EntityFrameworkCore;
using BibliotecaApi.Models;

namespace BibliotecaApi.Data{
 public class BibliotecaContext:DbContext{
  public BibliotecaContext(DbContextOptions<BibliotecaContext> o):base(o){}
  public DbSet<Libro> Libros{get;set;}
  public DbSet<Prestamo> Prestamos{get;set;}
 }
}
