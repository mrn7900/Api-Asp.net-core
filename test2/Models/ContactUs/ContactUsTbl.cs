using System.ComponentModel.DataAnnotations;

namespace test2.Models
{
    public class ContactUsTbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long PhoneNumber { get; set; }


    }
}
