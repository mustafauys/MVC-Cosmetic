using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.ViewModels
{
    public class Login
    {
        [Required]
        [Display(Name = "Kullanıcı Adınız")]
        public string username { get; set; }
        [Required]
        [Display(Name = "Parolanız")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = " {0} 6 karakterden az olmamalıdır.", MinimumLength = 6)]
        public string password { get; set; }

    }
}
