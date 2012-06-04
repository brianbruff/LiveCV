namespace LiveCV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        ResumeId = c.Int(nullable: false, identity: true),
                        PersonalDetails_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResumeId)
                .ForeignKey("dbo.PersonalDetails", t => t.PersonalDetails_ID, cascadeDelete: true)
                .Index(t => t.PersonalDetails_ID);
            
            CreateTable(
                "dbo.PersonalDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResumeId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 4000),
                        LastName = c.String(nullable: false, maxLength: 4000),
                        Address1 = c.String(nullable: false, maxLength: 4000),
                        Address2 = c.String(nullable: false, maxLength: 4000),
                        Address3 = c.String(nullable: false, maxLength: 4000),
                        Address4 = c.String(nullable: false, maxLength: 4000),
                        Address5 = c.String(maxLength: 4000),
                        Dob = c.DateTime(nullable: false),
                        Nationality = c.String(nullable: false, maxLength: 4000),
                        PhoneNumber = c.String(nullable: false, maxLength: 4000),
                        EmailAddress = c.String(nullable: false, maxLength: 4000),
                        Website = c.String(nullable: false, maxLength: 4000),
                        QualificationSummary = c.String(maxLength: 4000),
                        Notes = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EducationDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Website = c.String(maxLength: 4000),
                        Qualification = c.String(maxLength: 4000),
                        Notes = c.String(maxLength: 4000),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Resume_ResumeId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resumes", t => t.Resume_ResumeId)
                .Index(t => t.Resume_ResumeId);
            
            CreateTable(
                "dbo.TechCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        EducationDetails_ID = c.Int(),
                        Resume_ResumeId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EducationDetails", t => t.EducationDetails_ID)
                .ForeignKey("dbo.Resumes", t => t.Resume_ResumeId)
                .Index(t => t.EducationDetails_ID)
                .Index(t => t.Resume_ResumeId);
            
            CreateTable(
                "dbo.Technologies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        Notes = c.String(maxLength: 4000),
                        Stats_ID = c.Int(),
                        TechCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TechnologyStats", t => t.Stats_ID)
                .ForeignKey("dbo.TechCategories", t => t.TechCategory_ID)
                .Index(t => t.Stats_ID)
                .Index(t => t.TechCategory_ID);
            
            CreateTable(
                "dbo.TechnologyStats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Competency = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WorkItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        TechnologyStats_ID = c.Int(),
                        WorkDetails_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TechnologyStats", t => t.TechnologyStats_ID)
                .ForeignKey("dbo.WorkDetails", t => t.WorkDetails_ID)
                .Index(t => t.TechnologyStats_ID)
                .Index(t => t.WorkDetails_ID);
            
            CreateTable(
                "dbo.WorkDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Location = c.String(maxLength: 4000),
                        Title = c.String(maxLength: 4000),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(),
                        CompanyDescription = c.String(maxLength: 4000),
                        Description = c.String(),
                        Technologies = c.String(),
                        Resume_ResumeId = c.Int(),
                        Resume_ResumeId1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resumes", t => t.Resume_ResumeId)
                .ForeignKey("dbo.Resumes", t => t.Resume_ResumeId1)
                .Index(t => t.Resume_ResumeId)
                .Index(t => t.Resume_ResumeId1);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Resume_ResumeId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resumes", t => t.Resume_ResumeId)
                .Index(t => t.Resume_ResumeId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Books", new[] { "Resume_ResumeId" });
            DropIndex("dbo.WorkDetails", new[] { "Resume_ResumeId1" });
            DropIndex("dbo.WorkDetails", new[] { "Resume_ResumeId" });
            DropIndex("dbo.WorkItems", new[] { "WorkDetails_ID" });
            DropIndex("dbo.WorkItems", new[] { "TechnologyStats_ID" });
            DropIndex("dbo.Technologies", new[] { "TechCategory_ID" });
            DropIndex("dbo.Technologies", new[] { "Stats_ID" });
            DropIndex("dbo.TechCategories", new[] { "Resume_ResumeId" });
            DropIndex("dbo.TechCategories", new[] { "EducationDetails_ID" });
            DropIndex("dbo.EducationDetails", new[] { "Resume_ResumeId" });
            DropIndex("dbo.Resumes", new[] { "PersonalDetails_ID" });
            DropForeignKey("dbo.Books", "Resume_ResumeId", "dbo.Resumes");
            DropForeignKey("dbo.WorkDetails", "Resume_ResumeId1", "dbo.Resumes");
            DropForeignKey("dbo.WorkDetails", "Resume_ResumeId", "dbo.Resumes");
            DropForeignKey("dbo.WorkItems", "WorkDetails_ID", "dbo.WorkDetails");
            DropForeignKey("dbo.WorkItems", "TechnologyStats_ID", "dbo.TechnologyStats");
            DropForeignKey("dbo.Technologies", "TechCategory_ID", "dbo.TechCategories");
            DropForeignKey("dbo.Technologies", "Stats_ID", "dbo.TechnologyStats");
            DropForeignKey("dbo.TechCategories", "Resume_ResumeId", "dbo.Resumes");
            DropForeignKey("dbo.TechCategories", "EducationDetails_ID", "dbo.EducationDetails");
            DropForeignKey("dbo.EducationDetails", "Resume_ResumeId", "dbo.Resumes");
            DropForeignKey("dbo.Resumes", "PersonalDetails_ID", "dbo.PersonalDetails");
            DropTable("dbo.Books");
            DropTable("dbo.WorkDetails");
            DropTable("dbo.WorkItems");
            DropTable("dbo.TechnologyStats");
            DropTable("dbo.Technologies");
            DropTable("dbo.TechCategories");
            DropTable("dbo.EducationDetails");
            DropTable("dbo.PersonalDetails");
            DropTable("dbo.Resumes");
        }
    }
}
