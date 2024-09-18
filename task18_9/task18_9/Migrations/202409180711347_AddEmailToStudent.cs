namespace task18_9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
        }
    }
}
