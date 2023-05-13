namespace ITLab3_groupA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredValidators : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Hospitals", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Hospitals", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Phone", c => c.String());
            AlterColumn("dbo.Patients", "Surname", c => c.String());
            AlterColumn("dbo.Patients", "Name", c => c.String());
            AlterColumn("dbo.Hospitals", "Address", c => c.String());
            AlterColumn("dbo.Hospitals", "Name", c => c.String());
            AlterColumn("dbo.Doctors", "Phone", c => c.String());
            AlterColumn("dbo.Doctors", "Surname", c => c.String());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
        }
    }
}
