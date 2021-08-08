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