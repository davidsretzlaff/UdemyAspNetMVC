namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenero4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        DataLancamento = c.DateTime(nullable: false),
                        DataAdicionada = c.DateTime(nullable: false),
                        NumeroEstoque = c.Byte(nullable: false),
                        GeneroId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Generoes", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId);
            
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filmes", "GeneroId", "dbo.Generoes");
            DropIndex("dbo.Filmes", new[] { "GeneroId" });
            DropTable("dbo.Generoes");
            DropTable("dbo.Filmes");
        }
    }
}
