using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateAppUserRolesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[,]
                {
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", "47b4def6-770c-4df9-ab97-c010904574a6" },
                    { "ced8f1e3-fbab-4db1-99a1-fa45b1428c21", "db2ad43a-9f3f-45fd-8b28-068dbc58b799" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", "47b4def6-770c-4df9-ab97-c010904574a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ced8f1e3-fbab-4db1-99a1-fa45b1428c21", "db2ad43a-9f3f-45fd-8b28-068dbc58b799" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b4def6-770c-4df9-ab97-c010904574a6",
                column: "ConcurrencyStamp",
                value: "d5389fe9-2d56-4bdf-a178-61e40673210f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db2ad43a-9f3f-45fd-8b28-068dbc58b799",
                column: "ConcurrencyStamp",
                value: "1ce7fca4-b406-499f-963d-8bfe2dce2020");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34d82894-cd34-40a6-a19e-881ca98451f7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3bd6060-c880-4a86-933b-8822fbd153cf", "b19ecdef-459d-4fcd-b783-a935458312fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86b9ff3d-5188-43e5-9c8d-f7f46823ce73",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "188d0f8b-a36d-4877-bdf7-ddef1a3b2c6b", "b2bb0600-af85-4afc-8577-ddb1a8ae9727" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d5213cb-1abc-43e3-a4d6-35b92e829f6f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a04495c-1dce-4a32-ac0b-2a4955fb6a1f", "a9ac8935-2aec-44b3-aa46-4d6755ef2625" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f3599b-ba5d-4799-8fd4-77a7e4023be6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0428b1ce-6db4-462d-a472-0d56f7bf1b8d", "2d206797-2262-4535-bf7a-962bc2c519e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced8f1e3-fbab-4db1-99a1-fa45b1428c21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d68e6591-3097-46ec-b976-41ae397312a3", "bb712bc3-276b-4049-afc5-7540d03b41d1" });
        }
    }
}
