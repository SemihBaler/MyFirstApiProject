using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents
{
    public class _AboutUsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
