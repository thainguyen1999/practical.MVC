using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace practical.MVC.Entities
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]

        public double Price { get; set; }
        [StringLength(150)]
        public string Thumbnail { get; set; }
    }
}
