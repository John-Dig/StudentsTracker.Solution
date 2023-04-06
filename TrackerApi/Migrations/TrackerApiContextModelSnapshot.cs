﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackerApi.Models;

#nullable disable

namespace TrackerApi.Migrations
{
    [DbContext(typeof(TrackerApiContext))]
    partial class TrackerApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TrackerApi.Models.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BeltId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstN")
                        .HasColumnType("longtext");

                    b.Property<string>("LastN")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("CoachId");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            CoachId = 1,
                            BeltId = 15,
                            Email = "JimmyCoacher@email.com",
                            FirstN = "Jimmy",
                            LastN = "Coacher",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CoachId = 2,
                            BeltId = 10,
                            Email = "SallyAwesome@email.com",
                            FirstN = "Sally",
                            LastN = "Awesome",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            CoachId = 3,
                            BeltId = 8,
                            Email = "SueSensei@email.com",
                            FirstN = "Sue",
                            LastN = "Sensei",
                            Phone = "555-555-5555"
                        });
                });

            modelBuilder.Entity("TrackerApi.Models.Promotion", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PromotionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("PromotionId");

                    b.HasIndex("CoachId");

                    b.HasIndex("StudentId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("TrackerApi.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BeltId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEnrolled")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstN")
                        .HasColumnType("longtext");

                    b.Property<string>("LastN")
                        .HasColumnType("longtext");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BeltId = 1,
                            DateEnrolled = new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9280),
                            Email = "JohnDoe@email.com",
                            FirstN = "John",
                            LastN = "Doe"
                        },
                        new
                        {
                            StudentId = 2,
                            BeltId = 2,
                            DateEnrolled = new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9330),
                            Email = "JaneDoe@email.com",
                            FirstN = "Jane",
                            LastN = "Doe"
                        },
                        new
                        {
                            StudentId = 3,
                            BeltId = 13,
                            DateEnrolled = new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9340),
                            Email = "JohnnyBravo@email.com",
                            FirstN = "Johnny",
                            LastN = "Bravo"
                        },
                        new
                        {
                            StudentId = 4,
                            BeltId = 20,
                            DateEnrolled = new DateTime(2023, 4, 6, 9, 4, 0, 316, DateTimeKind.Local).AddTicks(9340),
                            Email = "SamuraiJack@email.com",
                            FirstN = "Samurai",
                            LastN = "Jack"
                        });
                });

            modelBuilder.Entity("TrackerApi.Models.Promotion", b =>
                {
                    b.HasOne("TrackerApi.Models.Coach", "Coach")
                        .WithMany("Promotions")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackerApi.Models.Student", "Student")
                        .WithMany("Promotions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TrackerApi.Models.Coach", b =>
                {
                    b.Navigation("Promotions");
                });

            modelBuilder.Entity("TrackerApi.Models.Student", b =>
                {
                    b.Navigation("Promotions");
                });
#pragma warning restore 612, 618
        }
    }
}
