namespace PictureAnalyzer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Painters", "BirthDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Painters", "PassDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Painters", "PassDate", c => c.DateTime());
            AlterColumn("dbo.Painters", "BirthDate", c => c.DateTime());
        }
    }
}
