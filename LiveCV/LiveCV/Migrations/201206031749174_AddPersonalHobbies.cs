namespace LiveCV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonalHobbies : DbMigration
    {
        public override void Up()
        {
            AddColumn("PersonalDetails", "Interests", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("PersonalDetails", "Interests");
        }
    }
}
