namespace vcef01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLike : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShopId = c.Byte(nullable: false),
                        UserId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Likes");
        }
    }
}
