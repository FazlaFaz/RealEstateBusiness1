namespace RealEstateBusiness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Staff_tbl", name: "BranchNo_BranchNo", newName: "BranchNoRef");
            RenameIndex(table: "dbo.Staff_tbl", name: "IX_BranchNo_BranchNo", newName: "IX_BranchNoRef");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Staff_tbl", name: "IX_BranchNoRef", newName: "IX_BranchNo_BranchNo");
            RenameColumn(table: "dbo.Staff_tbl", name: "BranchNoRef", newName: "BranchNo_BranchNo");
        }
    }
}
