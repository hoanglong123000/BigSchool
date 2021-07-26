namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Capnhatdulieu : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4, 'Doanh Nghiep Tu Nhan')");
        }
        
        public override void Down()
        {
        }
    }
}
