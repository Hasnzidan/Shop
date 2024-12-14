namespace Shop.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ManagerName { get; set; }

        public List<Instructor> Instructor { get; set; }
        public List<Trainee> Trainee { get; set; }
        public List<Course> Course { get; set; }
    }
}
