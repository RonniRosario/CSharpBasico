

using Microsoft.Extensions.Logging;
using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Products;
using Shop.DAL.Exceptions;
using Shop.DAL.Entities;

namespace Shop.DAL.Daos
{
    public class DaoProduct : IDaoProducts
    {
        private readonly ShopContext _context;
        private readonly ILogger<DaoProduct> _logger;

        public DaoProduct(ShopContext context, ILogger<DaoProduct> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void CreateProduct(ProductsCreateOrUpdateModel productsCreateOrUpdate)
        {
            try
            {
                if (productsCreateOrUpdate is null) 
                {
                    throw new ProductsDaoException("Debe suministrar el parametro.");
                }

                Products products = new Products()
                {
                    productid = productsCreateOrUpdate.productid,
                    productname = productsCreateOrUpdate.productname,
                    supplierid = productsCreateOrUpdate.supplierid,
                    categoryid = productsCreateOrUpdate.categoryid,
                    creation_user = productsCreateOrUpdate.UserId,
                    creation_date = productsCreateOrUpdate.ChangeDate,
                    unitprice = productsCreateOrUpdate.unitprice,
                    discontinued = productsCreateOrUpdate.discontinued,
                };

                _context.Products.Add(products);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error creando un producto", ex.ToString());
            }
        }

        public List<GetProductsModel> GetProducts()
        {
            List<GetProductsModel> productsList = new List<GetProductsModel>();
            try
            {
                productsList = (from products in _context.Products
                                where products.deleted == false
                                select new GetProductsModel()
                                {
                                    productid = products.productid,
                                    productname = products.productname,
                                    creation_date = products.creation_date,
                                    unitprice = products.unitprice,

                                }).ToList();


            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error listando los productos", ex.ToString());
            }
            return productsList;
        }

        public GetProductsModel GetProductsModel(int productid)
        {
           GetProductsModel productFound = new GetProductsModel();

            try
            {
                Products? products = _context.Products.Find(productid);

                productFound.productid = products.productid;
                productFound.productname = products.productname;
                productFound.unitprice= products.unitprice; 
                productFound.creation_date = products.creation_date;
                
                
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error obteniendo un producto", ex.ToString());
            }
            return productFound;
        }

        public void ModifyProduct(ProductsCreateOrUpdateModel productsCreateOrUpdate)
        {
            try
            {
                Products? productToUpdate = _context.Products.Find(productsCreateOrUpdate.productid);
                //Lanzar excepcion que el producto que esta tratando de modificar no se encuentra 

                productToUpdate.productid = productsCreateOrUpdate.productid;
                productToUpdate.productname = productsCreateOrUpdate.productname;
                productToUpdate.supplierid = productsCreateOrUpdate.supplierid;
                productToUpdate.categoryid = productsCreateOrUpdate.categoryid;
                productToUpdate.creation_user = productsCreateOrUpdate.UserId;
                productToUpdate.creation_date = productsCreateOrUpdate.ChangeDate;
                productToUpdate.unitprice = productsCreateOrUpdate.unitprice;
                productToUpdate.discontinued = productsCreateOrUpdate.discontinued;

                _context.Products.Update(productToUpdate);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error modificando un producto", ex.ToString());
            }
        }

        public void RemoveProduct(ProductsRemoveModel productsRemove)
        {
            try
            {
                Products? productToRemove = _context.Products.Find(productsRemove.productid);
                
                productToRemove.delete_date = productsRemove.delete_date;
                productToRemove.deleted = true;
                productToRemove.delete_user = productsRemove.delete_user;

                _context.Products.Update(productToRemove);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError("Ocurrio un error modificando un producto", ex.ToString());
            }
        }

        
    }
}
