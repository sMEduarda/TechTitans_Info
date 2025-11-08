using System.Data.Entity;
using TechTitans_Info.Models;

namespace TechTitans_Info.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }

        public DbSet<OrdemServico> OrdensServico { get; set; }
        public DbSet<Material> Materiais { get; set; }
        public DbSet<TipoEquipamento> TiposEquipamento { get; set; }
        public DbSet<StatusOS> StatusOS { get; set; }
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<ItemOrdemServico> ItensOrdemServico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Apenas mapeamento de tabelas
            modelBuilder.Entity<OrdemServico>().ToTable("OrdensServico");
            modelBuilder.Entity<Material>().ToTable("Materiais");
            modelBuilder.Entity<ItemOrdemServico>().ToTable("ItensOrdemServico");
            modelBuilder.Entity<TipoEquipamento>().ToTable("TiposEquipamento");
            modelBuilder.Entity<StatusOS>().ToTable("StatusOS");
            modelBuilder.Entity<Prioridade>().ToTable("Prioridades");

            base.OnModelCreating(modelBuilder);
        }
    }
}