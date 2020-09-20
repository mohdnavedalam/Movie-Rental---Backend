namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropConstraint : DbMigration
    {
        public override void Up()
        {
            //Sql(“ALTER TABLE dbo.Videos DROP CONSTRAINT [constraint -­‐name]”);
            //No need to do this since the constraint is deleted by itself in this case.
            //I don't know why
        }
        
        public override void Down()
        {
        }
    }
}
