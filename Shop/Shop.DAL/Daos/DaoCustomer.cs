

using Microsoft.Extensions.Logging;
using Shop.DAL.Context;
using Shop.DAL.Entities;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Customer;



namespace Shop.DAL.Daos
{
    public class DaoCustomer : IDaoCustomer
    {
        private readonly ShopContext _context;
        private readonly ILogger<DaoCustomer> _logger;

        public DaoCustomer(ShopContext context, ILogger<DaoCustomer> logger)
        {
            _context = context;
            _logger = logger; 
        }
        public void CreateCustomer(CustomerCreateOrUpdateModel customerCreateOrUpdate)
        {
            try
            {
                Customer customer = new Customer()
                {
                    custid = customerCreateOrUpdate.custid,
                    companyname = customerCreateOrUpdate.companyname, 
                    contactname = customerCreateOrUpdate.contactname,
                    contacttitle = customerCreateOrUpdate.contacttitle,
                    phone = customerCreateOrUpdate.phone,
                    country = customerCreateOrUpdate.country,
                    city = customerCreateOrUpdate.city,
                    address = customerCreateOrUpdate.address,
                    creation_date = customerCreateOrUpdate.ChangeDate,
                    creation_user = customerCreateOrUpdate.UserId,
                    email = customerCreateOrUpdate.email
                };
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error creando un producto", ex.ToString());
            }
        }

        public List<GetCustomersModel> GetCustomer()
        {
            List<GetCustomersModel> customersList = new List<GetCustomersModel>();
            try
            {
                customersList = (from customer in _context.Customers
                                where customer.deleted == false
                                select new GetCustomersModel()
                                {
                                    custid = customer.custid,
                                    email = customer.email,
                                    creation_date = customer.creation_date,
                                    companyname = customer.companyname,
                                    address = customer.address,
                                    country = customer.country,
                                    city = customer.city

                                }).ToList();

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error listando los Clientes", ex.ToString());
            }
            return customersList;
        }

        public GetCustomersModel GetCustomersById(int customerid)
        {
            GetCustomersModel customerFound = new GetCustomersModel();
            try
            {
                Customer? customer = _context.Customers.Find(customerid);

                customerFound.custid = customer.custid;
                customerFound.email = customer.email;
                customerFound.creation_date = customer.creation_date;
                customerFound.companyname = customer.companyname;
                customerFound.address = customer.address;
                customerFound.country = customer.country;
                customerFound.city = customer.city;

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error obteniendo un producto", ex.ToString());
            }
            return customerFound;
        }

        public void ModifyCustomer(CustomerCreateOrUpdateModel customerCreateOrUpdate)
        {
            try
            {
                Customer? customerToUpdate = _context.Customers.Find(customerCreateOrUpdate.custid);

                NotFoundCustomer(customerCreateOrUpdate);

                customerToUpdate.custid = customerCreateOrUpdate.custid;
                customerToUpdate.email = customerCreateOrUpdate.email;
                customerToUpdate.companyname = customerCreateOrUpdate.companyname;
                customerToUpdate.contacttitle = customerCreateOrUpdate.contacttitle;
                customerToUpdate.contactname = customerCreateOrUpdate.contactname;
                customerToUpdate.phone = customerCreateOrUpdate.phone;
                customerToUpdate.address = customerCreateOrUpdate.address;
                customerToUpdate.country = customerCreateOrUpdate.country;
                customerToUpdate.city = customerCreateOrUpdate.city;
                customerToUpdate.creation_date = customerCreateOrUpdate.ChangeDate;
                customerToUpdate.creation_user = customerCreateOrUpdate.UserId;

                _context.Customers.Update(customerToUpdate);
                _context.SaveChanges();
                
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error modificando los productos", ex.ToString());
            }
        }

        public void RemoveCustomer(CustomerRemoveModel CustomerRemove)
        {
            try
            {

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error creando un producto", ex.ToString());
            }
        }

        public void NotFoundCustomer(CustomerCreateOrUpdateModel customerCreateOrUpdate)
        {
            if (customerCreateOrUpdate.custid == null)
            {
                Console.WriteLine("No se encontro el cliente");
            }
        }
    }

 

}
