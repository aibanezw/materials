using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Materials.Web.Models;

namespace Materials.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bienvenidos al portal Materiales";

            return View();
        }

        [HttpGet]
        public ActionResult Product()
        {
            ViewBag.Message = "Catálogo de Productos";

            return View();
        }

        public ActionResult ProductSearchResult()
        {
            ViewBag.Message = "Resultado de Búsqueda de Productos";

            return View();
        }

        public JsonResult ProductSearchQueryResult()
        {
            List<ProductModel> products = new List<ProductModel>();
            for (int i = 1; i < 10; i++)
                products.Add(new ProductModel()
                {
                    ProductId = i,
                    ProductName = string.Format("Product-{0}", i),
                    Logo = string.Format("Logo-{0}", i),
                    File = string.Format("File-{0}", i),
                    Program = string.Format("Program-{0}", i)
                });

            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Content()
        {
            ViewBag.Message = "Ingreso de Contenido";

            return View();
        }

        public ActionResult Supplier()
        {
            ViewBag.Message = "Ingreso de Proveedores";

            return View();
        }

        [Authorize(Roles = "Plus")]
        public ActionResult Administration()
        {
            ViewBag.Message = "Administración del Portal";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contáctenos";

            return View();
        }

        //Test knockout
        public ActionResult SaveProducts(List<ProductModel> products)
        {
            throw new NotImplementedException();
        }
    }
}
