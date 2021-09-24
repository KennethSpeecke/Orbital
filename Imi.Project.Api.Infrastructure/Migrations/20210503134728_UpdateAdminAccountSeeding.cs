using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateAdminAccountSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", "47b4def6-770c-4df9-ab97-c010904574a6" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b4def6-770c-4df9-ab97-c010904574a6",
                column: "ConcurrencyStamp",
                value: "b2739f56-a870-405a-a6b5-a94ddc39e1ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db2ad43a-9f3f-45fd-8b28-068dbc58b799",
                column: "ConcurrencyStamp",
                value: "5adb5f6e-d1a2-421b-9776-b81dba4699ee");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "22c71128-83a4-4f4f-bdcb-7a4ac4ede03c", "47b4def6-770c-4df9-ab97-c010904574a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34d82894-cd34-40a6-a19e-881ca98451f7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec2141ce-013c-43b1-8cc8-09e7cdb2b534", "ef5b45d3-2ec2-4ad3-9eda-8b6a6fbcb84c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86b9ff3d-5188-43e5-9c8d-f7f46823ce73",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57505fc9-9a1f-41a8-a303-cd3e6842160f", "cac50463-38e6-436b-8d4b-97c834e6e04d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d5213cb-1abc-43e3-a4d6-35b92e829f6f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c79df2a1-edb0-4769-8c69-9e5541094452", "1717d365-7e30-4895-bbe6-c6fda3b4d219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f3599b-ba5d-4799-8fd4-77a7e4023be6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9dcefdbb-5c4a-4442-a2c1-fd8a71335532", "1d85e072-0142-4338-a6e5-80a5c343fa81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced8f1e3-fbab-4db1-99a1-fa45b1428c21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e496d1a-777b-4203-95d3-b47b81ee5406", "b66e728d-5c5a-4a48-85ca-c4ca5ecc147d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "22c71128-83a4-4f4f-bdcb-7a4ac4ede03c", "47b4def6-770c-4df9-ab97-c010904574a6" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b4def6-770c-4df9-ab97-c010904574a6",
                column: "ConcurrencyStamp",
                value: "f3e890d9-539a-473a-ac27-e5b6383b98be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db2ad43a-9f3f-45fd-8b28-068dbc58b799",
                column: "ConcurrencyStamp",
                value: "4c8bd4d1-1efb-4812-b8da-afc1d0258c19");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", "47b4def6-770c-4df9-ab97-c010904574a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34d82894-cd34-40a6-a19e-881ca98451f7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "049809b3-22b5-460e-b373-fb64b117478c", "2c50a6c9-5720-42ab-8bb7-d88e4e96fac2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86b9ff3d-5188-43e5-9c8d-f7f46823ce73",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aaad324-d0aa-4196-bf0c-1c067e2f20ad", "cdcfe28b-30b0-4d75-8d80-4953543a9675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d5213cb-1abc-43e3-a4d6-35b92e829f6f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2f4d502-d918-4d91-83a8-f06cd7266ff1", "a4f88c32-4b58-4a39-b43f-ca6f0ee51856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f3599b-ba5d-4799-8fd4-77a7e4023be6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd91fe5f-1ab5-4f6e-9e4c-005960067b25", "3c82b770-e81b-4a47-89d6-3b584fdae8bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced8f1e3-fbab-4db1-99a1-fa45b1428c21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8c2404a-35c2-4cc7-b719-80af05531dc3", "4891ac29-4cc1-44e5-b8ec-2f22801d900b" });
        }
    }
}
