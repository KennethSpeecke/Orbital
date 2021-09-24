using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateApplicationUserCommentNavProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34d82894-cd34-40a6-a19e-881ca98451f7",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "1a49bbc4-e24b-43e2-b924-d937c8696b42", "ApplicationUser", "2ca9cd8c-c603-45bb-8e38-4c3a33c1db21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86b9ff3d-5188-43e5-9c8d-f7f46823ce73",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "e0fcb6ee-c14e-4f60-a524-a409667f50fe", "ApplicationUser", "7c23f9e3-29f9-4ade-bc64-146822bf187b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d5213cb-1abc-43e3-a4d6-35b92e829f6f",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "8af86ff3-d769-4ff4-a3b7-774139882bbc", "ApplicationUser", "9379cd17-a781-4dcb-aa9c-ceb87ac8b20f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f3599b-ba5d-4799-8fd4-77a7e4023be6",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "61ba11b9-f620-4c59-aa77-b6fc99862af5", "ApplicationUser", "2a4185ee-af97-429f-b90f-323d0f41ab6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ced8f1e3-fbab-4db1-99a1-fa45b1428c21",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "SecurityStamp" },
                values: new object[] { "5f2e17f9-bcb9-4090-beff-fc4e7c23df34", "ApplicationUser", "e5ff9864-ae76-49f7-96e2-f6ad1f65d613" });
        }
    }
}
