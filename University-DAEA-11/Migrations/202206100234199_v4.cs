namespace University_DAEA_11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OfficeAssignments", "IsActive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeAssignments", "IsActive");
        }
    }
}
