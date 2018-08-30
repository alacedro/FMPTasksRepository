using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AngularTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Active_Status = table.Column<string>(nullable: true),
                    Apr_x_per_wk = table.Column<decimal>(nullable: false),
                    Aug_x_per_wk = table.Column<decimal>(nullable: false),
                    Customer = table.Column<string>(nullable: true),
                    Dec_x_per_wk = table.Column<decimal>(nullable: false),
                    Feb_x_per_wk = table.Column<decimal>(nullable: false),
                    Jul_x_per_wk = table.Column<decimal>(nullable: false),
                    Jun_x_per_wk = table.Column<decimal>(nullable: false),
                    Mar_x_per_wk = table.Column<decimal>(nullable: false),
                    May_x_per_wk = table.Column<decimal>(nullable: false),
                    Month1 = table.Column<decimal>(nullable: false),
                    Month10 = table.Column<decimal>(nullable: false),
                    Month11 = table.Column<decimal>(nullable: false),
                    Month12 = table.Column<decimal>(nullable: false),
                    Month2 = table.Column<decimal>(nullable: false),
                    Month3 = table.Column<decimal>(nullable: false),
                    Month4 = table.Column<decimal>(nullable: false),
                    Month5 = table.Column<decimal>(nullable: false),
                    Month6 = table.Column<decimal>(nullable: false),
                    Month7 = table.Column<decimal>(nullable: false),
                    Month8 = table.Column<decimal>(nullable: false),
                    Month9 = table.Column<decimal>(nullable: false),
                    Nov_x_per_wk = table.Column<decimal>(nullable: false),
                    Oct_x_per_wk = table.Column<decimal>(nullable: false),
                    Post_Tax_Client_Price = table.Column<string>(nullable: true),
                    Pre_Tax_Client_Price = table.Column<string>(nullable: true),
                    Provider_Cost = table.Column<string>(nullable: true),
                    Request_Code = table.Column<string>(nullable: true),
                    Request_Type = table.Column<string>(nullable: true),
                    Sep_x_per_wk = table.Column<int>(nullable: false),
                    Service_Day = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Store = table.Column<string>(nullable: true),
                    Tax_Rate = table.Column<decimal>(nullable: true),
                    Times_Per_Week = table.Column<decimal>(nullable: false),
                    Vendor = table.Column<string>(nullable: true),
                    Work_Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
