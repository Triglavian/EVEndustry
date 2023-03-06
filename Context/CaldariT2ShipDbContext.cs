using Microsoft.EntityFrameworkCore;
using EVEndustry.Models.ItemModels;
using System;

namespace EVEndustry.Context;

public class CaldariT2ShipDbContext : DbContext
{
    public CaldariT2ShipDbContext(DbContextOptions<CaldariT2ShipDbContext> options) : base(options)
    {

    }
    public DbSet<Item> Items { get; set; }
}
