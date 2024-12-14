using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string ImgURL { get; set; }
        public string?  Address { get; set; }
        public string Grade { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public Department Department { get; set; }

        public List<CrsDetails> CrsDetails { get; set; }



    }
}
