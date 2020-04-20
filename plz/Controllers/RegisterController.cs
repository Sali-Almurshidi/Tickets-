using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using plz.Models;

namespace plz.Controllers
{
    public class RegisterController : Controller
    {

        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public RegisterController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Index(RegisterViewModel RegisterModel)
        // {return View(); }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(RegisterViewModel RegisterModel)
        {
            if (!ModelState.IsValid)
            {
                return View(RegisterModel);
            }

            var user = _mapper.Map<User>(RegisterModel);

            var result = await _userManager.CreateAsync(user, RegisterModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(RegisterModel);
            }

            await _userManager.AddToRoleAsync(user, "Visitor");

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }



    }
}