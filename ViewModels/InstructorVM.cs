using System.ComponentModel.DataAnnotations;
using Shop.Models;

namespace Shop.ViewModels
{
    public class InstructorVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public string? ImgURL { get; set; }
        public string? Address { get; set; }
        [Required]
        public int DeptId { get; set; }
         [Required]
        public int CrsId { get; set; }
        public List<Department>? Department { get; set; }
        public List<Course>? Course { get; set; }
    }
}
