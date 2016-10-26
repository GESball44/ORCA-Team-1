namespace ORCA_Team_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experts",
                c => new
                    {
                        userId = c.String(nullable: false, maxLength: 128),
                        JobTitle = c.String(nullable: false),
                        Field = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.userId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Zip = c.String(),
                        Organization = c.String(nullable: false),
                        UserType = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        CreateDate = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Experts");
        }
    }
}
