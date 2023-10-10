using LinqToDB.Mapping;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Register1.Model
{
    public class User
    {
        [Identity]
        public int Id { get; set; }
        [Required]
        public string FirsName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        [MaxLength(8)]
        public string Password { get; set; }
    }
}
