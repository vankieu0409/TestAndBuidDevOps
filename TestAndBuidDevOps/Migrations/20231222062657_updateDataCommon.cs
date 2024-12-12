using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestAndBuidDevOps.Migrations
{
    /// <inheritdoc />
    public partial class updateDataCommon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d4b836e-d9fa-4fa9-88c0-9a875d2b7d5c"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "196be9ee-9c5f-4ea0-9b88-f2bd050ea434", "EMPLOYEE" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab251560-a455-40fd-adfd-54f9e150f874"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "39c24a58-eb23-4afc-bb8f-3b59089714a9", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f91ec0e5-d768-42e2-8926-de7d3162430f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "757a8f7c-a999-4d85-a862-9535111e0953", "CUSTOMER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6aa93c41-f21f-44e3-8f46-7d76b03574c5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "2e378072-8156-48ec-9647-aa0cb06aa17d", new DateTimeOffset(new DateTime(2023, 12, 22, 6, 26, 55, 794, DateTimeKind.Utc).AddTicks(4900), new TimeSpan(0, 0, 0, 0, 0)), "KIEUNVPH14806@FPT.EDU.VN", "KIEUNVPH14806@FPT.EDU.VN", "7d4f7c36-f8f0-4b74-8892-08cf807df2c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "e719779e-b512-4ed4-819b-b763710c35f0", new DateTimeOffset(new DateTime(2023, 12, 22, 6, 26, 55, 794, DateTimeKind.Utc).AddTicks(4868), new TimeSpan(0, 0, 0, 0, 0)), "VANKIEU0409@GMAIL.COM", "VANKIEU0409@GMAIL.COM", "89e91078-da56-48e0-9a3e-6c847d4372e0" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d4b836e-d9fa-4fa9-88c0-9a875d2b7d5c"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "39d1083e-90a9-4ea3-929b-1a622e4d572d", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab251560-a455-40fd-adfd-54f9e150f874"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "e02a48f3-5f6b-4d37-b3f2-efe9e9c2061b", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f91ec0e5-d768-42e2-8926-de7d3162430f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "49cd4cb8-2ea9-4637-82b1-161977f147b1", "Customer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6aa93c41-f21f-44e3-8f46-7d76b03574c5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "a2552fe5-e3c5-4585-a0a3-6a72d69a2f85", new DateTimeOffset(new DateTime(2023, 12, 19, 6, 20, 11, 668, DateTimeKind.Utc).AddTicks(9660), new TimeSpan(0, 0, 0, 0, 0)), "kieunvph14806@fpt.edu.vn", "kieunvph14806@fpt.edu.vn", "e0463a78-b9d4-4234-9dce-08e2869cd309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb1eab16-920e-4480-b3ee-01f6e9c15ab5"),
                columns: new[] { "ConcurrencyStamp", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "0b1fefc9-46dd-475b-b2e1-f36f32662b3d", new DateTimeOffset(new DateTime(2023, 12, 19, 6, 20, 11, 668, DateTimeKind.Utc).AddTicks(9634), new TimeSpan(0, 0, 0, 0, 0)), "vankieu0409@gmail.com", "vankieu0409@gmail.com", "fea94f1b-418b-42c9-8f95-59d21798fbcd" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7f6b60-6e98-4220-93ea-45f64e0f1aa2"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26429623-f8b1-49de-85a3-57e2c370afcb"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("285a8637-e594-4729-b408-67819bb3e3e9"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("453f44f7-e33e-4477-a2ad-a78e232db482"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cda1ac6-7e1f-4f28-84e9-319455fc7016"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b5e16d-7c46-41b8-9b5a-cb00376c4b60"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("772bc058-2e46-4d3f-ac02-3dd4a6a5aced"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f6f4d09-4292-48cc-a8bf-76e7fe0bb961"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("913f130b-c1b6-4a98-8d63-4cf316da3fc1"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1cee7b3-a6ae-4ae3-bcf4-1955129d8197"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff619bfc-5866-4a5b-9a95-9a8a0e457c91"),
                column: "UploadedDate",
                value: new DateTime(2023, 12, 19, 13, 20, 11, 668, DateTimeKind.Utc).AddTicks(9504));
        }
    }
}
