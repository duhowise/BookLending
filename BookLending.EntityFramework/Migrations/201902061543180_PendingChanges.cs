namespace BookLending.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class PendingChanges : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Categories", new[] { "IsDeleted" });
            AlterTableAnnotations(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(maxLength: 64),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Category_SoftDelete",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
            DropColumn("dbo.Categories", "IsDeleted");
            DropColumn("dbo.Categories", "DeleterUserId");
            DropColumn("dbo.Categories", "DeletionTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "DeletionTime", c => c.DateTime());
            AddColumn("dbo.Categories", "DeleterUserId", c => c.Long());
            AddColumn("dbo.Categories", "IsDeleted", c => c.Boolean(nullable: false));
            AlterTableAnnotations(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(maxLength: 64),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Category_SoftDelete",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            CreateIndex("dbo.Categories", "IsDeleted");
        }
    }
}
