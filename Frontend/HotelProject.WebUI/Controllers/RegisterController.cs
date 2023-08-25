using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace HotelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                LastName = createNewUserDto.LastName,
                UserName = createNewUserDto.UserName,
            };
            var result=await _userManager.CreateAsync(appUser,createNewUserDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
