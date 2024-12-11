

using Microsoft.Extensions.Logging;
using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Customer;
using Shop.DAL.Models.Employees;

namespace Shop.DAL.Daos
{
    public class DaoEmployee : IDaoEmployees
    {
        private readonly ShopContext _context;
        private readonly ILogger<DaoEmployee> _logger;

        public DaoEmployee(ShopContext context, ILogger<DaoEmployee> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void CreateEmployee(EmployeesCreateOrUpdateModel employeesCreateOrUpdate)
        {
            try
            {
                Employees employees = new Employees()
                {
                    firstname = employeesCreateOrUpdate.firstname,
                    lastname = employeesCreateOrUpdate.lastname,
                    title = employeesCreateOrUpdate.title,
                    titleofcourtesy = employeesCreateOrUpdate.titleofcourtesy,
                    birthdate = employeesCreateOrUpdate.birthdate,
                    hiredate = employeesCreateOrUpdate.hiredate,
                    phone = employeesCreateOrUpdate.phone,
                    country = employeesCreateOrUpdate.country,
                    city = employeesCreateOrUpdate.city,
                    address = employeesCreateOrUpdate.address,
                    creation_user = employeesCreateOrUpdate.UserId,
                    creation_date = employeesCreateOrUpdate.ChangeDate
                };
                _context.Add(employees);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error creando un producto", ex.ToString());
            }
        }

        public GetEmployeesModel GetEmployeeById(int employeeid)
        {
            GetEmployeesModel employeeFound = new GetEmployeesModel();
            try
            {
                Employees? employees = _context.Employees.Find(employeeid);

                employeeFound.empid = employees.empid;
                employeeFound.firstname = employees.firstname;
                employeeFound.lastname = employees.lastname;
                employeeFound.hiredate = employees.hiredate;
                employeeFound.birthdate = employees.birthdate;
                employeeFound.phone = employees.phone;
                employeeFound.country = employees.country;
                employeeFound.address = employees.address;
                employeeFound.city = employees.city;
                employeeFound.title = employees.title;
                employeeFound.titleofcourtesy = employees.titleofcourtesy;

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error Obteniendo un producto", ex.ToString());
            }
            return employeeFound;
        }

        public List<GetEmployeesModel> GetEmployees()
        {
            List<GetEmployeesModel> employeesList = new List<GetEmployeesModel>();
            try
            {
                employeesList = (from employees in _context.Employees
                                where employees.deleted == false
                                select new GetEmployeesModel()
                                {
                                    empid = employees.empid,
                                    firstname = employees.firstname,
                                    lastname = employees.lastname,
                                    hiredate = employees.hiredate,
                                    phone = employees.phone,
                                    address = employees.address,
                                    country = employees.country,
                                    city = employees.city,
                                    birthdate = employees.birthdate,
                                    title = employees.title,
                                    titleofcourtesy = employees.titleofcourtesy,

                                }).ToList();

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error listando los productos", ex.ToString());
            }
            return employeesList;
        }

        public void ModifyEmployee(EmployeesCreateOrUpdateModel employeesCreateOrUpdate)
        {
            try
            {
                Employees? employeeToUpdate = _context.Employees.Find(employeesCreateOrUpdate.empid);

                NotFoundEmployee(employeesCreateOrUpdate);
                
                employeeToUpdate.firstname = employeesCreateOrUpdate.firstname;
                employeeToUpdate.lastname = employeesCreateOrUpdate.lastname;
                employeeToUpdate.city = employeesCreateOrUpdate.city;
                employeeToUpdate.title = employeesCreateOrUpdate.title;
                employeeToUpdate.titleofcourtesy = employeesCreateOrUpdate.titleofcourtesy;
                employeeToUpdate.phone = employeesCreateOrUpdate.phone;
                employeeToUpdate.country = employeesCreateOrUpdate.country;
                employeeToUpdate.address = employeesCreateOrUpdate.address;
                employeeToUpdate.birthdate = employeesCreateOrUpdate.birthdate;
                employeeToUpdate.hiredate = employeesCreateOrUpdate.hiredate;
                employeeToUpdate.creation_user = employeesCreateOrUpdate.UserId;
                employeeToUpdate.creation_date = employeesCreateOrUpdate.ChangeDate;

                _context.Employees.Update(employeeToUpdate);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error modificando un producto", ex.ToString());
            }
        }

        public void RemoveEmployee(EmployeesRemoveModel employeeRemove)
        {
            try
            {
                Employees? employeeToRemove = _context.Employees.Find(employeeRemove.empid);

                employeeToRemove.delete_date = employeeRemove.delete_date;
                employeeToRemove.deleted = true;
                employeeToRemove.delete_user = employeeRemove.delete_user;

                _context.Employees.Update(employeeToRemove);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error removiendo un producto", ex.ToString());
            }
        }

        public void NotFoundEmployee(EmployeesCreateOrUpdateModel employeesCreateOrUpdate)
        {
            if (employeesCreateOrUpdate.empid == null)
            {
                Console.WriteLine("No se encontro el empleado");
            }
        }
    }
}
