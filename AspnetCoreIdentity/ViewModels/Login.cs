using System.ComponentModel.DataAnnotations;

namespace AspnetCoreIdentity.ViewModels
{
    public class Login
    { /// <summary>
    /// Data Annotations needed to annotate the required attributes!
    /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
