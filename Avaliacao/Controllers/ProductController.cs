using Avaliacao.DAL;
using Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Avaliacao.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(int? pagina)
        {
            IList<Product> lista = MockProductDao.GetAllProducts();
            return View(lista.ToPagedList(pagina ?? 1, 10));
        }
    }
}