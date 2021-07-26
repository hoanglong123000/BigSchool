namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chinhsuathuoctinh : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (5, 'Nha Mang')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (6, 'Dich vu')");
        }
        
        public override void Down()
        {
        }
    }
}
