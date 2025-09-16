using Microsoft.AspNetCore.Mvc;

namespace EmailApp.ViewComponents;

public class _MainNavbarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
