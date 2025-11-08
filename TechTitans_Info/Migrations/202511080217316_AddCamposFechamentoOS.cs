namespace TechTitans_Info.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCamposFechamentoOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrdensServico", "ValorMaoDeObra", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.OrdensServico", "ValorTotalPecas", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.OrdensServico", "ValorTotal", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.OrdensServico", "DataFechamento", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrdensServico", "DataFechamento");
            DropColumn("dbo.OrdensServico", "ValorTotal");
            DropColumn("dbo.OrdensServico", "ValorTotalPecas");
            DropColumn("dbo.OrdensServico", "ValorMaoDeObra");
        }
    }
}
