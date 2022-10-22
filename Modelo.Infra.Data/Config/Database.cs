using Microsoft.EntityFrameworkCore;
using Modelo.Infra.Data.Modelos;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;

namespace Modelo.Infra.Data.Config
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options ) : base( options )
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<UsuarioDTB> Usuario { get; set; }

    }
}