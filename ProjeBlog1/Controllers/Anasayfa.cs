using Bussiness.Concreate;
using Dal.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBlog1.Controllers
{
    public class Anasayfa : Controller
    {
        PostManager pm = new PostManager(new EfPostRepository());
        public IActionResult Index()
        {
            var values = pm.GetPostListWithCategory();
            return View(values);
        }
        public IActionResult ReadAll(int id)
        {
            var values = pm.GetPostById(id);
            return View(values);
        }
    }
}
