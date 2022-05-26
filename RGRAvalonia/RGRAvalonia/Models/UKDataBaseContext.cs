using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RGRAvalonia
{
    public partial class UKDataBaseContext : DbContext
    {
        public UKDataBaseContext()
        {
        }

        public UKDataBaseContext(DbContextOptions<UKDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<МестоЗабега> МестоЗабегаs { get; set; } = null!;
        public virtual DbSet<Результат> Результатs { get; set; } = null!;
        public virtual DbSet<СтатистикаСобакБегунов> СтатистикаСобакБегуновs { get; set; } = null!;
        public virtual DbSet<Тренер> Тренерs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\Татьяна\\Desktop\\РГР по визуалке\\RGRAvalonia\\RGRAvalonia\\Models\\UKDataBase.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<МестоЗабега>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("Место забега");

                entity.Property(e => e.Date).HasColumnType("STRING");

                entity.Property(e => e.PlaceName).HasColumnType("STRING");
            });

            modelBuilder.Entity<Результат>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Результат");

                entity.Property(e => e.Date).HasColumnType("STRING");

                entity.Property(e => e.NickName).HasColumnType("STRING");

                entity.Property(e => e.TimeRace).HasColumnType("TIME");
            });

            modelBuilder.Entity<СтатистикаСобакБегунов>(entity =>
            {
                entity.HasKey(e => e.NiclName);

                entity.ToTable("Статистика собак-бегунов");

                entity.Property(e => e.NiclName).HasColumnType("STRING");

                entity.Property(e => e.Breed).HasColumnType("STRING");

                entity.Property(e => e.Trainer).HasColumnType("STRING");

                entity.Property(e => e.TypeRace).HasColumnType("STRING");
            });

            modelBuilder.Entity<Тренер>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Тренер");

                entity.Property(e => e.Name).HasColumnType("STRING");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
