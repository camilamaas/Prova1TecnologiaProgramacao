namespace Prova1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertsAluno : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes values ('Martim Castro Ribeiro','158.778.735-04',1, 4),('Lucas Alves Melo', '916.749.332-74', 4,6),('Breno Castro Carvalho','454.019.800-94', 2, 5),('Laura CardosoRocha','361.089.665-56', 6,7)");
        }
        
        public override void Down()
        {
        }
    }
}
