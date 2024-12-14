using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Instructor
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public int Salary { get; set; }
        public string ImgURL { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        [ForeignKey("Course")]
        public int CrsId { get; set; }



        public Department Department { get; set; }
        public Course Course { get; set; }
    }
}
