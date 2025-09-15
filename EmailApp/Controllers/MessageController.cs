using EmailApp.Context;
using EmailApp.Entities;
using EmailApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmailApp.Controllers;

[Authorize]
public class MessageController(AppDbContext _context,UserManager<AppUser> _userManager) : Controller
{
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        var messages =await _context.Messages.Include(a=>a.Sender).Where(a => a.RecieverId == user.Id).ToListAsync();

        return View(messages);
    }

    public async Task<IActionResult> MessageDetail(int id)
    {
        var message = await _context.Messages.Include(a => a.Sender).FirstOrDefaultAsync(a => a.MessageId == id);
        return View(message);
    }
    public IActionResult SendMessage() => View();

    [HttpPost]
    public async Task<IActionResult> SendMessage(SendMessageViewModel model)
    {
        var sender = await _userManager.FindByNameAsync(User.Identity.Name); //Giriş Yapan kullanıcı
        var reciever = await _userManager.FindByEmailAsync(model.RecieverEmail);
        var message = new Message
        {
            Body = model.Body,
            Subject = model.Subject,
            RecieverId = reciever.Id,
            SenderId = sender.Id,
            SendDate = DateTime.Now,
        };
        await _context.Messages.AddAsync(message);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}
