﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models.Configurations
{
    public partial class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation).HasConstraintName("FK_Employees_Employees");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Employee> entity);
    }
}