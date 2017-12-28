namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class apliannotationnacliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
        }
    }
}
