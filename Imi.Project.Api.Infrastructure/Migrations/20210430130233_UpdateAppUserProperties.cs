using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateAppUserProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34d82894-cd34-40a6-a19e-881ca98451f7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e188e14-6707-4e2a-88f2-e0d29b5d0eeb", "5a6fe340-9cb5-4508-9f93-a282ce10d2b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86b9ff3d-5188-43e5-9c8d-f7f46823ce73",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d69276f1-290f-4959-acf3-56c231b758f1", "6f7dda90-6ebd-4037-bf27-9ec587573687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d5213cb-1abc-43e3-a4d6-35b92e829f6f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "525630af-031f-4082-a053-e1fc9852a4a7", "fd837bdd-48fb-4408-80ee-19f84fa9df47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f3599b-ba5d-4799-8fd4-77a7e4023be6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51a499d7-c4f4-4a2b-a65a-062e79f2ca36", "c1f37c9b-89af-402d-8ced-288b666625bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced8f1e3-fbab-4db1-99a1-fa45b1428c21",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6d75d4f-44c6-4bb1-ae97-a9fd548cccd6", "b67ff0e2-b39e-4465-91e1-8b6b5ee50c67" });
        }
    }
}
