using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Drgree { get; set; }
        public int MinDrgree { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public List<Instructor> Instructor { get; set; }
        public Department Department { get; set; }
        public List<CrsDetails> CrsDetails { get; set; }

    }
}
