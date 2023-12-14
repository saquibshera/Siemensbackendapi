using Backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DataContext _dt;

        public EmployeeRepo(DataContext dt) {
            this._dt = dt;
        }
        public async Task AddEmployee(Employee employee)
        {
           _dt.Employeetable.Add(employee);
           await _dt.SaveChangesAsync();
            
        }

        public async Task<List<Employee>> GetEmployees()
        {
           return await _dt.Employeetable.ToListAsync();
        }
    }
}
