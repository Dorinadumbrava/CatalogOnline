﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20190409115842_Renamed StudentClasses to Courses")]
    partial class RenamedStudentClassestoCourses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Domain.Entities.CourseTeacher", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<int>("TeacherId");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("CourseTeacher");
                });

            modelBuilder.Entity("Domain.Entities.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("DisciplineId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("StudentClassId");

                    b.HasKey("StudentId");

                    b.HasIndex("StudentClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Domain.Entities.StudentDiscipline", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("DisciplineId");

                    b.HasKey("StudentId", "DisciplineId");

                    b.ToTable("StudentDiscipline");
                });

            modelBuilder.Entity("Domain.Entities.StudentMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("DisciplineId");

                    b.Property<byte>("MarkValue");

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentMarks");
                });

            modelBuilder.Entity("Domain.Entities.StudentTeacher", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("TeachersId");

                    b.HasKey("StudentId", "TeachersId");

                    b.HasIndex("TeachersId");

                    b.ToTable("StudentTeacher");
                });

            modelBuilder.Entity("Domain.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree");

                    b.Property<string>("FirstName");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Domain.Entities.TeacherDiscipline", b =>
                {
                    b.Property<int>("TeacherId");

                    b.Property<int>("DisciplineId");

                    b.HasKey("TeacherId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("TeacherDiscipline");
                });

            modelBuilder.Entity("Domain.Entities.CourseTeacher", b =>
                {
                    b.HasOne("Domain.Entities.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasOne("Domain.Entities.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("StudentClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.StudentDiscipline", b =>
                {
                    b.HasOne("Domain.Entities.Discipline", "Discipline")
                        .WithMany("Students")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany("Disciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.StudentMark", b =>
                {
                    b.HasOne("Domain.Entities.Discipline", "Discipline")
                        .WithMany("Marks")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Teacher", "Teacher")
                        .WithMany("Marks")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.StudentTeacher", b =>
                {
                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany("Teachers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeachersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.TeacherDiscipline", b =>
                {
                    b.HasOne("Domain.Entities.Discipline", "Discipline")
                        .WithMany("Teachers")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
