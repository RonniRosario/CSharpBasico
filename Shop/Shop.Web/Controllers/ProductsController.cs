
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Products;

namespace Shop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IDaoProducts _daoProducts;

        public ProductsController(IDaoProducts daoProducts)
        {
            _daoProducts = daoProducts;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            var products = _daoProducts.GetProducts();
            return View(products);
            
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var products = _daoProducts.GetProductsById(id);
            return View(products);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductsCreateOrUpdateModel createModel)
        {
            try
            {
                createModel.UserId = 1;
                createModel.ChangeDate = DateTime.Now;
                _daoProducts.CreateProduct(createModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {

            var products = _daoProducts.GetProductsById(id);
            return View(products);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductsCreateOrUpdateModel updateModel)
        {
            try
            {
                updateModel.UserId = 1;
                updateModel.ChangeDate = DateTime.Now;
                _daoProducts.ModifyProduct(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
