using Microsoft.EntityFrameworkCore;
namespace eCommerceAPI.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options)
        : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }

    }
}
