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
            // By default Query Filters applied
            return Ok(await _employeeContext.Authors.ToListAsync());
            // If we want to ignore the Query Filters
           // return Ok(await _employeeContext.Authors.IgnoreQueryFilters().ToListAsync());
        }
    }
}
