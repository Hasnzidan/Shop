using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class CrsDetails
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }

        public Course Course { get; set; }
        public Trainee Trainee { get; set; }

    }
}
