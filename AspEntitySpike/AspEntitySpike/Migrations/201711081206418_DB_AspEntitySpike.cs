namespace AspEntitySpike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_AspEntitySpike : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Stock = c.Int(nullable: false),
                        ISBN = c.String(),
                        Title = c.String(),
                        Author = c.String(),
                        Library_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Libraries", t => t.Library_Id)
                .Index(t => t.Library_Id);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Book_Id = c.Int(),
                        Loaner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Loaners", t => t.Loaner_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Loaner_Id);
            
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Loaners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loans", "Loaner_Id", "dbo.Loaners");
            DropForeignKey("dbo.Books", "Library_Id", "dbo.Libraries");
            DropForeignKey("dbo.Loans", "Book_Id", "dbo.Books");
            DropIndex("dbo.Loans", new[] { "Loaner_Id" });
            DropIndex("dbo.Loans", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "Library_Id" });
            DropTable("dbo.Loaners");
            DropTable("dbo.Libraries");
            DropTable("dbo.Loans");
            DropTable("dbo.Books");
        }
    }
}
