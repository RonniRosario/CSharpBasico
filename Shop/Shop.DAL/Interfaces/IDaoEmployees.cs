using Shop.DAL.Models.Employees;


namespace Shop.DAL.Interfaces
{
    public interface IDaoEmployees
    {
        void CreateEmployee(EmployeesCreateOrUpdateModel employeesCreateOrUpdate);
        void ModifyEmployee(EmployeesCreateOrUpdateModel employeesCreateOrUpdate);
        void RemoveEmployee(EmployeesRemoveModel employeesRemove);

        List<GetEmployeesModel> GetEmployees();
        GetEmployeesModel GetEmployeeById(int employeeid);

        
    }
}
