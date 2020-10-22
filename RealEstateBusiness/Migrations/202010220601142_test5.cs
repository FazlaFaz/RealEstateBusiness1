namespace RealEstateBusiness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owner_tbl",
                c => new
                    {
                        OwnerNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Address = c.String(),
                        TelNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerNo);
            
            CreateTable(
                "dbo.Rent_tbl",
                c => new
                    {
                        PropertyNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        City = c.String(),
                        Ptype = c.String(),
                        Rooms = c.Int(nullable: false),
                        OwnerNoRef = c.String(maxLength: 128),
                        StaffNoRef = c.String(maxLength: 128),
                        BranchNoRef = c.String(maxLength: 128),
                        rent1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyNo)
                .ForeignKey("dbo.Branch_tbl", t => t.BranchNoRef)
                .ForeignKey("dbo.Owner_tbl", t => t.OwnerNoRef)
                .ForeignKey("dbo.Staff_tbl", t => t.StaffNoRef)
                .Index(t => t.OwnerNoRef)
                .Index(t => t.StaffNoRef)
                .Index(t => t.BranchNoRef);
            
            CreateTable(
                "dbo.Staff_tbl",
                c => new
                    {
                        StaffNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Position = c.String(),
                        DOB = c.DateTime(nullable: false, storeType: "date"),
                        Salary = c.Int(nullable: false),
                        BranchNo_BranchNo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StaffNo)
                .ForeignKey("dbo.Branch_tbl", t => t.BranchNo_BranchNo)
                .Index(t => t.BranchNo_BranchNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rent_tbl", "StaffNoRef", "dbo.Staff_tbl");
            DropForeignKey("dbo.Staff_tbl", "BranchNo_BranchNo", "dbo.Branch_tbl");
            DropForeignKey("dbo.Rent_tbl", "OwnerNoRef", "dbo.Owner_tbl");
            DropForeignKey("dbo.Rent_tbl", "BranchNoRef", "dbo.Branch_tbl");
            DropIndex("dbo.Staff_tbl", new[] { "BranchNo_BranchNo" });
            DropIndex("dbo.Rent_tbl", new[] { "BranchNoRef" });
            DropIndex("dbo.Rent_tbl", new[] { "StaffNoRef" });
            DropIndex("dbo.Rent_tbl", new[] { "OwnerNoRef" });
            DropTable("dbo.Staff_tbl");
            DropTable("dbo.Rent_tbl");
            DropTable("dbo.Owner_tbl");
        }
    }
}
