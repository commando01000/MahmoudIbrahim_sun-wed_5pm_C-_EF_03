﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models.Configurations
{
    public partial class EmployeeTerritoryConfiguration : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> entity)
        {
            entity.HasKey(e => new { e.EmployeeId, e.TerritoryId }).IsClustered(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTerritories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerritories_Employees");

            entity.HasOne(d => d.Territory).WithMany(p => p.EmployeeTerritories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerritories_Territories");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EmployeeTerritory> entity);
    }
}
