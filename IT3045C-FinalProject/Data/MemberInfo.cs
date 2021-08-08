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
                  
                },
            new Member
                {
                  
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
                  
                },
            new Hobby
                {
                  
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
                    
                },
            new Breakfast
                {
                    
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
                FavoriteEntre = "Steak",
                FavoriteSide = "Mashed Potatoes",
                FavoriteRestaurant = "Alladins' Eatery"
            },
            new Dinner
                {
                
                },
            new Dinner
                {
                
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