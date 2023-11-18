using System.ComponentModel.DataAnnotations;

namespace yeni_layihe.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string? UserName { get; set; }
        
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password can't match!")]
        public string? ConfirmPassword {get; set;}
        public string? Mobile { get; set; }
    }
}