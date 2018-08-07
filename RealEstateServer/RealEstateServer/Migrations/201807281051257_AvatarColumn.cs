namespace RealEstateServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AvatarColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Avatar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Avatar");
        }
    }
}
