using Fitness.BL.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fitness.BL.Controller
{
    public class FitnessContext : DbContext
    {
        public FitnessContext() { }

        public DbSet<Eating> Eatings { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
