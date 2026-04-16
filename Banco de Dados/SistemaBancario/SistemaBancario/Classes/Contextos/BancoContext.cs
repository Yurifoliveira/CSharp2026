using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contextos
{
    internal class BancoContext : DbContext
    {
        //propriedades
        /// <summary>
        /// Representa a tabela de contas bancarios no banco de dados
        /// db7 permite realizar operações CRUD
        /// </summary>
        public DbSet<Banco> Contas { get; set; }

        //metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BancoDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NumeroConta).IsRequired();
                entity.Property(e => e.Titular).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Saldo).HasColumnType("decimal(18,2)");
            }

                );
        }
    }
}
