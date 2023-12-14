namespace Backend.Repositories
{
    public interface IEmployeeRepo
    {
       Task<List<Employee>> GetEmployees();

        Task AddEmployee(Employee employee);
    }
}
