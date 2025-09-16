using Microsoft.AspNetCore.Mvc;

namespace EmailApp.ViewComponents;

public class _MainFooterAndScriptsComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
