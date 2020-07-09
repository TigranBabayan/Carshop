using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Մուտքագրեք Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Մուտքագրեք Գաղտնաբառը")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Գաղտնաբառը չի համընկնում")]
        public string ConfirmPassword { get; set; }
    }
}
