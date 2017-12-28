namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNomeTipoMembro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TipoMembroes", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoMembroes", "Nome");
        }
    }
}
