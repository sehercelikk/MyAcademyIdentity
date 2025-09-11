using EmailApp.Entities;
using EmailApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmailApp.Controllers;

public class LoginController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        var user= await _userManager.FindByEmailAsync(model.Email);
        if (user is null)
        {
            ModelState.AddModelError("", "Kullanıcı Bulunamadı");
            return View(model);
        }
        var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Email veya şifre hatalı");
            return View(model);
        }
        return RedirectToAction("Index", "Home");
    }
}
