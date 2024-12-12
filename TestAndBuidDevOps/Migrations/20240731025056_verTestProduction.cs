using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAndBuidDevOps.Migrations
{
    /// <inheritdoc />
    public partial class verTestProduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d4b836e-d9fa-4fa9-88c0-9a875d2b7d5c"),
                column: "ConcurrencyStamp",
                value: "744e68d7-e06e-454c-973f-494f342fd6a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab251560-a455-40fd-adfd-54f9e150f874"),
                column: "ConcurrencyStamp",
                value: "89c05a8c-53ed-4400-a3a1-7b0938e1a89f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f91ec0e5-d768-42e2-8926-de7d3162430f"),
                column: "ConcurrencyStamp",
                value: "ada90fe9-9d4d-4e32-957c-0f57ab4c2475");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6aa93c41-f21f-44e3-8f46-7d76b03574c5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "SecurityStamp" },
                values: new object[] { "41f42174-fa07-49bb-827c-e98adfca82b4", new DateTimeOffset(new DateTime(2024, 7, 31, 2, 50, 55, 182, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)), "7b58d628-7e6f-4dab-bfa2-2b726c358de8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "SecurityStamp" },
                values: new object[] { "c6ef703f-dcd2-4580-a1f5-6730e1a3f9f6", new DateTimeOffset(new DateTime(2024, 7, 31, 2, 50, 55, 182, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 0, 0, 0, 0)), "e7fab83b-6a74-47a6-ac68-adb0a5d8fd64" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7f6b60-6e98-4220-93ea-45f64e0f1aa2"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26429623-f8b1-49de-85a3-57e2c370afcb"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("285a8637-e594-4729-b408-67819bb3e3e9"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("453f44f7-e33e-4477-a2ad-a78e232db482"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cda1ac6-7e1f-4f28-84e9-319455fc7016"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b5e16d-7c46-41b8-9b5a-cb00376c4b60"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("772bc058-2e46-4d3f-ac02-3dd4a6a5aced"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f6f4d09-4292-48cc-a8bf-76e7fe0bb961"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("913f130b-c1b6-4a98-8d63-4cf316da3fc1"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1cee7b3-a6ae-4ae3-bcf4-1955129d8197"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff619bfc-5866-4a5b-9a95-9a8a0e457c91"),
                column: "UploadedDate",
                value: new DateTime(2024, 7, 31, 9, 50, 55, 182, DateTimeKind.Utc).AddTicks(1998));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d4b836e-d9fa-4fa9-88c0-9a875d2b7d5c"),
                column: "ConcurrencyStamp",
                value: "196be9ee-9c5f-4ea0-9b88-f2bd050ea434");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab251560-a455-40fd-adfd-54f9e150f874"),
                column: "ConcurrencyStamp",
                value: "39c24a58-eb23-4afc-bb8f-3b59089714a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f91ec0e5-d768-42e2-8926-de7d3162430f"),
                column: "ConcurrencyStamp",
                value: "757a8f7c-a999-4d85-a862-9535111e0953");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6aa93c41-f21f-44e3-8f46-7d76b03574c5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "SecurityStamp" },
                values: new object[] { "2e378072-8156-48ec-9647-aa0cb06aa17d", new DateTimeOffset(new DateTime(2023, 12, 22, 6, 26, 55, 794, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 0, 0, 0, 0)), "7d4f7c36-f8f0-4b74-8892-08cf807df2c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "SecurityStamp" },
                values: new object[] { "e719779e-b512-4ed4-819b-b763710c35f0", new DateTimeOffset(new DateTime(2023, 12, 22, 6, 26, 55, 794, DateTimeKind.Unspecified).AddTicks(4868), new TimeSpan(0, 0, 0, 0, 0)), "89e91078-da56-48e0-9a3e-6c847d4372e0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7f6b60-6e98-4220-93ea-45f64e0f1aa2"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26429623-f8b1-49de-85a3-57e2c370afcb"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("285a8637-e594-4729-b408-67819bb3e3e9"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("453f44f7-e33e-4477-a2ad-a78e232db482"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cda1ac6-7e1f-4f28-84e9-319455fc7016"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b5e16d-7c46-41b8-9b5a-cb00376c4b60"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("772bc058-2e46-4d3f-ac02-3dd4a6a5aced"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f6f4d09-4292-48cc-a8bf-76e7fe0bb961"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("913f130b-c1b6-4a98-8d63-4cf316da3fc1"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1cee7b3-a6ae-4ae3-bcf4-1955129d8197"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff619bfc-5866-4a5b-9a95-9a8a0e457c91"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 22, 13, 26, 55, 794, DateTimeKind.Utc).AddTicks(4763));
        }
    }
}
