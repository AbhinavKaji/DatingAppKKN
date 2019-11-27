using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string userName { get; set; }
        [StringLength(8,MinimumLength=4,ErrorMessage="give password of length 4 to 8")]
        public string password { get; set; }
    }
}