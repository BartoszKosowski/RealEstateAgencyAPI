﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateAgencyAPI.Models;

namespace RealEstateAgencyAPI.Migrations
{
    [DbContext(typeof(estate_agency_dbContext))]
    [Migration("20211126122509_04_AddFieldOfferType")]
    partial class _04_AddFieldOfferType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Address", b =>
                {
                    b.Property<int>("IdAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_address");

                    b.Property<string>("ApartmentNumber")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("apartment_number");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("city");

                    b.Property<string>("EstateNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("estate_number");

                    b.Property<string>("Street")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("street");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("zip_code");

                    b.HasKey("IdAddress")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdAddress" }, "id_address_UNIQUE")
                        .IsUnique();

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Agent", b =>
                {
                    b.Property<int>("IdAgents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_agents");

                    b.Property<byte>("Area")
                        .HasColumnType("tinyint")
                        .HasColumnName("area");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("first_name");

                    b.Property<string>("FullName")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("full_Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("phone_number");

                    b.Property<string>("PhotoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("photo_url");

                    b.HasKey("IdAgents")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Area" }, "FK_agent_trade_info_idx");

                    b.HasIndex(new[] { "IdAgents" }, "id_agents_UNIQUE")
                        .IsUnique();

                    b.ToTable("agents");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Estate", b =>
                {
                    b.Property<int>("IdEstate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_estate");

                    b.Property<int?>("Address")
                        .HasColumnType("int")
                        .HasColumnName("address");

                    b.Property<decimal?>("AdministrationTax")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("administration_tax");

                    b.Property<short?>("BuildDate")
                        .HasColumnType("year")
                        .HasColumnName("build_date");

                    b.Property<decimal?>("DistanceToCenter")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_center");

                    b.Property<decimal?>("DistanceToCoast")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_coast");

                    b.Property<decimal?>("DistanceToForest")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_forest");

                    b.Property<decimal?>("DistanceToHighway")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_highway");

                    b.Property<decimal?>("DistanceToLake")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_lake");

                    b.Property<decimal?>("DistanceToMall")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_mall");

                    b.Property<decimal?>("DistanceToMountains")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_mountains");

                    b.Property<decimal?>("DistanceToRiver")
                        .HasColumnType("decimal(3,1)")
                        .HasColumnName("distance_to_river");

                    b.Property<byte?>("Floors")
                        .HasColumnType("tinyint")
                        .HasColumnName("floors");

                    b.Property<bool?>("Furnishings")
                        .HasColumnType("bit(1)")
                        .HasColumnName("furnishings");

                    b.Property<bool?>("HasBalcony")
                        .HasColumnType("bit(1)")
                        .HasColumnName("has_balcony");

                    b.Property<bool?>("HasRent")
                        .HasColumnType("bit(1)")
                        .HasColumnName("has_rent");

                    b.Property<string>("MainPhotoUrl")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("main_photo_url");

                    b.Property<bool?>("NearCenter")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_center");

                    b.Property<bool?>("NearCoast")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_coast");

                    b.Property<bool?>("NearForest")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_forest");

                    b.Property<bool?>("NearHighway")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_highway");

                    b.Property<bool?>("NearLake")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_lake");

                    b.Property<bool?>("NearMall")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_mall");

                    b.Property<bool?>("NearMountains")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_mountains");

                    b.Property<bool?>("NearRiver")
                        .HasColumnType("bit(1)")
                        .HasColumnName("near_river");

                    b.Property<short?>("NumberOfRooms")
                        .HasColumnType("smallint")
                        .HasColumnName("number_of_rooms");

                    b.Property<string>("OtherDetails")
                        .HasColumnType("text")
                        .HasColumnName("other_details");

                    b.Property<decimal?>("PropertyArea")
                        .HasColumnType("decimal(8,1)")
                        .HasColumnName("property_area");

                    b.Property<byte?>("PropertyStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("property_status");

                    b.Property<byte?>("PropertyType")
                        .HasColumnType("tinyint")
                        .HasColumnName("property_type");

                    b.Property<decimal?>("Rent")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("rent");

                    b.Property<string>("TypeOfBathroom")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("type_of_bathroom");

                    b.HasKey("IdEstate")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Address" }, "FK_estate_address_idx");

                    b.HasIndex(new[] { "PropertyStatus" }, "FK_estate_status_idx");

                    b.HasIndex(new[] { "PropertyType" }, "FK_estate_trade_info_idx");

                    b.ToTable("estates");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Meeting", b =>
                {
                    b.Property<int>("IdMeetings")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_meetings");

                    b.Property<int?>("Agent")
                        .HasColumnType("int")
                        .HasColumnName("agent");

                    b.Property<string>("CustomerEmail")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("customer_email");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("customer_name");

                    b.Property<string>("CustomerNumber")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("customer_number");

                    b.Property<DateTime>("DateOfMeeting")
                        .HasColumnType("datetime")
                        .HasColumnName("date_of_meeting");

                    b.Property<int?>("EstateAddress")
                        .HasColumnType("int")
                        .HasColumnName("estate_address");

                    b.Property<bool?>("InEstate")
                        .HasColumnType("bit(1)")
                        .HasColumnName("in_estate");

                    b.Property<string>("OtherAddress")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("other_address");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("status");

                    b.HasKey("IdMeetings")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "EstateAddress" }, "FK_estate_address_idx")
                        .HasDatabaseName("FK_estate_address_idx1");

                    b.HasIndex(new[] { "Agent" }, "FK_meetings_agent_idx");

                    b.HasIndex(new[] { "Status" }, "FK_meetings_status_idx");

                    b.HasIndex(new[] { "IdMeetings" }, "id_meetings_UNIQUE")
                        .IsUnique();

                    b.ToTable("meetings");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Offer", b =>
                {
                    b.Property<int>("IdOffers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_offers");

                    b.Property<int?>("Agent")
                        .HasColumnType("int")
                        .HasColumnName("agent");

                    b.Property<byte?>("Area")
                        .HasColumnType("tinyint")
                        .HasColumnName("area");

                    b.Property<string>("Details")
                        .HasColumnType("text")
                        .HasColumnName("details");

                    b.Property<int?>("Estate")
                        .HasColumnType("int")
                        .HasColumnName("estate");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<byte?>("OfferStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("offer_status");

                    b.Property<string>("OfferType")
                        .HasColumnType("varchar(150)")
                        .HasColumnName("offer_type");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("price");

                    b.Property<decimal?>("PriceForMeter")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("price_for_meter");

                    b.Property<bool?>("Promoted")
                        .HasColumnType("bit(1)")
                        .HasColumnName("promoted");

                    b.Property<DateTime?>("PublishingDate")
                        .HasColumnType("date")
                        .HasColumnName("publishing_date");

                    b.Property<int?>("Views")
                        .HasColumnType("int")
                        .HasColumnName("views");

                    b.HasKey("IdOffers")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Agent" }, "FK_offer_agent_idx");

                    b.HasIndex(new[] { "Estate" }, "FK_offer_estate_idx");

                    b.HasIndex(new[] { "OfferStatus" }, "FK_offer_status_idx");

                    b.HasIndex(new[] { "Area" }, "FK_offer_trade_info_idx");

                    b.HasIndex(new[] { "IdOffers" }, "id_offers_UNIQUE")
                        .IsUnique();

                    b.ToTable("offers");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.OfferPreview", b =>
                {
                    b.Property<decimal?>("Area")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("area");

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("NumberOfRooms")
                        .HasColumnType("int")
                        .HasColumnName("number_of_rooms");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("price");

                    b.Property<decimal?>("PriceForMeter")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("price_for_meter");

                    b.Property<string>("Status")
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<string>("Street")
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.Property<string>("TypeOfProperty")
                        .HasColumnType("text")
                        .HasColumnName("type_of_property");

                    b.ToView("offer_preview_view");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Photo", b =>
                {
                    b.Property<int>("IdPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_Photo");

                    b.Property<int?>("Estate")
                        .HasColumnType("int")
                        .HasColumnName("estate");

                    b.Property<string>("PhotoUrl")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("photo_url");

                    b.HasKey("IdPhoto")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Estate" }, "FK_photo_estate_idx");

                    b.HasIndex(new[] { "IdPhoto" }, "id_Photo_UNIQUE")
                        .IsUnique();

                    b.ToTable("photos");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Request", b =>
                {
                    b.Property<int>("IdRequest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone_name");

                    b.Property<byte>("Service")
                        .HasColumnType("tinyint")
                        .HasColumnName("service");

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("request_status");

                    b.HasKey("IdRequest")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Status" }, "FK_request_status_idx");

                    b.HasIndex(new[] { "Service" }, "FK_request_trade_info_idx");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Status", b =>
                {
                    b.Property<byte>("IdStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("id_status");

                    b.Property<string>("Desc")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("desc");

                    b.Property<string>("Domain")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("domain");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("ShortName")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("short_name");

                    b.HasKey("IdStatus")
                        .HasName("PRIMARY");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.TradeInfo", b =>
                {
                    b.Property<byte>("IdInfo")
                        .HasColumnType("tinyint")
                        .HasColumnName("id_info");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("domain");

                    b.Property<string>("KeyName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("key_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("short_name");

                    b.HasKey("IdInfo")
                        .HasName("PRIMARY");

                    b.ToTable("trade_info");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Agent", b =>
                {
                    b.HasOne("RealEstateAgencyAPI.Models.TradeInfo", "AreaNavigation")
                        .WithMany("Agents")
                        .HasForeignKey("Area")
                        .HasConstraintName("FK_agent_trade_info")
                        .IsRequired();

                    b.Navigation("AreaNavigation");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Estate", b =>
                {
                    b.HasOne("RealEstateAgencyAPI.Models.Address", "AddressNavigation")
                        .WithMany("Estates")
                        .HasForeignKey("Address")
                        .HasConstraintName("FK_estate_address");

                    b.HasOne("RealEstateAgencyAPI.Models.Status", "PropertyStatusNavigation")
                        .WithMany("Estates")
                        .HasForeignKey("PropertyStatus")
                        .HasConstraintName("FK_estate_status");

                    b.HasOne("RealEstateAgencyAPI.Models.TradeInfo", "PropertyTypeNavigation")
                        .WithMany("Estates")
                        .HasForeignKey("PropertyType")
                        .HasConstraintName("FK_estate_trade_type");

                    b.Navigation("AddressNavigation");

                    b.Navigation("PropertyStatusNavigation");

                    b.Navigation("PropertyTypeNavigation");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Meeting", b =>
                {
                    b.HasOne("RealEstateAgencyAPI.Models.Agent", "AgentNavigation")
                        .WithMany("Meetings")
                        .HasForeignKey("Agent")
                        .HasConstraintName("FK_meetings_agent");

                    b.HasOne("RealEstateAgencyAPI.Models.Address", "EstateAddressNavigation")
                        .WithMany("Meetings")
                        .HasForeignKey("EstateAddress")
                        .HasConstraintName("FK_meetings_address");

                    b.HasOne("RealEstateAgencyAPI.Models.Status", "StatusNavigation")
                        .WithMany("Meetings")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_meetings_status");

                    b.Navigation("AgentNavigation");

                    b.Navigation("EstateAddressNavigation");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Offer", b =>
                {
                    b.HasOne("RealEstateAgencyAPI.Models.Agent", "AgentNavigation")
                        .WithMany("Offers")
                        .HasForeignKey("Agent")
                        .HasConstraintName("FK_offer_agent");

                    b.HasOne("RealEstateAgencyAPI.Models.TradeInfo", "AreaNavigation")
                        .WithMany("Offers")
                        .HasForeignKey("Area")
                        .HasConstraintName("FK_offer_trade_info");

                    b.HasOne("RealEstateAgencyAPI.Models.Estate", "EstateNavigation")
                        .WithMany("Offers")
                        .HasForeignKey("Estate")
                        .HasConstraintName("FK_offer_estate");

                    b.HasOne("RealEstateAgencyAPI.Models.Status", "OfferStatusNavigation")
                        .WithMany("Offers")
                        .HasForeignKey("OfferStatus")
                        .HasConstraintName("FK_offer_status");

                    b.Navigation("AgentNavigation");

                    b.Navigation("AreaNavigation");

                    b.Navigation("EstateNavigation");

                    b.Navigation("OfferStatusNavigation");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Photo", b =>
                {
                    b.HasOne("RealEstateAgencyAPI.Models.Estate", "EstateNavigation")
                        .WithMany("Photos")
                        .HasForeignKey("Estate")
                        .HasConstraintName("FK_photo_estate");

                    b.Navigation("EstateNavigation");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Request", b =>
                {
                    b.HasOne("RealEstateAgencyAPI.Models.TradeInfo", "ServiceNavigation")
                        .WithMany("Requests")
                        .HasForeignKey("Service")
                        .HasConstraintName("FK_request_trade_info")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateAgencyAPI.Models.Status", "StatusNavigation")
                        .WithMany("Requests")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_request_status")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceNavigation");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Address", b =>
                {
                    b.Navigation("Estates");

                    b.Navigation("Meetings");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Agent", b =>
                {
                    b.Navigation("Meetings");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Estate", b =>
                {
                    b.Navigation("Offers");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.Status", b =>
                {
                    b.Navigation("Estates");

                    b.Navigation("Meetings");

                    b.Navigation("Offers");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("RealEstateAgencyAPI.Models.TradeInfo", b =>
                {
                    b.Navigation("Agents");

                    b.Navigation("Estates");

                    b.Navigation("Offers");

                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
