using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DailyJournalApplication.Models;

public partial class DJDbContext : DbContext
{
    public DJDbContext()
    {
    }

    public DJDbContext(DbContextOptions<DJDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Entry> Entries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseLazyLoadingProxies()        // <-- add this line
                .UseSqlServer("Name=DJConnection");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Entry__3214EC2737C14099");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
