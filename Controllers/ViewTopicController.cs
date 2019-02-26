using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ViewTopicController : Controller
    {
        // GET: ViewTopic
        public ActionResult ViewTopic()
        {
            MessageContext db = new MessageContext();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ViewTopic(ViewTopicModel model)
        {
            MessageContext db = new MessageContext();
            // db.Messages.Add(new Message() { Parent =});
            ViewData["msg"] = db.Messages.Where<Message>(c => c.Parent.Equals(TempData["ViewTopic"]));
            ViewData["msg"] =new Message[]{ new Message() { Text = "egfr" },new Message() { Text = "egfr" }};
            return View();
        }
    }
}