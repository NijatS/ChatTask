using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
		{
			List<AppUser> appUsers = await _userManager.Users.ToListAsync();
			return View(appUsers);
		}

		public async Task<IActionResult> CreateUser()
		{
			await _userManager.CreateAsync(new AppUser { Email="Nicat@mail.ru",UserName="NicatCode"},"Nicat123@");
			await _userManager.CreateAsync(new AppUser { Email="Isa@mail.ru",UserName="JesusCode"},"Jesus123@");
			await _userManager.CreateAsync(new AppUser { Email="Sineray@mail.ru",UserName="SinerayCode"},"Sineray123@");
			await _userManager.CreateAsync(new AppUser { Email="Dayday@mail.ru",UserName= "DaydayCode" }, "Dayday123@");
            return Json("Ok");
		}

		

	}
}