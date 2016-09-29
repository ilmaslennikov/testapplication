using System.Web.Mvc;
using MVCAplicationServices;

namespace SampleMVCSPAApplications.Controllers
{
    /// <summary>
    /// Контроллер, используемый для работы с общими представлениями
    /// </summary>
    public class SharedController : Controller
    {
        private readonly IMenuService _menuService;
        public SharedController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public ActionResult Menu()
        {
            return PartialView("_MenuPartial", _menuService.GetMenu());
        }
    }
}