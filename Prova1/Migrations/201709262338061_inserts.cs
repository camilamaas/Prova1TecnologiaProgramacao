namespace Prova1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inserts : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO TipoDeAssociacaos values ('Mensal',1,140),('Trimestral',3,400),('Semestral',6,600),('Anual',12,1400)");
        }
        
        public override void Down()
        {
        }
    }
}
