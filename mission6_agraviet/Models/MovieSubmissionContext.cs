using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mission6_agraviet.Models
{
	public class MovieSubmissionContext : DbContext
	{
		//Constructor
		public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base (options)
		{
			//leave blank for now
		}

		public DbSet<MovieSubmission> responses { get; set; }
        public DbSet<Category> categories { get; set; }

		protected override void OnModelCreating(ModelBuilder mb)
		{
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Adventure" },
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Family" },
                new Category { CategoryID = 6, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 7, CategoryName = "Misc" },
                new Category { CategoryID = 8, CategoryName = "TV" },
                new Category { CategoryID = 9, CategoryName = "VHS" }
            );
			mb.Entity<MovieSubmission>().HasData(
				new MovieSubmission
				{
					submissionId = 1,
					CategoryId = 1,
					title = "The Avengers",
					year = 2012,
					director = "Joss Whedon",
					rating = "PG-13",
					edited = false,
					lentTo = "NA",
					notes = "mid movie"
				},
                new MovieSubmission
                {
                    submissionId = 2,
                    CategoryId = 1,
                    title = "Batman",
                    year = 1998,
                    director = "Tim Burton",
                    rating = "PG-13",
                    edited = false,
                    lentTo = "NA",
                    notes = "better movie"
                },
                new MovieSubmission
                {
                    submissionId = 3,
                    CategoryId = 2,
                    title = "Clue",
                    year = 1985,
                    director = "Jonathan Lynn",
                    rating = "PG",
                    edited = false,
                    lentTo = "NA",
                    notes = "never actually seen this movie"
                }
            );
		}
	}
}

