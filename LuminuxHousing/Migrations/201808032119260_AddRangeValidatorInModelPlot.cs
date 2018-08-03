namespace LuminuxHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRangeValidatorInModelPlot : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plots", "Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plots", "Name", c => c.String(nullable: false));
        }
    }
}
