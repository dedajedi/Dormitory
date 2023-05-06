﻿// <auto-generated />
using System;
using Dormitory.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dormitory.Migrations
{
    [DbContext(typeof(DormitoryContext))]
    [Migration("20230506090143_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dormitory.DAL.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Tittle")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Dormitory.DAL.Application", b =>
                {
                    b.Property<int?>("Announcement")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApplicationDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasIndex(new[] { "Id" }, "IX_Applications_Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Dormitory.DAL.Dormitory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Dormitories");
                });

            modelBuilder.Entity("Dormitory.DAL.Room", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("DormitoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Dormitory.DAL.RoomStudent", b =>
                {
                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasIndex(new[] { "RoomId" }, "IX_RoomStudent_RoomId");

                    b.HasIndex(new[] { "StudentId" }, "IX_RoomStudent_StudentID");

                    b.ToTable("RoomStudent", (string)null);
                });

            modelBuilder.Entity("Dormitory.DAL.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("Dormitory.DAL.Application", b =>
                {
                    b.HasOne("Dormitory.DAL.Announcement", "IdNavigation")
                        .WithMany()
                        .HasForeignKey("Id")
                        .HasConstraintName("FK_Applications_Announcements");

                    b.HasOne("Dormitory.DAL.Student", "Id1")
                        .WithMany()
                        .HasForeignKey("Id")
                        .HasConstraintName("FK_Applications_Student");

                    b.Navigation("Id1");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Dormitory.DAL.Room", b =>
                {
                    b.HasOne("Dormitory.DAL.Dormitory", "IdNavigation")
                        .WithOne("Room")
                        .HasForeignKey("Dormitory.DAL.Room", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_Rooms_Dormitories");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Dormitory.DAL.RoomStudent", b =>
                {
                    b.HasOne("Dormitory.DAL.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .IsRequired()
                        .HasConstraintName("FK_RoomStudent_Rooms");

                    b.HasOne("Dormitory.DAL.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_RoomStudent_Student");

                    b.Navigation("Room");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Dormitory.DAL.Dormitory", b =>
                {
                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
