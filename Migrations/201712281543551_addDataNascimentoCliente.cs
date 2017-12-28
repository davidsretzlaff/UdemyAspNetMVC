namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataNascimentoCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "DataNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "DataNascimento");
        }
    }
}
