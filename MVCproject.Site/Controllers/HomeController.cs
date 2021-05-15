using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCproject.Data.Services;
using MVCproject.Data.Models;

namespace MVCproject.Site.Controllers
{
    public class HomeController : Controller
    {
        private IHeladeriaData _db;
        public HomeController(IHeladeriaData heladeriaData)
        {
            _db = heladeriaData;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model); //=> HTML
        }
        //vista vacio
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //datos almacenar informacion vista llena
        [HttpPost]
        public ActionResult Create(Heladeria model)
        {
            return View();
        }
    }
}