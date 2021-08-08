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
                 ID = 4,
                 FullName = "Tony Herrera",
                 CollegeProgram = "Information Technology",
                 YearInProgram = "Fourth Year",
                 Birthdate = new DateTime(1999, 09, 22)
             },
            new Member
                {
                ID = 5,
                FullName = "Taylor O'Black",
                CollegeProgram = "Information Technology",
                YearInProgram = "Third Year",
                Birthdate = new DateTime(2000, 07, 03)
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
                Id = 2,
                FullName = "Logan Nemec",
                FavoriteHobby = "Playing Video Games",
                HowStarted = "Family and Friends",
                WhyStarted = "For fun and good stress relief"
            },
            new Hobby
            {
                Id = 3,
                FullName = "Joseph Berger",
                FavoriteHobby = "Extreme Deep Sea Diving",
                HowStarted = "Became best friends with a local fisherman",
                WhyStarted = "To gaze upon the amazing underwater sea"
            },
            new Hobby
                {
                Id = 4,
                FullName = "Tony Herrera",
                FavoriteHobby = "Video Games",
                HowStarted = "My brother made fun of me for being bad at them",
                WhyStarted = "To beat my brother for bragging rights"
            },
            new Hobby
                {
                Id = 5,
                FullName = "Taylor O'Black",
                FavoriteHobby = "Raising a Puppy",
                HowStarted = "Got a Shiba Inu with my partner",
                WhyStarted = "I love puppies"
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
                Id = 2,
                FullName = "Logan Nemec",
                FavoriteBreakfastFood = "Waffles",
                FavoriteSide = "Bacon",
                FavoriteBreakfastTime = "12:00 PM"
            },
            new Breakfast
            {
                Id = 3,
                FullName = "Joseph Berger",
                FavoriteBreakfastFood = "French Toast",
                FavoriteSide = "Coffee",
                FavoriteBreakfastTime = "6:00 AM"
            },
            new Breakfast
                {
                Id = 4,
                FullName = "Tony Herrera",
                FavoriteBreakfastFood = "Bacon Egg & Cheese Biscuit",
                FavoriteSide = "Toast",
                FavoriteBreakfastTime = "8:00 AM"
            },
            new Breakfast
                {
                Id = 5,
                FullName = "Taylor O'Black",
                FavoriteBreakfastFood = "Egg Sandwich",
                FavoriteSide = "Coffee",
                FavoriteBreakfastTime = "7:30 AM"
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
                Id = 2,
                FullName = "Logan Nemec",
                FavoriteEntree = "Steak",
                FavoriteSide = "Fried rice and noodles",
                FavoriteRestaurant = "Swensons"
            },
            new Dinner
            {
                Id = 3,
                FullName = "Joseph Berger",
                FavoriteEntree = "Pizza",
                FavoriteSide = "Fries",
                FavoriteRestaurant = "Dewey's"
            },
            new Dinner
                {
                Id = 4,
                FullName = "Tony Herrera",
                FavoriteEntree = "Cheeseburger",
                FavoriteSide = "Fries",
                FavoriteRestaurant = "Culver's"
            },
            new Dinner
                {
                Id = 5,
                FullName = "Taylor O'Black",
                FavoriteEntree = "Shephards Pie",
                FavoriteSide = "Roasted Potatoes",
                FavoriteRestaurant = "CheeseCake Factory"
            }         
          );
        }
    }

}