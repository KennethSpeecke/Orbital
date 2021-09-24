using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateAppRolesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47b4def6-770c-4df9-ab97-c010904574a6", "d5389fe9-2d56-4bdf-a178-61e40673210f", "admin", "ADMIN" },
                    { "db2ad43a-9f3f-45fd-8b28-068dbc58b799", "1ce7fca4-b406-499f-963d-8bfe2dce2020", "member", "MEMBER" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b4def6-770c-4df9-ab97-c010904574a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db2ad43a-9f3f-45fd-8b28-068dbc58b799");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34d82894-cd34-40a6-a19e-881ca98451f7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57ce15b5-e265-4500-9c47-e95050cb6e32", "adf87f38-42bb-4d6c-855b-3f864d98194b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86b9ff3d-5188-43e5-9c8d-f7f46823ce73",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddada6d5-461a-4fcc-aebe-f1657a7cd6e0", "abaabd86-c320-4604-9482-26c9b733e46b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d5213cb-1abc-43e3-a4d6-35b92e829f6f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1272bae-fd4d-4fd8-9b63-5f16ea146e1e", "394880d0-d3dc-4940-9c5e-b2bbdce41447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f3599b-ba5d-4799-8fd4-77a7e4023be6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f083d69-0e9e-4333-8053-bce97020c1fa", "857f21dd-f964-4bfb-bf8b-6ea6a7493fd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced8f1e3-fbab-4db1-99a1-fa45b1428c21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "263f87d1-a194-4e45-b4ea-7749fbfe9b9a", "97c928b8-a456-41c2-8f4a-805517b026e1" });
        }
    }
}
