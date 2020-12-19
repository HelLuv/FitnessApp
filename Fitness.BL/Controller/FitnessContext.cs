using Fitness.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fitness.BL.Controller
{
    public class FitnessContext : DbContext
    {
        public FitnessContext() { }
        public FitnessContext(DbContextOptions<FitnessContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Eating> Eatings { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
