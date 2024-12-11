using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Customer;

namespace Shop.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IDaoCustomer _daoCustomer;

        public CustomerController(IDaoCustomer daoCustomer)
        {
            _daoCustomer = daoCustomer;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var customer = _daoCustomer.GetCustomer();
            return View(customer);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var customer = _daoCustomer.GetCustomersById(id);
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateOrUpdateModel createModel)
        {
            try
            {
                createModel.UserId = 1;
                createModel.ChangeDate = DateTime.Now;
                _daoCustomer.CreateCustomer(createModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _daoCustomer.GetCustomersById(id);
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerCreateOrUpdateModel updateModel)
        {
            try
            {
                updateModel.UserId = 1;
                updateModel.ChangeDate = DateTime.Now;
                _daoCustomer.ModifyCustomer(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
