namespace TechTitans_Info.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItensOrdemServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrdemServicoId = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                        QuantidadeUsada = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materiais", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.OrdensServico", t => t.OrdemServicoId, cascadeDelete: true)
                .Index(t => t.OrdemServicoId)
                .Index(t => t.MaterialId);
            
            CreateTable(
                "dbo.Materiais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Tipo = c.String(),
                        Descricao = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantidadeDisponivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrdensServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Solicitante = c.String(),
                        Responsavel = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        TipoEquipamentoId = c.Int(nullable: false),
                        Marca = c.String(),
                        Serie = c.String(),
                        DataAbertura = c.DateTime(nullable: false),
                        DescricaoProblema = c.String(),
                        PrioridadeId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prioridades", t => t.PrioridadeId, cascadeDelete: true)
                .ForeignKey("dbo.StatusOS", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.TiposEquipamento", t => t.TipoEquipamentoId, cascadeDelete: true)
                .Index(t => t.TipoEquipamentoId)
                .Index(t => t.PrioridadeId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Prioridades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TiposEquipamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdensServico", "TipoEquipamentoId", "dbo.TiposEquipamento");
            DropForeignKey("dbo.OrdensServico", "StatusId", "dbo.StatusOS");
            DropForeignKey("dbo.OrdensServico", "PrioridadeId", "dbo.Prioridades");
            DropForeignKey("dbo.ItensOrdemServico", "OrdemServicoId", "dbo.OrdensServico");
            DropForeignKey("dbo.ItensOrdemServico", "MaterialId", "dbo.Materiais");
            DropIndex("dbo.OrdensServico", new[] { "StatusId" });
            DropIndex("dbo.OrdensServico", new[] { "PrioridadeId" });
            DropIndex("dbo.OrdensServico", new[] { "TipoEquipamentoId" });
            DropIndex("dbo.ItensOrdemServico", new[] { "MaterialId" });
            DropIndex("dbo.ItensOrdemServico", new[] { "OrdemServicoId" });
            DropTable("dbo.TiposEquipamento");
            DropTable("dbo.StatusOS");
            DropTable("dbo.Prioridades");
            DropTable("dbo.OrdensServico");
            DropTable("dbo.Materiais");
            DropTable("dbo.ItensOrdemServico");
        }
    }
}
