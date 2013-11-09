using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreateMutli.Models;

namespace CreateMutli.Controllers
{
    public class MultiController : Controller
    {
        //
        // GET: /Multi/
 public ActionResult Index()
        {
            return View();
        }
       

    
     public ActionResult CreateMutli()
        {
            var pages = new List<Page>();
            return View(pages);
        }

        public ActionResult AddPage(List<Page> pages)
        {
            if (pages == null)
                pages = new List<Page> { };
            ModelState.Clear();
            pages.Add(new Page { });
            return View("CreateMutli", pages);
}

        public ActionResult RemovePage(List<Page> pages, int id)
        {
            ModelState.Clear();
            pages.RemoveAt(id);
            return View("CreateMutli", pages);
        }

        [HttpPost]
        public ActionResult CreateMutli(List<Page> pages)
        {
            return View(pages);
        }

    }







}
