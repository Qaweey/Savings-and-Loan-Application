using Microsoft.EntityFrameworkCore.Migrations;

namespace SavingandLoanProject.Data.Migrations
{
    public partial class myinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostumersProfiles",
                columns: table => new
                {
                    CustomersProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BVNNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    SavingsId = table.Column<int>(type: "int", nullable: false),
                    LoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostumersProfiles", x => x.CustomersProfileId);
                });

            migrationBuilder.CreateTable(
                name: "SavingsPlans",
                columns: table => new
                {
                    SavingsPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsPlans", x => x.SavingsPlanId);
                });

            migrationBuilder.CreateTable(
                name: "loanProfiles",
                columns: table => new
                {
                    LoansProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amountborrowed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountToPayBack = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TargetAmountToPayBack = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomersProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanProfiles", x => x.LoansProfileId);
                    table.ForeignKey(
                        name: "FK_loanProfiles_CostumersProfiles_CustomersProfileId",
                        column: x => x.CustomersProfileId,
                        principalTable: "CostumersProfiles",
                        principalColumn: "CustomersProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingsProfiles",
                columns: table => new
                {
                    SavingsProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountSaved = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfMonth = table.Column<int>(type: "int", nullable: false),
                    TotalAmountToWithdraw = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomersProfileId = table.Column<int>(type: "int", nullable: false),
                    SavingsPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsProfiles", x => x.SavingsProfileId);
                    table.ForeignKey(
                        name: "FK_SavingsProfiles_CostumersProfiles_CustomersProfileId",
                        column: x => x.CustomersProfileId,
                        principalTable: "CostumersProfiles",
                        principalColumn: "CustomersProfileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavingsProfiles_SavingsPlans_SavingsPlanId",
                        column: x => x.SavingsPlanId,
                        principalTable: "SavingsPlans",
                        principalColumn: "SavingsPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_loanProfiles_CustomersProfileId",
                table: "loanProfiles",
                column: "CustomersProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsProfiles_CustomersProfileId",
                table: "SavingsProfiles",
                column: "CustomersProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingsProfiles_SavingsPlanId",
                table: "SavingsProfiles",
                column: "SavingsPlanId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loanProfiles");

            migrationBuilder.DropTable(
                name: "SavingsProfiles");

            migrationBuilder.DropTable(
                name: "CostumersProfiles");

            migrationBuilder.DropTable(
                name: "SavingsPlans");
        }
    }
}
