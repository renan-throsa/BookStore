﻿using BookApp.Data.Utils;
using BookApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace BookApp.Data.Configurations
{
    internal class OrderModelConfigs : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            const string UdfTotalOrder = nameof(Methods.TotalOrderPrice);

            builder.HasMany(x => x.Items).WithOne(y => y.Order);
            builder.Property(x => x.OrderedOn).HasColumnType("datetime").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(x => x.TotalPrice).HasComputedColumnSql($"dbo.{UdfTotalOrder}([OrderId])");
            builder.Property(x => x.OrderNo).HasValueGenerator((x, y) => new OrderNoValueGenerator());

            var orders = new List<Order>() {
                new Order() { OrderId = 1, CustomerId = 1                  },
                new Order() { OrderId = 2, CustomerId = 1},
               new Order() { OrderId = 3, CustomerId = 1,},
                new Order() { OrderId = 4, CustomerId = 1,},
                new Order() { OrderId = 5, CustomerId = 4,},
                new Order() { OrderId = 6, CustomerId = 5, },
            };

            builder.HasData(orders);
        }
    }
}
