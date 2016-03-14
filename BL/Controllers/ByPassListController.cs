using System;
using System.Web.Mvc;
using Domain.Implementation;
using Domain.Logic;

namespace BL.Controllers
{
    [Authorize]
    public class ByPassListController : Controller
    {

        public ByPassListController()
        {

        }

        public ActionResult Index()
        {
            IByPassList byPassList = new ByPassListManager();
            var model = byPassList.GetLists();
            return View(model);
        }


        public ActionResult Details(Guid? id)
        {
            if (id.HasValue)
            {
                return null;
            }
            else
            {
                return HttpNotFound();
            }
        }


    }
}