using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Vue.Controllers
{
    //[Authorize(Roles = "admin")]
    public class ApplicationUsersController : Controller
    {
        #region Methods

        public IActionResult Index()
        {
            return View();
        }

        #endregion Methods
    }
}