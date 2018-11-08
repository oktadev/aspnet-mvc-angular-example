namespace OktaAspNetMvcAngular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JoggingRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Distance = c.Single(nullable: false),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JoggingRecords");
        }
    }
}
