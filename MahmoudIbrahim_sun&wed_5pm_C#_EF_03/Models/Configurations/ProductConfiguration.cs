﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models.Configurations
{
    public partial class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.Property(e => e.ReorderLevel).HasDefaultValue((short)0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0m);
            entity.Property(e => e.UnitsInStock).HasDefaultValue((short)0);
            entity.Property(e => e.UnitsOnOrder).HasDefaultValue((short)0);

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasConstraintName("FK_Products_Categories");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products).HasConstraintName("FK_Products_Suppliers");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Product> entity);
    }
}