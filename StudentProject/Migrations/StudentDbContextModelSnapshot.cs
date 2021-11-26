﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentProject.Model;

namespace StudentProject.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentProject.Model.Cars", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("CarID");

                    b.HasIndex("StudentID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("StudentProject.Model.Cours", b =>
                {
                    b.Property<int>("CoursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoursName")
                        .HasColumnType("int");

                    b.HasKey("CoursID");

                    b.ToTable("Cours");
                });

            modelBuilder.Entity("StudentProject.Model.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("NumSet")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentProject.Model.StudentCours", b =>
                {
                    b.Property<int>("StudentCoursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoursIDFK")
                        .HasColumnType("int");

                    b.Property<int>("StudentIDFK")
                        .HasColumnType("int");

                    b.HasKey("StudentCoursID");

                    b.HasIndex("CoursIDFK");

                    b.HasIndex("StudentIDFK");

                    b.ToTable("StudentCours");
                });

            modelBuilder.Entity("StudentProject.Model.Cars", b =>
                {
                    b.HasOne("StudentProject.Model.Student", "Student")
                        .WithMany("Cars")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("StudentProject.Model.StudentCours", b =>
                {
                    b.HasOne("StudentProject.Model.Cours", "Cours")
                        .WithMany("StudentsER")
                        .HasForeignKey("CoursIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentProject.Model.Student", "Student")
                        .WithMany("CoursRE")
                        .HasForeignKey("StudentIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
