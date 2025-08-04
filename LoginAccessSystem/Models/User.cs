using System.ComponentModel.DataAnnotations;

namespace LoginAccessSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string password { get; set; }

    }
}
