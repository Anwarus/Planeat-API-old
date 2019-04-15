using Entities.AdditionalModels;
using Entities.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Recipt> Recipts { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ReciptIngredient> ReciptIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReciptIngredientConfiguration());
        }
    }
}
