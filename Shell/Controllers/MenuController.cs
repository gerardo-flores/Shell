//
// Copyright Info Here
//

using System.Web.Mvc;
using Shell.ViewModels;
using Shell.Infrastructure.IdStore;
using Shell.Infrastructure.Logging;

namespace Shell.Controllers
{
    public class MenuController : ApplicationController
    {
        public MenuController(IIdStore idStore, ILogger logger)
            : base(idStore, logger)
        { }

        [ChildActionOnly]
        public ActionResult Index()
        {
            MenuViewModel model = new MenuViewModel
            {
                CurrentUser = this.CurrentUser
            };

            return PartialView("~/Views/Shared/_Header.cshtml", model);
        }
    }
}
