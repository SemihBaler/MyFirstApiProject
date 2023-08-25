using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace HotelProject.WebUI.Dtos.LoginDtos
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı adınızı giriniz!!!")]
        public string  UserName { get; set; }
        [Required(ErrorMessage = "Şifrenizi giriniz!!!")]
        public string  Password { get; set; }
    }
}
