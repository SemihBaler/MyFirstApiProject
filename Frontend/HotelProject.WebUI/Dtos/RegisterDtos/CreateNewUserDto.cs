using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace HotelProject.WebUI.Dtos.RegisterDtos
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad gereklidir!!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad gereklidir!!!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı gereklidir!!!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail gereklidir!!!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre gereklidir!!!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrarı gereklidir!!!")]
        [Compare("Password",ErrorMessage = "Şifreler uyuşmuyor!!!")]
        public string ConfirmPassword { get; set; }
    }
}
