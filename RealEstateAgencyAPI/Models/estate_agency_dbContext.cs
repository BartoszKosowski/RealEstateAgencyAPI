using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RealEstateAgencyAPI.Models
{
    public partial class estate_agency_dbContext : DbContext
    {
        public estate_agency_dbContext()
        {
        }

        public estate_agency_dbContext(DbContextOptions<estate_agency_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Estate> Estates { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<TradeInfo> TradeInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;port=3300;user=root;password=Start123!;database=estate_agency_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .HasName("PRIMARY");

                entity.ToTable("addresses");

                entity.HasIndex(e => e.IdAddress, "id_address_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdAddress).HasColumnName("id_address");

                entity.Property(e => e.ApartmentNumber)
                    .HasMaxLength(15)
                    .HasColumnName("apartment_number");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("city");

                entity.Property(e => e.EstateNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("estate_number");

                entity.Property(e => e.Street)
                    .HasMaxLength(45)
                    .HasColumnName("street");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("zip_code");
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.IdAgents)
                    .HasName("PRIMARY");

                entity.ToTable("agents");

                entity.HasIndex(e => e.Area, "FK_agent_trade_info_idx");

                entity.HasIndex(e => e.IdAgents, "id_agents_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdAgents).HasColumnName("id_agents");

                entity.Property(e => e.Area)
                    .HasColumnType("tinyint")
                    .HasColumnName("area");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("first_name");

                entity.Property(e => e.FullName)
                    .HasMaxLength(90)
                    .HasColumnName("full_Name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("phone_number");

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(100)
                    .HasColumnName("photo_url");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.Area)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agent_trade_info");
            });

            modelBuilder.Entity<Estate>(entity =>
            {
                entity.HasKey(e => e.IdEstate)
                    .HasName("PRIMARY");

                entity.ToTable("estates");

                entity.HasIndex(e => e.Address, "FK_estate_address_idx");

                entity.HasIndex(e => e.PropertyStatus, "FK_estate_status_idx");

                entity.HasIndex(e => e.PropertyType, "FK_estate_trade_info_idx");

                entity.Property(e => e.IdEstate).HasColumnName("id_estate");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.BuildDate)
                    .HasColumnType("year")
                    .HasColumnName("build_date");

                entity.Property(e => e.DistanceToCenter)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_center");

                entity.Property(e => e.DistanceToCoast)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_coast");

                entity.Property(e => e.DistanceToForest)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_forest");

                entity.Property(e => e.DistanceToHighway)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_highway");

                entity.Property(e => e.DistanceToLake)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_lake");

                entity.Property(e => e.DistanceToMall)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_mall");

                entity.Property(e => e.DistanceToMountains)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_mountains");

                entity.Property(e => e.DistanceToRiver)
                    .HasColumnType("decimal(3,1)")
                    .HasColumnName("distance_to_river");

                entity.Property(e => e.Floors)
                    .HasColumnType("tinyint")
                    .HasColumnName("floors");

                entity.Property(e => e.Furnishings)
                    .HasColumnType("bit(1)")
                    .HasColumnName("furnishings");

                entity.Property(e => e.HasBalcony)
                    .HasColumnType("bit(1)")
                    .HasColumnName("has_balcony");

                entity.Property(e => e.NearCenter)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_center");

                entity.Property(e => e.NearCoast)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_coast");

                entity.Property(e => e.NearForest)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_forest");

                entity.Property(e => e.NearHighway)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_highway");

                entity.Property(e => e.NearLake)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_lake");

                entity.Property(e => e.NearMall)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_mall");

                entity.Property(e => e.NearMountains)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_mountains");

                entity.Property(e => e.NearRiver)
                    .HasColumnType("bit(1)")
                    .HasColumnName("near_river");

                entity.Property(e => e.NumberOfRooms).HasColumnName("number_of_rooms");

                entity.Property(e => e.OtherDetails).HasColumnName("other_details");

                entity.Property(e => e.PropertyArea)
                    .HasColumnType("decimal(8,1)")
                    .HasColumnName("property_area");

                entity.Property(e => e.PropertyStatus)
                    .HasColumnType("tinyint")
                    .HasColumnName("property_status");

                entity.Property(e => e.PropertyType)
                    .HasColumnType("tinyint")
                    .HasColumnName("property_type");

                entity.Property(e => e.TypeOfBathroom)
                    .HasMaxLength(45)
                    .HasColumnName("type_of_bathroom");

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.Address)
                    .HasConstraintName("FK_estate_address");

                entity.HasOne(d => d.PropertyStatusNavigation)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.PropertyStatus)
                    .HasConstraintName("FK_estate_status");

                entity.HasOne(d => d.PropertyTypeNavigation)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.PropertyType)
                    .HasConstraintName("FK_estate_trade_type");
            });

            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.HasKey(e => e.IdMeetings)
                    .HasName("PRIMARY");

                entity.ToTable("meetings");

                entity.HasIndex(e => e.EstateAddress, "FK_estate_address_idx");

                entity.HasIndex(e => e.Agent, "FK_meetings_agent_idx");

                entity.HasIndex(e => e.Status, "FK_meetings_status_idx");

                entity.HasIndex(e => e.IdMeetings, "id_meetings_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdMeetings).HasColumnName("id_meetings");

                entity.Property(e => e.Agent).HasColumnName("agent");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(70)
                    .HasColumnName("customer_email");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(90)
                    .HasColumnName("customer_name");

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(12)
                    .HasColumnName("customer_number");

                entity.Property(e => e.DateOfMeeting).HasColumnName("date_of_meeting");

                entity.Property(e => e.EstateAddress).HasColumnName("estate_address");

                entity.Property(e => e.InEstate)
                    .HasColumnType("bit(1)")
                    .HasColumnName("in_estate");

                entity.Property(e => e.OtherAddress)
                    .HasMaxLength(200)
                    .HasColumnName("other_address");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasColumnName("status");

                entity.HasOne(d => d.AgentNavigation)
                    .WithMany(p => p.Meetings)
                    .HasForeignKey(d => d.Agent)
                    .HasConstraintName("FK_meetings_agent");

                entity.HasOne(d => d.EstateAddressNavigation)
                    .WithMany(p => p.Meetings)
                    .HasForeignKey(d => d.EstateAddress)
                    .HasConstraintName("FK_meetings_address");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Meetings)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_meetings_status");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasKey(e => e.IdOffers)
                    .HasName("PRIMARY");

                entity.ToTable("offers");

                entity.HasIndex(e => e.Agent, "FK_offer_agent_idx");

                entity.HasIndex(e => e.Estate, "FK_offer_estate_idx");

                entity.HasIndex(e => e.OfferStatus, "FK_offer_status_idx");

                entity.HasIndex(e => e.Area, "FK_offer_trade_info_idx");

                entity.HasIndex(e => e.IdOffers, "id_offers_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdOffers).HasColumnName("id_offers");

                entity.Property(e => e.Agent).HasColumnName("agent");

                entity.Property(e => e.Area)
                    .HasColumnType("tinyint")
                    .HasColumnName("area");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.Estate).HasColumnName("estate");

                entity.Property(e => e.OfferStatus)
                    .HasColumnType("tinyint")
                    .HasColumnName("offer_status");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(12,2)")
                    .HasColumnName("price");

                entity.Property(e => e.Promoted)
                    .HasColumnType("bit(1)")
                    .HasColumnName("promoted");

                entity.Property(e => e.PublishingDate)
                    .HasColumnType("date")
                    .HasColumnName("publishing_date");

                entity.Property(e => e.Views).HasColumnName("views");

                entity.HasOne(d => d.AgentNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.Agent)
                    .HasConstraintName("FK_offer_agent");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("FK_offer_trade_info");

                entity.HasOne(d => d.EstateNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.Estate)
                    .HasConstraintName("FK_offer_estate");

                entity.HasOne(d => d.OfferStatusNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.OfferStatus)
                    .HasConstraintName("FK_offer_status");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(e => e.IdPhoto)
                    .HasName("PRIMARY");

                entity.ToTable("photos");

                entity.HasIndex(e => e.Estate, "FK_photo_estate_idx");

                entity.HasIndex(e => e.IdPhoto, "id_Photo_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdPhoto).HasColumnName("id_Photo");

                entity.Property(e => e.Estate).HasColumnName("estate");

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(100)
                    .HasColumnName("photo_url");

                entity.HasOne(d => d.EstateNavigation)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.Estate)
                    .HasConstraintName("FK_photo_estate");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PRIMARY");

                entity.ToTable("statuses");

                entity.Property(e => e.IdStatus)
                    .HasColumnType("tinyint")
                    .HasColumnName("id_status");

                entity.Property(e => e.Desc)
                    .HasMaxLength(100)
                    .HasColumnName("desc");

                entity.Property(e => e.Domain)
                    .HasMaxLength(50)
                    .HasColumnName("domain");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(3)
                    .HasColumnName("short_name");
            });

            modelBuilder.Entity<TradeInfo>(entity =>
            {
                entity.HasKey(e => e.IdInfo)
                    .HasName("PRIMARY");

                entity.ToTable("trade_info");

                entity.Property(e => e.IdInfo)
                    .HasColumnType("tinyint")
                    .HasColumnName("id_info");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("domain");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("key_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("short_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
