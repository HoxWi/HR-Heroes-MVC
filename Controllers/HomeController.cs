using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HoxWi.Db.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        IClient hoxWiClient = new Client(Mode.Dynamic, StorageType.Mysql);

        public ActionResult Search(string term)
        {            
            return View("_search", hoxWiClient.Search(new SearchRequest("Resumes", new { resume = "Like " + term })));
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(FormCollection form)
        {
            var result = hoxWiClient.Add(new InsertRequest("Resumes", ToDictionary(form)));
            if (result.Success)
            {
                ViewBag.SuccessMessage = "Resume has been added.";
            }
            else ViewBag.ErrorMessage = result.Error;

            return View();
        }

        public ActionResult Update(string id)
        {            
           return View(hoxWiClient.GetById(new SearchRequest("Resumes", new { hid = id })));
        }

        [HttpPost]
        public ActionResult Update(FormCollection form)
        {
            var result = hoxWiClient.Update(new UpdateRequest("Resumes", ToDictionary(form)));
            if (result.Success)
            {
                ViewBag.SuccessMessage = "Resume has been updated.";
            }
            else ViewBag.ErrorMessage = result.Error;

            return View("Index");
        }

        public static IDictionary<string, string> ToDictionary(FormCollection col)
        {
            var dict = new Dictionary<string, string>();

            foreach (string key in col.Keys)
            {
                dict.Add(key, col[key]);
            }

            return dict;
        }


    }
}