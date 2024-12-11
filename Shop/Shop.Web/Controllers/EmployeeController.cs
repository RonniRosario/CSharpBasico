
using Microsoft.AspNetCore.Mvc;

using Shop.DAL.Interfaces;
using Shop.DAL.Models.Employees;

namespace Shop.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDaoEmployees _daoEmployees;

        public EmployeeController(IDaoEmployees daoEmployees)
        {
            _daoEmployees = daoEmployees;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = _daoEmployees.GetEmployees();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employees = _daoEmployees.GetEmployeeById(id);
            return View(employees);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeesCreateOrUpdateModel createModel)
        {
            try
            {
                createModel.UserId = 1;
                createModel.ChangeDate = DateTime.Now;
                _daoEmployees.CreateEmployee(createModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(createModel);
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employees = _daoEmployees.GetEmployeeById(id);
            return View(employees);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeesCreateOrUpdateModel updateModel)
        {
            try
            {
                updateModel.UserId = 1;
                updateModel.ChangeDate = DateTime.Now;
                _daoEmployees.ModifyEmployee(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
