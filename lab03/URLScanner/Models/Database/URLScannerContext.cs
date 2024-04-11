using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace URLScanner.Models.Database;

public partial class URLScannerContext : DbContext
{
    public URLScannerContext()
    {
    }

    public URLScannerContext(DbContextOptions<URLScannerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Analysis> Analyses { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Stat> Stats { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Analysis>(entity =>
        {
            entity.ToTable("analyses");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("DATETIME")
                .HasColumnName("date");
            entity.Property(e => e.StatId).HasColumnName("stat_id");
            entity.Property(e => e.Url).HasColumnName("url");

            entity.HasOne(d => d.Stat).WithMany(p => p.Analyses).HasForeignKey(d => d.StatId);

            entity.HasMany(d => d.Results).WithMany(p => p.Analyses)
                .UsingEntity<Dictionary<string, object>>(
                    "AnalysesResult",
                    r => r.HasOne<Result>().WithMany().HasForeignKey("ResultId"),
                    l => l.HasOne<Analysis>().WithMany().HasForeignKey("AnalysisId"),
                    j =>
                    {
                        j.HasKey("AnalysisId", "ResultId");
                        j.ToTable("analyses_results");
                        j.IndexerProperty<int>("AnalysisId").HasColumnName("analysis_id");
                        j.IndexerProperty<int>("ResultId").HasColumnName("result_id");
                    });
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.ToTable("results");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Engine).HasColumnName("engine");
            entity.Property(e => e.Method).HasColumnName("method");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
        });

        modelBuilder.Entity<Stat>(entity =>
        {
            entity.ToTable("stats");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Harmless).HasColumnName("harmless");
            entity.Property(e => e.Malicious).HasColumnName("malicious");
            entity.Property(e => e.Suspicious).HasColumnName("suspicious");
            entity.Property(e => e.Timeout).HasColumnName("timeout");
            entity.Property(e => e.Undetected).HasColumnName("undetected");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
