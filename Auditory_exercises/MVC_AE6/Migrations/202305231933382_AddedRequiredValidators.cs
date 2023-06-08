namespace MVC_AE6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredValidators : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Artists", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Stores", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stores", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Artists", "Name", c => c.String());
            AlterColumn("dbo.Albums", "Title", c => c.String());
        }
    }
}
