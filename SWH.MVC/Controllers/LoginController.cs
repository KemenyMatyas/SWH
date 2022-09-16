namespace SWH.MVC.Controllers
{
    using Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Services.IServices;
    using Services.Services;

    public class LoginController : Controller
    {
        private readonly IUserService _userService;


        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginUserDto loginUserDto)
        {
            var userLogin = _userService.Login(loginUserDto);
            if (userLogin.IsLogin)
            {
                AuthService.IsLoggedIn = true;
                return RedirectToAction("Index", "Home"); 
            }

            return View("Index", loginUserDto);
        }
        
    }
}