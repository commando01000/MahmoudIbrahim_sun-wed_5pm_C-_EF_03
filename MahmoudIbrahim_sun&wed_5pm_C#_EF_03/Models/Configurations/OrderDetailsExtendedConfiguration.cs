﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models.Configurations
{
    public partial class OrderDetailsExtendedConfiguration : IEntityTypeConfiguration<OrderDetailsExtended>
    {
        public void Configure(EntityTypeBuilder<OrderDetailsExtended> entity)
        {
            entity.ToView("Order Details Extended");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrderDetailsExtended> entity);
    }
}
