using System.ComponentModel.DataAnnotations;

namespace AspnetCoreIdentity.ViewModels
{
    public class Register
    {
        //system.Data Annotations

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Password and confirmation did not match")]
        public string ConfirmPassword { get; set; }

    }
}
