using Backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _repo;

        public EmployeeController(IEmployeeRepo repo)
        {
            this._repo = repo;
        }
        [HttpPost("AddEmployee")]
        public async Task AddEmployee(Employee emp)
        {
            _repo.AddEmployee(emp);
        }
        [HttpGet("GetEmployees")]
        public async Task<List<Employee>> GetEmployees()
        {
           return await _repo.GetEmployees();
        }
    }
}
