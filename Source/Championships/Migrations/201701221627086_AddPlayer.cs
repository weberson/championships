namespace Championships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlayer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TbPlayer",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TbPlayer");
        }
    }
}
