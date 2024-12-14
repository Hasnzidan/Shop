using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base()
            {

            }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<CrsDetails> CrsDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI3db;Trusted_Connection=True;Encrypt=False;Integrated Security=true;trust server certificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        // In ApplicationDbContext.cs, override OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science", ManagerName = "John Smith" },
                new Department { Id = 2, Name = "Information Systems", ManagerName = "Sarah Johnson" },
                new Department { Id = 3, Name = "Software Engineering", ManagerName = "Michael Brown" }
            );

            // Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Introduction to Programming", Drgree = 100, MinDrgree = 50, DeptId = 1 },
                new Course { Id = 2, Name = "Database Design", Drgree = 100, MinDrgree = 60, DeptId = 1 },
                new Course { Id = 3, Name = "Web Development", Drgree = 100, MinDrgree = 55, DeptId = 2 },
                new Course { Id = 4, Name = "Software Architecture", Drgree = 100, MinDrgree = 65, DeptId = 3 }
            );

            // Trainees
            modelBuilder.Entity<Trainee>().HasData(
                new Trainee { Id = 1, Name = "Alex Wilson", ImgURL = "/images/trainees/alex.jpg", Address = "123 Student St", Grade = "A", DeptId = 1 },
                new Trainee { Id = 2, Name = "Emma Davis", ImgURL = "/images/trainees/emma.jpg", Address = "456 College Ave", Grade = "B+", DeptId = 2 },
                new Trainee { Id = 3, Name = "James Miller", ImgURL = "/images/trainees/james.jpg", Address = "789 University Blvd", Grade = "A-", DeptId = 3 }
            );

            // Instructors
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { Id = 1, Name = "Dr. Robert Wilson", Salary = 75000, ImgURL = "/images/instructors/robert.jpg", Address = "321 Faculty Lane", DeptId = 1, CrsId = 1 },
                new Instructor { Id = 2, Name = "Prof. Lisa Anderson", Salary = 80000, ImgURL = "/images/instructors/lisa.jpg", Address = "654 Professor Ave", DeptId = 2, CrsId = 2 },
                new Instructor { Id = 3, Name = "Dr. David Thompson", Salary = 72000, ImgURL = "/images/instructors/david.jpg", Address = "987 Teacher St", DeptId = 3, CrsId = 3 }
            );

            // CrsDetails
            modelBuilder.Entity<CrsDetails>().HasData(
                new CrsDetails { Id = 1, Degree = 85, Crs_Id = 1, TraineeId = 1 },
                new CrsDetails { Id = 2, Degree = 92, Crs_Id = 2, TraineeId = 2 },
                new CrsDetails { Id = 3, Degree = 78, Crs_Id = 3, TraineeId = 3 }
            );
        }
    }
}
