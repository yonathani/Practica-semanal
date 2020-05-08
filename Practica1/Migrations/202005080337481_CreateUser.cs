namespace Practica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tasks", "User_Id", c => c.Int());
            CreateIndex("dbo.Tasks", "User_Id");
            AddForeignKey("dbo.Tasks", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Tasks", "User");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "User", c => c.String());
            DropForeignKey("dbo.Tasks", "User_Id", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "User_Id" });
            DropColumn("dbo.Tasks", "User_Id");
            DropTable("dbo.Users");
        }
    }
}
