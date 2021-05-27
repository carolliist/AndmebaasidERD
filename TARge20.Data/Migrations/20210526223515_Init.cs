using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThingsToRent",
                columns: table => new
                {
                    ThingToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThingsToRent", x => x.ThingToRentId);
                });

            migrationBuilder.CreateTable(
                name: "BranchOffice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchOffice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchOffice_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalIdentificationCode = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    AtWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchOfficeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_BranchOffice_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccessPermit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessPermit_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalIdentificationCode = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealthCheck",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCheck_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitle_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Renting",
                columns: table => new
                {
                    RentingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThingsToRentThingToRentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renting", x => x.RentingId);
                    table.ForeignKey(
                        name: "FK_Renting_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Renting_ThingsToRent_ThingsToRentThingToRentId",
                        column: x => x.ThingsToRentThingToRentId,
                        principalTable: "ThingsToRent",
                        principalColumn: "ThingToRentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SickLeave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SickLeave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SickLeave_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    VacationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.VacationTypeId);
                    table.ForeignKey(
                        name: "FK_Vacation_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Working",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchOfficeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Working", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Working_BranchOffice_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Working_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Working_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessPermit_EmployeeId",
                table: "AccessPermit",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_CompanyId",
                table: "BranchOffice",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_EmployeeId",
                table: "Children",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchOfficeId",
                table: "Employee",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCheck_EmployeeId",
                table: "HealthCheck",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_EmployeeId",
                table: "JobTitle",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Renting_EmployeeId",
                table: "Renting",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Renting_ThingsToRentThingToRentId",
                table: "Renting",
                column: "ThingsToRentThingToRentId");

            migrationBuilder.CreateIndex(
                name: "IX_SickLeave_EmployeeId",
                table: "SickLeave",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_EmployeeId",
                table: "Vacation",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Working_BranchOfficeId",
                table: "Working",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Working_EmployeeId",
                table: "Working",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Working_JobTitleId",
                table: "Working",
                column: "JobTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessPermit");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "HealthCheck");

            migrationBuilder.DropTable(
                name: "Renting");

            migrationBuilder.DropTable(
                name: "SickLeave");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "Working");

            migrationBuilder.DropTable(
                name: "ThingsToRent");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "BranchOffice");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
