
using Shop.DAL.Models.Products;

namespace Shop.DAL.Interfaces
{
    public interface IDaoProducts
    {
        void CreateProduct(ProductsCreateOrUpdateModel productsCreateOrUpdate);
        void ModifyProduct(ProductsCreateOrUpdateModel productsCreateOrUpdate);
        void RemoveProduct(ProductsRemoveModel productsRemove);
       
        GetProductsModel GetProductsModel(int productid);

        List<GetProductsModel> GetProducts(); 



    }
}
