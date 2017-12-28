namespace learnaspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenero : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Generoes (Id, Nome) VALUES (1, 'Ação')");
            Sql("INSERT INTO Generoes (Id, Nome) VALUES (2, 'Suspense')");
            Sql("INSERT INTO Generoes (Id, Nome) VALUES (3, 'Familia')");
            Sql("INSERT INTO Generoes (Id, Nome) VALUES (4, 'Romance')");
            Sql("INSERT INTO Generoes (Id, Nome) VALUES (5, 'Comedia')");
        }
        
        public override void Down()
        {
        }
    }
}
