namespace Practica4_GrafovaKL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetFieldsUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String(maxLength: 2147483647));
            AddColumn("dbo.Users", "Password", c => c.String(maxLength: 2147483647));
            AddColumn("dbo.Users", "Gender", c => c.String(maxLength: 2147483647));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Email");
        }
    }
}
