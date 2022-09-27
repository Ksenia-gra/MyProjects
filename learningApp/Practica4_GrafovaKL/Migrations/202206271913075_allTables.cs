namespace Practica4_GrafovaKL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnswerText = c.String(maxLength: 2147483647),
                        isRight = c.Boolean(nullable: false),
                        IdQuestion = c.Int(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id, name: "IX_Answer_Question_Id");
            
            CreateTable(
                "dbo.Progresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        TeoryProgress = c.String(maxLength: 2147483647),
                        PracticeProgress = c.String(maxLength: 2147483647),
                        TestProgress = c.String(maxLength: 2147483647),
                        user_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.user_Id)
                .Index(t => t.user_Id, name: "IX_Progress_user_Id");
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(maxLength: 2147483647),
                        QuestionType = c.Int(nullable: false),
                        IdTeory = c.Int(nullable: false),
                        Teory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teories", t => t.Teory_Id)
                .Index(t => t.Teory_Id, name: "IX_Question_Teory_Id");
            
            CreateTable(
                "dbo.Teories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 2147483647),
                        Path = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Teory_Id", "dbo.Teories");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Progresses", "user_Id", "dbo.Users");
            DropIndex("dbo.Questions", "IX_Question_Teory_Id");
            DropIndex("dbo.Progresses", "IX_Progress_user_Id");
            DropIndex("dbo.Answers", "IX_Answer_Question_Id");
            DropTable("dbo.Teories");
            DropTable("dbo.Questions");
            DropTable("dbo.Progresses");
            DropTable("dbo.Answers");
        }
    }
}
