﻿// <auto-generated />
using System;
using Jobber.IO.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jobber.IO.Data.Migrations
{
    [DbContext(typeof(JobberContext))]
    [Migration("20200118180413_INITIAL_CREATE")]
    partial class INITIAL_CREATE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jobber.IO.Business.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<int>("KindOfCompany")
                        .HasColumnType("int");

                    b.Property<int>("KindPlan")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("KindPlan")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.JobOffer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("KindOccupation")
                        .HasColumnType("int");

                    b.Property<int>("Long")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobOffers");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Occupation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("JobOfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobOfferId")
                        .IsUnique();

                    b.ToTable("Occupations");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobOfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Tech", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobOfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobOfferId");

                    b.ToTable("Techs");
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Address", b =>
                {
                    b.HasOne("Jobber.IO.Business.Models.Company", "Company")
                        .WithOne("Address")
                        .HasForeignKey("Jobber.IO.Business.Models.Address", "CompanyId")
                        .IsRequired();

                    b.HasOne("Jobber.IO.Business.Models.Employee", "Employee")
                        .WithOne("Address")
                        .HasForeignKey("Jobber.IO.Business.Models.Address", "EmployeeId")
                        .IsRequired();
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.JobOffer", b =>
                {
                    b.HasOne("Jobber.IO.Business.Models.Company", "Company")
                        .WithMany("JobOffers")
                        .HasForeignKey("CompanyId")
                        .IsRequired();
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Occupation", b =>
                {
                    b.HasOne("Jobber.IO.Business.Models.Employee", "Employee")
                        .WithMany("Occupations")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();

                    b.HasOne("Jobber.IO.Business.Models.JobOffer", "JobOffer")
                        .WithOne("Occupation")
                        .HasForeignKey("Jobber.IO.Business.Models.Occupation", "JobOfferId")
                        .IsRequired();
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Skill", b =>
                {
                    b.HasOne("Jobber.IO.Business.Models.Employee", "Employee")
                        .WithMany("Skills")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();

                    b.HasOne("Jobber.IO.Business.Models.JobOffer", "JobOffer")
                        .WithMany("Skills")
                        .HasForeignKey("JobOfferId")
                        .IsRequired();
                });

            modelBuilder.Entity("Jobber.IO.Business.Models.Tech", b =>
                {
                    b.HasOne("Jobber.IO.Business.Models.Employee", "Employee")
                        .WithMany("Techs")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();

                    b.HasOne("Jobber.IO.Business.Models.JobOffer", "JobOffer")
                        .WithMany("Techs")
                        .HasForeignKey("JobOfferId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
