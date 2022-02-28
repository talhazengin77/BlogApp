using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            var blogs = context.Blogs.Select(i=> new BlogModel()
            {
                Id= i.Id,
                Title = i.Title.Length>100?i.Title.Substring(0,100)+"...":i.Title,
                Description = i.Description,
                Date = i.Date,
                Home = i.Home,
                Confirmation = i.Confirmation,
                Picture = i.Picture
            }).Where(i => i.Confirmation == true && i.Home == true);
            return View(blogs.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}