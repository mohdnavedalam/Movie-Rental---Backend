namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetRequiredColumnNameTableTag : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tags", "Name", c => c.String());
        }
    }
}
