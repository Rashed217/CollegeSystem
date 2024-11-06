﻿// <auto-generated />
using CollegeSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CollegeSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241106080045_InitializeDB")]
    partial class InitializeDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CollegeSystem.Course", b =>
                {
                    b.Property<int>("CrsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CrsId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("CrsId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CollegeSystem.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"));

                    b.HasKey("DeptId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CollegeSystem.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.HasKey("ExamId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("CollegeSystem.Faculty", b =>
                {
                    b.Property<int>("FacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("FacId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("CollegeSystem.FacultyMobile", b =>
                {
                    b.Property<int>("FMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FMId"));

                    b.Property<int>("FId")
                        .HasColumnType("int");

                    b.HasKey("FMId");

                    b.HasIndex("FId");

                    b.ToTable("FacultiesMobiles");
                });

            modelBuilder.Entity("CollegeSystem.Hostel", b =>
                {
                    b.Property<int>("HostelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HostelId"));

                    b.HasKey("HostelId");

                    b.ToTable("Hostels");
                });

            modelBuilder.Entity("CollegeSystem.Student", b =>
                {
                    b.Property<int>("StId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("HostelId")
                        .HasColumnType("int");

                    b.HasKey("StId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("HostelId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CollegeSystem.StudentPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SId");

                    b.ToTable("StudentPhones");
                });

            modelBuilder.Entity("CollegeSystem.Subject", b =>
                {
                    b.Property<int>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubId"));

                    b.Property<int>("FId")
                        .HasColumnType("int");

                    b.HasKey("SubId");

                    b.HasIndex("FId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CollegeSystem.Course", b =>
                {
                    b.HasOne("CollegeSystem.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CollegeSystem.Faculty", b =>
                {
                    b.HasOne("CollegeSystem.Department", "Department")
                        .WithMany("Faculties")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CollegeSystem.FacultyMobile", b =>
                {
                    b.HasOne("CollegeSystem.Faculty", "Faculty")
                        .WithMany("FacultyMobiles")
                        .HasForeignKey("FId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("CollegeSystem.Student", b =>
                {
                    b.HasOne("CollegeSystem.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeSystem.Hostel", "Hostel")
                        .WithMany("Students")
                        .HasForeignKey("HostelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Hostel");
                });

            modelBuilder.Entity("CollegeSystem.StudentPhone", b =>
                {
                    b.HasOne("CollegeSystem.Student", "Student")
                        .WithMany("StudentPhones")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CollegeSystem.Subject", b =>
                {
                    b.HasOne("CollegeSystem.Faculty", "Faculty")
                        .WithMany("Subjects")
                        .HasForeignKey("FId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("CollegeSystem.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Faculties");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("CollegeSystem.Faculty", b =>
                {
                    b.Navigation("FacultyMobiles");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("CollegeSystem.Hostel", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("CollegeSystem.Student", b =>
                {
                    b.Navigation("StudentPhones");
                });
#pragma warning restore 612, 618
        }
    }
}
