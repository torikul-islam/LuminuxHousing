namespace LuminuxHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationInPlotModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plots", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Plots", "Note", c => c.String(nullable: false));
            AlterColumn("dbo.Plots", "OwnerName", c => c.String(nullable: false));
            AlterColumn("dbo.Plots", "OwnerPhone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plots", "OwnerPhone", c => c.String());
            AlterColumn("dbo.Plots", "OwnerName", c => c.String());
            AlterColumn("dbo.Plots", "Note", c => c.String());
            AlterColumn("dbo.Plots", "Name", c => c.String());
        }
    }
}
