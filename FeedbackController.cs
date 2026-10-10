using System.Collections.Generic;
using System.Web.Mvc;
using studentfeedback.Models;

namespace studentfeedback.Controllers
{
    public class feedbackController : Controller
    {
        static List<feedback> feedbackList = new List<feedback>();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(feedback model)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(model);
                return RedirectToAction("List");
            }
            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}
