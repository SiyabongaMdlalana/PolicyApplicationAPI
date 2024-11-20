using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolicyApplicationAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolicyHolders",
                columns: table => new
                {
                    PolicyHolderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyHolderIdNumber = table.Column<string>(type: "nvarchar(13)", nullable: true),
                    PolicyHolderInitial = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    PolicyHolderSurname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PolicyHolderDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PolicyHolderGender = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    PolicyHolderPolicyNumber = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PolicyHolderPolicyType = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PolicyHolderCommenmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PolicyHolderInstallmentAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyHolderEmail = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageAltDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyHolders", x => x.PolicyHolderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyHolders");
        }
    }
}
