namespace vcef01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLike01 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Likes", "UserId", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Likes", "UserId", c => c.Byte(nullable: false));
        }
    }
}
