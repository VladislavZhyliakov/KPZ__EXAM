﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Oleg",
                            LastName = "Sencov"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "John",
                            LastName = "Travolta"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Johnathan",
                            LastName = "Joestar"
                        });
                });

            modelBuilder.Entity("Domain.Entities.StudentUniTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<bool?>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("UniTaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("UniTaskId");

                    b.ToTable("StudentUniTasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Grade = 5,
                            IsPresent = true,
                            StudentId = 1,
                            UniTaskId = 1
                        },
                        new
                        {
                            Id = 2,
                            Grade = 0,
                            IsPresent = false,
                            StudentId = 1,
                            UniTaskId = 2
                        },
                        new
                        {
                            Id = 3,
                            Grade = 5,
                            IsPresent = true,
                            StudentId = 1,
                            UniTaskId = 3
                        },
                        new
                        {
                            Id = 4,
                            Grade = 3,
                            IsPresent = true,
                            StudentId = 2,
                            UniTaskId = 1
                        },
                        new
                        {
                            Id = 5,
                            Grade = 4,
                            IsPresent = true,
                            StudentId = 2,
                            UniTaskId = 2
                        },
                        new
                        {
                            Id = 6,
                            Grade = 5,
                            IsPresent = true,
                            StudentId = 2,
                            UniTaskId = 3
                        },
                        new
                        {
                            Id = 7,
                            Grade = 0,
                            IsPresent = false,
                            StudentId = 3,
                            UniTaskId = 1
                        },
                        new
                        {
                            Id = 8,
                            Grade = 4,
                            IsPresent = true,
                            StudentId = 3,
                            UniTaskId = 2
                        },
                        new
                        {
                            Id = 9,
                            Grade = 3,
                            IsPresent = true,
                            StudentId = 3,
                            UniTaskId = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.UniTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TaskDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("UniTasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lab1",
                            Priority = "Mid",
                            TaskDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lab2",
                            Priority = "Mid",
                            TaskDate = new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Description = "KR",
                            Priority = "High",
                            TaskDate = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.StudentUniTask", b =>
                {
                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany("StudentUniTasks")
                        .HasForeignKey("StudentId");

                    b.HasOne("Domain.Entities.UniTask", "UniTask")
                        .WithMany("StudentUniTasks")
                        .HasForeignKey("UniTaskId");

                    b.Navigation("Student");

                    b.Navigation("UniTask");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Navigation("StudentUniTasks");
                });

            modelBuilder.Entity("Domain.Entities.UniTask", b =>
                {
                    b.Navigation("StudentUniTasks");
                });
#pragma warning restore 612, 618
        }
    }
}