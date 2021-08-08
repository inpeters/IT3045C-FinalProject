using System;
using IT3045C_FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_FinalProject.Data
{
    public class MemberInfo : DbContext
    {

        public MemberInfo(DbContextOptions<MemberInfo> options) : base(options)
        {

        }

        public DbSet<Member> Member { get; set; }
        public DbSet<Hobby> Hobby { get; set; }
        public DbSet<Breakfast> Breakfast { get; set; }
        public DbSet<Dinner> Dinner { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Member>().HasData(
            new Member
            {
                ID = 1,
                FullName = "Isabella Peters",
                CollegeProgram = "Information Technology",
                YearInProgram = "Junior",
                Birthdate = new DateTime(2001, 09, 17)
            },
            new Member
                {
                  ID = 2,
                  FullName = "Logan Nemec",
                  CollegeProgram = "Information Technology",
                  YearInProgram = "First Year",
                  Birthdate = new DateTime(2000, 03, 10)
                },
            new Member
                {
                  ID = 3, 
                  FullName = "Joseph Berger",
                  CollegeProgram = "Information Technology",
                  YearInProgram = "Third Year",
                  Birthdate = new DateTime(2000, 03, 17)
                },
             new Member
                {

                },
            new Member
                {

                },
            new Member
                {
                  
                }
            );
            builder.Entity<Hobby>().HasData(
            new Hobby
            {
                Id = 1,
                FullName = "Isabella Peters",
                FavoriteHobby = "Hiking",
                HowStarted = "My family would take me.",
                WhyStarted = "To exercise"
            },
            new Hobby
            {
                ID = 2,
                FullName = "Logan Nemec",
                FavoriteHobby = "Playing Video Games",
                HowStarted = "Family and Friends",
                WhyStarted = "For fun and good stress relief"
            },
            new Hobby
            {
                ID = 3,
                FullName = "Joseph Berger",
                FavoriteHobby = "Extreme Deep Sea Diving",
                HowStarted = "Became best friends with a local fisherman",
                WhyStarted = "To gaze upon the amazing underwater sea"
            },
            new Hobby
                {
                  
                },
            new Hobby
                {
                   

                },
            new Hobby
                {
                
                }
            );
            builder.Entity<Breakfast>().HasData(
            new Breakfast
            {
                Id = 1,
                FullName = "Isabella Peters",
                FavoriteBreakfastFood = "Waffles",
                FavoriteSide = "Bacon",
                FavoriteBreakfastTime = "10:00 AM"
            },
            new Breakfast
            {
                ID = 2,
                FullName = "Logan Nemec",
                FavoriteBreakfastFood = "Waffles",
                FavoriteSide = "Bacon",
                FavoriteBreakfastTime = "12:00 PM"
            },
            new Breakfast
            {
                ID = 3,
                FullName = "Joseph Berger",
                FavoriteBreakfastFood = "French Toast",
                FavoriteSide = "Coffee",
                FavoriteBreakfastTime = "6:00 AM"
            },
            new Breakfast
                {
                    
                },
            new Breakfast
                {
                    

                },
            new Breakfast
                {
                    
                }
            );
            builder.Entity<Dinner>().HasData(
            new Dinner
             {
                Id = 1,
                FullName = "Isabella Peters",
                FavoriteEntree = "Steak",
                FavoriteSide = "Mashed Potatoes",
                FavoriteRestaurant = "Alladins' Eatery"
            },
            new Dinner
            {
                ID = 2,
                FullName = "Logan Nemec",
                FavoriteEntree = "Steak",
                FavoriteSide = "Fried rice and noodles",
                FavoriteRestaraunt = "Swensons"
            },
            new Dinner
            {
                ID = 3,
                FullName = "Joseph Berger",
                FavoriteEntree = "Pizza",
                FavoriteSide = "Fries",
                FavoriteRestaraunt = "Dewey's"
            },
            new Dinner
                {
                
                },
            new Dinner
                {
                
                },
            new Dinner
                {
                
                }           
          );
        }
    }

}