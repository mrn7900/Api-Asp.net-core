using System.ComponentModel.DataAnnotations;

namespace test2.Models.Department
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
