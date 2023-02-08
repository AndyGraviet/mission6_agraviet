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

		protected override void OnModelCreating(ModelBuilder mb)
		{
			mb.Entity<MovieSubmission>().HasData(
				new MovieSubmission
				{
					submissionId = 1,
					category = "Action",
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
                    category = "Action",
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
                    category = "Comedy",
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

//here is a change to the branch for mission 7
