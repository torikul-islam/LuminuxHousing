namespace LuminuxHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePredefineTableWithData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SIZES  VALUES ('3 Katha')"); 
            Sql("INSERT INTO SIZES  VALUES ('5 Katha')"); 
            Sql("INSERT INTO SIZES  VALUES ('7.5 Katha')"); 
            Sql("INSERT INTO SIZES  VALUES ('10 Katha')"); 
               
        }
        
        public override void Down()
        {
        }
    }
}
