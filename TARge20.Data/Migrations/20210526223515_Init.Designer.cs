// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20210526223515_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.AccessPermit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AccessPermit");
                });

            modelBuilder.Entity("TARge20.Core.Domain.BranchOffice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("BranchOffice");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdentificationCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("RegNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AtWork")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("BranchOfficeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdentificationCode")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchOfficeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.HealthCheck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("HealthCheck");
                });

            modelBuilder.Entity("TARge20.Core.Domain.JobTitle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Renting", b =>
                {
                    b.Property<Guid>("RentingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ThingsToRentThingToRentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RentingId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ThingsToRentThingToRentId");

                    b.ToTable("Renting");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeave", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SickLeave");
                });

            modelBuilder.Entity("TARge20.Core.Domain.ThingsToRent", b =>
                {
                    b.Property<Guid>("ThingToRentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ThingToRentId");

                    b.ToTable("ThingsToRent");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.Property<Guid>("VacationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VacationTypeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Vacation");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Working", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchOfficeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("JobTitleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BranchOfficeId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Working");
                });

            modelBuilder.Entity("TARge20.Core.Domain.AccessPermit", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("AccessPermits")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.BranchOffice", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Company", "Company")
                        .WithMany("BranchOffices")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Children", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Childrens")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.HasOne("TARge20.Core.Domain.BranchOffice", "BranchOffice")
                        .WithMany()
                        .HasForeignKey("BranchOfficeId");

                    b.Navigation("BranchOffice");
                });

            modelBuilder.Entity("TARge20.Core.Domain.HealthCheck", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("HealthChecks")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.JobTitle", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("JobTitles")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Renting", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Rentings")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.ThingsToRent", "ThingsToRent")
                        .WithMany("Renting")
                        .HasForeignKey("ThingsToRentThingToRentId");

                    b.Navigation("Employee");

                    b.Navigation("ThingsToRent");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeave", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("SickLeaves")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacation", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Working", b =>
                {
                    b.HasOne("TARge20.Core.Domain.BranchOffice", "BranchOffice")
                        .WithMany()
                        .HasForeignKey("BranchOfficeId");

                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Workings")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.JobTitle", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobTitleId");

                    b.Navigation("BranchOffice");

                    b.Navigation("Employee");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Navigation("BranchOffices");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Navigation("AccessPermits");

                    b.Navigation("Childrens");

                    b.Navigation("HealthChecks");

                    b.Navigation("JobTitles");

                    b.Navigation("Rentings");

                    b.Navigation("SickLeaves");

                    b.Navigation("Vacations");

                    b.Navigation("Workings");
                });

            modelBuilder.Entity("TARge20.Core.Domain.ThingsToRent", b =>
                {
                    b.Navigation("Renting");
                });
#pragma warning restore 612, 618
        }
    }
}
