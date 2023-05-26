﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using practical.MVC.Entities;

namespace practical.MVC.Migration
{
    [DbContext(typeof(DataContext))]
    [Migration("20230526131936_fi")]
    partial class fi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Class", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.HasKey("Id");

                b.ToTable("classes");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Exam", b =>
            {
                b.Property<int>("ExamId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                b.Property<DateTime>("ExamDate")
                    .HasColumnType("datetime2");

                b.Property<TimeSpan>("ExamDuration")
                    .HasColumnType("time");

                b.Property<DateTime>("StartTime")
                    .HasColumnType("datetime2");

                b.Property<int?>("classesId")
                    .HasColumnType("int");

                b.Property<int?>("facultysId")
                    .HasColumnType("int");

                b.Property<string>("status")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("subjectsId")
                    .HasColumnType("int");

                b.HasKey("ExamId");

                b.HasIndex("classesId");

                b.HasIndex("facultysId");

                b.HasIndex("subjectsId");

                b.ToTable("exams");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Faculty", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.HasKey("Id");

                b.ToTable("faculty");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Subject", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnType("nvarchar(255)");

                b.HasKey("Id");

                b.ToTable("subject");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Exam", b =>
            {
                b.HasOne("PRACTICAL_EXAM_NET.Entities.Class", "classes")
                    .WithMany("exams")
                    .HasForeignKey("classesId");

                b.HasOne("PRACTICAL_EXAM_NET.Entities.Faculty", "facultys")
                    .WithMany("exams")
                    .HasForeignKey("facultysId");

                b.HasOne("PRACTICAL_EXAM_NET.Entities.Subject", "subjects")
                    .WithMany("exams")
                    .HasForeignKey("subjectsId");

                b.Navigation("classes");

                b.Navigation("facultys");

                b.Navigation("subjects");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Class", b =>
            {
                b.Navigation("exams");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Faculty", b =>
            {
                b.Navigation("exams");
            });

            modelBuilder.Entity("PRACTICAL_EXAM_NET.Entities.Subject", b =>
            {
                b.Navigation("exams");
            });
#pragma warning restore 612, 618
        }
    }
}
