using System;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;
using EntityFramework.ProfileModels;

namespace EntityFramework
{
	public class ProfileContext : DbContext
    {
        public ProfileContext()
        {
        }

        public ProfileContext(DbContextOptions<ProfileContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserModel> Users_Rohith { get; set; }

        public virtual DbSet<FavoriteStocksModel> FavoriteStocks_Rohith { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server = endeavourtech.ddns.net; Port=31240;User Id = endeavour_test_area; Password=Endeavour01;Database=CrudDB;", x => x.MigrationsHistoryTable("__MyMigrationsHistory_Rohith", "endeavour_test_area"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("Users_pkey_Rohith");

                entity.ToTable("users_Rohith", "endeavour_test_area", tb => tb.HasComment("Table that contains the data for a user profiles, i.e. UserId and FistName, LastName"));

                entity.Property(e => e.UserId)
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1, 1, 1, 500, null, null)
                    .HasColumnName("user_id");
                entity.Property(e => e.FistName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");
                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");
                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");
            });

            modelBuilder.Entity<FavoriteStocksModel>(entity =>
            {
                entity.HasKey(e => e.FavoriteStockId).HasName("FavoriteStocks_pkey_Rohith");

                entity.ToTable("favorite_stocks_Rohith", "endeavour_test_area", tb => tb.HasComment("Table that contains the data for a user favorite stocks, i.e. UserId and ticker symbol"));

                entity.Property(e => e.FavoriteStockId)
                    .UseIdentityAlwaysColumn()
                    .HasIdentityOptions(1, 1, 1, null, null, null)
                    .HasColumnName("favorite_stock_id");
                entity.Property(e => e.UserId)
                    .HasColumnName("user_id");
                entity.Property(e => e.TickerSymbol)
                    .HasMaxLength(25)
                    .HasColumnName("ticket_symbol");
            });
        }
    }
}

