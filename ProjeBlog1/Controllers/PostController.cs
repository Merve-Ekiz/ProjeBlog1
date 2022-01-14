using Bussiness.Concreate;
using Bussiness.ValidationFluent;
using Dal.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBlog1.Controllers
{
    public class PostController : Controller
    {
        PostManager pm = new PostManager(new EfPostRepository());
        public IActionResult PostListe()
        {
            var values = pm.Getlist();
            return View(values);
        }
        [HttpGet]
        public IActionResult PostAdded()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostAdded(Post p)
        {
            PostValidator pv = new PostValidator();
            ValidationResult results = pv.Validate(p);
            if (results.IsValid)
            {
             
                pm.TAdd(p);
                return RedirectToAction("PostListe", "Post");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePost(int id)
        {
            var postvalue = pm.GetlistById(id);
            pm.TDelete(postvalue);
            return RedirectToAction("PostListe");
        }
        [HttpGet]
        public IActionResult EditPost(int id)
        {
            var Postvalue = pm.GetlistById(id);
            return View(Postvalue);
        }
        [HttpPost]
        public IActionResult EditPost(Post p)
        {
            pm.TUpdate(p);
            return RedirectToAction("PostListe");
            
        }
    }
}
