using System.ComponentModel.DataAnnotations;

namespace test2.Models
{
    public class UserTbl
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Family { get; set; }
        
        [Required]
        public int Age{ get; set;}
    }
}
