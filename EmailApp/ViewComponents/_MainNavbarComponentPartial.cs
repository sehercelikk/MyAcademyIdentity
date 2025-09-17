using EmailApp.Context;
using EmailApp.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmailApp.ViewComponents;

public class _MainNavbarComponentPartial(UserManager<AppUser> _userManager,AppDbContext _context) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        var message = await _context.Messages.Include(a => a.Sender)
            .Where(a => a.RecieverId == user.Id & a.IsRead == false)
            .OrderByDescending(a => a.SendDate).Take(3).ToListAsync();
        ViewBag.IsRead=message.Where(a => a.IsRead == false).Count();
        return View(message);
    }
    
}
