using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Models
{
    public class UserProf

    {
        [Required]
        public int Id { get; set; }


        [Required(ErrorMessage ="Введіть ім'я!")]
        [Display(Name ="Ім'я")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Введіть прізвище!")]
        [Display(Name ="Прізвище")]
        public string LastName { get; set; }


        [Required(ErrorMessage ="Введіть коректний email")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }








    }
}
