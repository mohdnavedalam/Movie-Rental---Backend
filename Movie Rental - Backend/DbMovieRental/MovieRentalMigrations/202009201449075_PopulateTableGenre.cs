namespace Movie_Rental___Backend.DbMovieRental.MovieRentalMigrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class PopulateTableGenre : DbMigration
	{
		public override void Up()
		{
			Sql(@"
					INSERT INTO Genres (Name)
					VALUES 
						('Comedy'), 
						('Action'), 
						('Horror'), 
						('Thriller'), 
						('Family'), 
						('Romance'),
						('Drama')
				");
		}
		
		public override void Down()
		{
			Sql("DELETE FROM Genres WHERE ID BETWEEN 1 AND 6");
		}
	}
}
