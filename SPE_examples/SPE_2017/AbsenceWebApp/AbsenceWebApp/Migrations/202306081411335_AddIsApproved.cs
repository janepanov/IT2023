namespace AbsenceWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsApproved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Absences", "isApproved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Absences", "isApproved");
        }
    }
}
