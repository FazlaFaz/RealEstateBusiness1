namespace RealEstateBusiness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Owner_tbl", "TelNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Owner_tbl", "TelNo", c => c.Int(nullable: false));
        }
    }
}
