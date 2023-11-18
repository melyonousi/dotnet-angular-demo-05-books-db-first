using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace back.Models;

public partial class DotnetAngularDemo05Context : DbContext
{
    public DotnetAngularDemo05Context()
    {
    }

    public DotnetAngularDemo05Context(DbContextOptions options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("books_pkey");

            entity.ToTable("books");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.NbPages).HasDefaultValueSql("0");
            entity.Property(e => e.PublisheDat).HasDefaultValueSql("now()");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
