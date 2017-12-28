namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Inscrito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
