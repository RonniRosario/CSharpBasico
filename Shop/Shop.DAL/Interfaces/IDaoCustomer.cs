using Shop.DAL.Models.Customer;



namespace Shop.DAL.Interfaces
{
    public interface IDaoCustomer
    {
        void CreateCustomer(CustomerCreateOrUpdateModel customerCreateOrUpdate);
        void ModifyCustomer(CustomerCreateOrUpdateModel customerCreateOrUpdate);
        void RemoveCustomer(CustomerRemoveModel CustomerRemove);

        GetCustomersModel GetCustomersById(int customerid);

        List<GetCustomersModel> GetCustomer();
    }
}
