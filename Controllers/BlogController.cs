using LearningASPNETMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASPNETMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public class Employee
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
        }
        public ActionResult Index()
        {

            ViewBag.BlogList = "Blog list";
            this.Response.AppendHeader("x-status", "400");
            this.Response.AppendHeader("my-cookies", "hay this is created by Sourav");

            List<Blog> BlogList = new List<Blog>()
            {
                new Blog(){Id=1, Title="First Blog", Category="default", Content="this is my first blog" },
                new Blog(){Id=1, Title="Second detail Blog", Category="default", Content="this is my second blog" },
                new Blog(){Id=1, Title="third Blog", Category="default", Content="this is my third blog" },
            };

            return View(BlogList);
        }

        public string AddBlog()
        {
            return "add blog page";
        }

        public ActionResult Find(string id)
        {
            Employee emp = new Employee()
            {
                ID = "64",
                Name = "Sourav Ganguly",
                Designation = "Junior SDE"
            };
            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Api()
        {
            string json = "{\"blogs\":{}}";
            return Json(json);
        }

        public ActionResult GetBlog()
        {
            return Content("get blog");
        }
    }
}