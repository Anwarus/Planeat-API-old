using Entities.AdditionalModels;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class ReciptIngredientConfiguration : IEntityTypeConfiguration<ReciptIngredient>
    {
        public void Configure(EntityTypeBuilder<ReciptIngredient> builder)
        {
            builder.HasKey(ri => new { ri.ReciptId, ri.IngredientId });

            builder
                .HasOne<Recipt>(ri => ri.Recipt)
                .WithMany(r => r.ReciptIngredients)
                .HasForeignKey(ri => ri.ReciptId);

            builder
                .HasOne<Ingredient>(ri => ri.Ingredient)
                .WithMany(i => i.ReciptIngredients)
                .HasForeignKey(ri => ri.IngredientId);
        }
    }
}
