﻿using EmailApp.Entities;
using EmailApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmailApp.Controllers;

public class RegisterController(UserManager<AppUser> _userManager) : Controller
{
    public IActionResult Signup()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Signup(RegisterViewModel model)
    {
        var user = new AppUser
        {
            FristName = model.FristName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.UserName
        };
        var result =await _userManager.CreateAsync(user, model.Password);
        if (!result.Succeeded)
        {
           foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
           return View(model);
        }
        return RedirectToAction("Index","Login");
    }
}
