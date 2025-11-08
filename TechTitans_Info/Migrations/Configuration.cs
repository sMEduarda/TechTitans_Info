using System.Collections.Generic;
using TechTitans_Info.Models;

namespace TechTitans_Info.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTitans_Info.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechTitans_Info.Data.AppDbContext context)
        {
            // FORÇA A INSERÇÃO MESMO QUE JÁ EXISTA
            if (!context.TiposEquipamento.Any())
            {
                context.TiposEquipamento.AddRange(new[]
                {
                    new TipoEquipamento { Id = 1, Nome = "Impressora" },
                    new TipoEquipamento { Id = 2, Nome = "Notebook" },
                    new TipoEquipamento { Id = 3, Nome = "Desktop" },
                    new TipoEquipamento { Id = 4, Nome = "Tablet" },
                    new TipoEquipamento { Id = 5, Nome = "Celular" },
                    new TipoEquipamento { Id = 6, Nome = "Outros" }
                });
            }

            if (!context.Prioridades.Any())
            {
                context.Prioridades.AddRange(new[]
                {
                    new Prioridade { Id = 1, Nome = "Baixa" },
                    new Prioridade { Id = 2, Nome = "Normal" },
                    new Prioridade { Id = 3, Nome = "Alta" }
                });
            }

            if (!context.StatusOS.Any())
            {
                context.StatusOS.AddRange(new[]
                {
                    new StatusOS { Id = 1, Nome = "Aberto" },
                    new StatusOS { Id = 2, Nome = "Em Curso" },
                    new StatusOS { Id = 3, Nome = "Fechado" }
                });
            }

            context.SaveChanges();
        }
    }
}