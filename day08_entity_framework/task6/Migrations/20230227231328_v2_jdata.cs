﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace task6.Migrations
{
    /// <inheritdoc />
    public partial class v2_jdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassStudent",
                columns: new[] { "ClassesID", "StudentsID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ClassStudent",
                keyColumns: new[] { "ClassesID", "StudentsID" },
                keyValues: new object[] { 3, 3 });
        }
    }
}
