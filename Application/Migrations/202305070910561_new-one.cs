namespace Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Money",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(),
                        TransactionTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transaction", t => t.TransactionTypeId, cascadeDelete: true)
                .Index(t => t.TransactionTypeId);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Detail = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.User", "Mobile", c => c.String());
            AddColumn("dbo.User", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Address", c => c.String());
            AddColumn("dbo.User", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.User", "RoleId");
            AddForeignKey("dbo.User", "RoleId", "dbo.Role", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Money", "TransactionTypeId", "dbo.Transaction");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropIndex("dbo.Money", new[] { "TransactionTypeId" });
            DropIndex("dbo.User", new[] { "RoleId" });
            DropColumn("dbo.User", "RoleId");
            DropColumn("dbo.User", "Address");
            DropColumn("dbo.User", "BirthDate");
            DropColumn("dbo.User", "Mobile");
            DropTable("dbo.Event");
            DropTable("dbo.Transaction");
            DropTable("dbo.Money");
            DropTable("dbo.Role");
        }
    }
}
