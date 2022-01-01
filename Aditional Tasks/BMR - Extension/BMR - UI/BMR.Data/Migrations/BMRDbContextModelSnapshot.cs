﻿// <auto-generated />
using System;
using BMR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BMR.Data.Migrations
{
    [DbContext(typeof(BMRDbContext))]
    partial class BMRDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BMR.Models.Data.Models.Activity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("BMR.Models.Data.Models.BasalMetabolicRate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ActivityId")
                        .HasColumnType("bigint");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<double>("BMR")
                        .HasColumnType("float");

                    b.Property<double>("BMRWithActivity")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("UserId");

                    b.ToTable("BMRS");
                });

            modelBuilder.Entity("BMR.Models.Data.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BMR.Models.Data.Models.BasalMetabolicRate", b =>
                {
                    b.HasOne("BMR.Models.Data.Models.Activity", "Activity")
                        .WithMany("BMRS")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK_BMRS_Activities")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BMR.Models.Data.Models.User", "User")
                        .WithMany("BMRS")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_BMRS_Users")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BMR.Models.Data.Models.Activity", b =>
                {
                    b.Navigation("BMRS");
                });

            modelBuilder.Entity("BMR.Models.Data.Models.User", b =>
                {
                    b.Navigation("BMRS");
                });
#pragma warning restore 612, 618
        }
    }
}
