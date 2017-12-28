namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTipoMembro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoMembroes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        TaxaInscricao = c.Short(nullable: false),
                        DuracaoMeses = c.Byte(nullable: false),
                        TaxaDesconto = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clientes", "TipoMembroId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clientes", "TipoMembroId");
            AddForeignKey("dbo.Clientes", "TipoMembroId", "dbo.TipoMembroes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "TipoMembroId", "dbo.TipoMembroes");
            DropIndex("dbo.Clientes", new[] { "TipoMembroId" });
            DropColumn("dbo.Clientes", "TipoMembroId");
            DropTable("dbo.TipoMembroes");
        }
    }
}
