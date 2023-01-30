using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QueryFilterEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeContext _employeeContext;

        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext=employeeContext;
        }
        [HttpGet(nameof(GetEmployees))]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _employeeContext.Authors.ToListAsync());
        }
    }
}
