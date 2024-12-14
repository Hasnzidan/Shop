using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "ManagerName", "Name" },
                values: new object[,]
                {
                    { 1, "John Smith", "Computer Science" },
                    { 2, "Sarah Johnson", "Information Systems" },
                    { 3, "Michael Brown", "Software Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "DeptId", "Drgree", "MinDrgree", "Name" },
                values: new object[,]
                {
                    { 1, 1, 100, 50, "Introduction to Programming" },
                    { 2, 1, 100, 60, "Database Design" },
                    { 3, 2, 100, 55, "Web Development" },
                    { 4, 3, 100, 65, "Software Architecture" }
                });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Address", "DeptId", "Grade", "ImgURL", "Name" },
                values: new object[,]
                {
                    { 1, "123 Student St", 1, "A", "/images/trainees/alex.jpg", "Alex Wilson" },
                    { 2, "456 College Ave", 2, "B+", "/images/trainees/emma.jpg", "Emma Davis" },
                    { 3, "789 University Blvd", 3, "A-", "/images/trainees/james.jpg", "James Miller" }
                });

            migrationBuilder.InsertData(
                table: "CrsDetails",
                columns: new[] { "Id", "Crs_Id", "Degree", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 85, 1 },
                    { 2, 2, 92, 2 },
                    { 3, 3, 78, 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "Address", "CrsId", "DeptId", "ImgURL", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "321 Faculty Lane", 1, 1, "/images/instructors/robert.jpg", "Dr. Robert Wilson", 75000 },
                    { 2, "654 Professor Ave", 2, 2, "/images/instructors/lisa.jpg", "Prof. Lisa Anderson", 80000 },
                    { 3, "987 Teacher St", 3, 3, "/images/instructors/david.jpg", "Dr. David Thompson", 72000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CrsDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CrsDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrsDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
