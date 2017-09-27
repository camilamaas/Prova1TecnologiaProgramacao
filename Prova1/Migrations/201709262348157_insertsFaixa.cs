namespace Prova1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class insertsFaixa : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faixas values('Branca', '6k'),('Amarela', '5k'),('Roxa', '4k'),('Verde', '3k'),('Azul', '2k'),('Marrom', '1k'),('Preta', '1d')");
        }

        public override void Down()
        {
        }
    }
}
