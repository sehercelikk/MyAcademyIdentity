using Microsoft.AspNetCore.Mvc;

namespace EmailApp.ViewComponents;

public class _MainHeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
