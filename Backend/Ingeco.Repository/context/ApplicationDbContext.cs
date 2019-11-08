using Ingeco.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ingeco.Repository.context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CostoGasto> CostosGastos { get; set; }
        public DbSet<Descuento> Descuentos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}