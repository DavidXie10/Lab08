using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab___08.Models;
using Lab___08.Handlers;

namespace Lab___08.Controllers
{
    public class ProductsController : Controller {
        private ProductsHandler ProductsHandler;

        public ProductsController() {
            ProductsHandler = new ProductsHandler();
        }

        public ActionResult Index() {
            return View();
        }

        public JsonResult GetAllProducts() {
            var products = ProductsHandler.GetAll();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}