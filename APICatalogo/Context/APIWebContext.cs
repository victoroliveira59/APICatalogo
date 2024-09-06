using APICatalogo.Models;

using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class APIWebContext : DbContext
{

    public APIWebContext(DbContextOptions<APIWebContext> options) : base(options)
    {
           
    }

    public DbSet<Categoria>? Categorias { get; set; }    
    public DbSet<Produto>? Produtos { get; set; }    
}
