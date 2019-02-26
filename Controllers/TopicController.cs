using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TopicController : Controller
    {
        // GET: Topic
        public ActionResult CreateTopic()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTopic(TopicModel model)
        {
            if (ModelState.IsValid)
            {
                using (TopicContext db = new TopicContext())
                {
                    
                    DateTime date = DateTime.Now;
                    Topic t = new Topic { Name = model.TopicContent, Author = User.Identity.Name, Date = date };
                    TempData["ViewTopic"] = t;
                    TempData["name"] = t.Name;

                   
                    TempData["author"] = t.Author;
                    TempData["date"] = t.Date;
                    db.Topics.Add(t);
                    db.SaveChanges();
                
                    
                    return RedirectToAction("ViewTopic", "ViewTopic");

                }


            }

            return View(model);
        }
        public ActionResult ShowTopics()
        {
            TopicContext db = new TopicContext();
                if (db != null)
                {
                    ViewBag.list = db.Topics;
                }
            
            return View();
        }
        public ActionResult AddMessage()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMessage(ViewTopicModel model)
        {
            if (ModelState.IsValid)
            {
                Topic t;
                MessageContext db = new MessageContext();
                // db.Messages.Add(new Message() { Parent =});
                if (Request.QueryString["Name"] != null) {
                     t= new Topic() { Name = Convert.ToString(Request.QueryString["Name"]), Date = Convert.ToDateTime(Request.QueryString["Date"]) };
                        }
                else
                {
                     t = new Topic() { Name = Convert.ToString(TempData["name"]), Date = Convert.ToDateTime(TempData["date"]) };

                }
                db.Messages.Add(new Message() { Parent=t,Text = model.MessageContent, Author = User.Identity.Name, Date = DateTime.Now });
                db.SaveChanges();
            }
            return RedirectToAction("ViewTopic", "ViewTopic");
        }
        }
}